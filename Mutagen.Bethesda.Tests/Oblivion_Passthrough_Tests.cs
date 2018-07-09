﻿using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Internals;
using Mutagen.Bethesda.Oblivion;
using Mutagen.Bethesda.Oblivion.Internals;
using Noggog;
using Noggog.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Mutagen.Bethesda.ModAligner;

namespace Mutagen.Bethesda.Tests
{
    public class Oblivion_Passthrough_Tests
    {
        private BinaryProcessorInstructions GetOblivionInstructions(
            Dictionary<long, uint> lengthTracker,
            MajorRecordLocator.FileLocations fileLocs)
        {
            var instructions = new BinaryProcessorInstructions();
            instructions.Instruction.Substitutions.Add(new DataTarget()
            {
                Location = 0xC46695,
                Data = new byte[] { 0x66, 0xDC, 0x05, 0x00 }
            });
            instructions.Instruction.Substitutions.Add(new DataTarget()
            {
                Location = 0xCA88D9,
                Data = new byte[] { 0xDB, 0xBC, 0x04, 0x00 }
            });
            instructions.Instruction.Substitutions.Add(new DataTarget()
            {
                Location = 0xCEAEB5,
                Data = new byte[] { 0x76, 0x0A, 0x00, 0x00 }
            });
            return instructions;
        }

        /*
         * Some records that seem older have an odd record order.  Rather than accommodating, dynamically mark as exceptions
         */
        private void AddDynamicProcessorInstructions(
            BinaryReadStream stream,
            FormID formID,
            Type recType,
            Instruction instr,
            RangeInt64 loc,
            MajorRecordLocator.FileLocations fileLocs,
            Dictionary<long, uint> lengthTracker,
            bool processing)
        {
            ProcessNPC_Mismatch(stream, recType, instr, loc, processing);
            ProcessCreature_Mismatch(stream, recType, instr, loc, processing);
            ProcessLeveledItemDataFields(stream, recType, instr, loc, processing);
            ProcessRegions(stream, recType, instr, loc, processing);
            ProcessPlacedObject_Mismatch(stream, formID, recType, instr, loc, fileLocs, lengthTracker, processing);
            ProcessCells(stream, formID, recType, instr, loc, fileLocs, lengthTracker, processing);
            ProcessDialogTopics(stream, formID, recType, instr, loc, fileLocs, lengthTracker, processing);
            ProcessDialogItems(stream, formID, recType, instr, loc, fileLocs, lengthTracker, processing);
        }

        private void ProcessNPC_Mismatch(
            BinaryReadStream stream,
            Type recType,
            Instruction instr,
            RangeInt64 loc,
            bool processing)
        {
            if (!processing) return;
            if (!typeof(NPC).Equals(recType)) return;
            stream.Position = loc.Min;
            var str = stream.ReadString((int)loc.Width);
            this.DynamicMove(
                str,
                instr,
                loc,
                offendingIndices: new RecordType[]
                {
                    new RecordType("CNTO"),
                    new RecordType("SCRI"),
                    new RecordType("AIDT")
                },
                offendingLimits: new RecordType[]
                {
                    new RecordType("ACBS")
                },
                locationsToMove: new RecordType[]
                {
                    new RecordType("CNAM")
                });
        }

        private void ProcessCreature_Mismatch(
            BinaryReadStream stream,
            Type recType,
            Instruction instr,
            RangeInt64 loc,
            bool processing)
        {
            if (!processing) return;
            if (!typeof(Creature).Equals(recType)) return;
            this.AlignRecords(
                stream,
                instr,
                loc,
                new RecordType[]
                {
                    new RecordType("EDID"),
                    new RecordType("FULL"),
                    new RecordType("MODL"),
                    new RecordType("CNTO"),
                    new RecordType("SPLO"),
                    new RecordType("NIFZ"),
                    new RecordType("ACBS"),
                    new RecordType("SNAM"),
                    new RecordType("INAM"),
                    new RecordType("SCRI"),
                    new RecordType("AIDT"),
                    new RecordType("PKID"),
                    new RecordType("KFFZ"),
                    new RecordType("DATA"),
                    new RecordType("RNAM"),
                    new RecordType("ZNAM"),
                    new RecordType("TNAM"),
                    new RecordType("BNAM"),
                    new RecordType("WNAM"),
                    new RecordType("NAM0"),
                    new RecordType("NAM1"),
                    new RecordType("CSCR"),
                    new RecordType("CSDT"),
                });
        }

        private void ProcessLeveledItemDataFields(
            BinaryReadStream stream,
            Type recType,
            Instruction instr,
            RangeInt64 loc,
            bool processing)
        {
            if (!processing) return;
            if (!typeof(LeveledItem).Equals(recType)) return;
            stream.Position = loc.Min;
            var str = stream.ReadString((int)loc.Width + Constants.RECORD_HEADER_LENGTH);
            var dataIndex = str.IndexOf("DATA");
            if (dataIndex == -1) return;

            var dataFlag = str[dataIndex + 6];
            if (dataFlag == 1)
            {
                var index = str.IndexOf("LVLD");
                index += 7;
                var addition = new DataTarget()
                {
                    Location = index + loc.Min,
                    Data = new byte[]
                    {
                            (byte)'L',
                            (byte)'V',
                            (byte)'L',
                            (byte)'F',
                            0x1,
                            0x0,
                            0x1
                    }
                };
                instr.Additions.Add(addition);
            }
            else
            {
                // Modify Length
                stream.Position = loc.Min + Constants.HEADER_LENGTH;
                var existingLen = stream.ReadUInt16();
                byte[] lenData = new byte[2];
                using (var writer = new MutagenWriter(new MemoryStream(lenData)))
                {
                    writer.Write((ushort)(existingLen - 7));
                }
                instr.Substitutions.Add(
                    new DataTarget()
                    {
                        Location = loc.Min + Constants.HEADER_LENGTH,
                        Data = lenData
                    });
            }

            // Remove DATA
            var move = new Move()
            {
                LocationToMove = long.MaxValue,
                SectionToMove = new RangeInt64(dataIndex + loc.Min, dataIndex + loc.Min + 7 - 1)
            };
            instr.Moves.Add(move);
        }

        private void ProcessRegions(
            BinaryReadStream stream,
            Type recType,
            Instruction instr,
            RangeInt64 loc,
            bool processing)
        {
            if (!processing) return;
            if (!typeof(Region).Equals(recType)) return;
            stream.Position = loc.Min;
            var lenToRead = (int)loc.Width + Constants.RECORD_HEADER_LENGTH;
            var str = stream.ReadString(lenToRead);
            var rdatIndex = str.IndexOf("RDAT");
            if (rdatIndex == -1) return;
            SortedList<uint, RangeInt64> rdats = new SortedList<uint, RangeInt64>();
            while (rdatIndex != -1)
            {
                var nextRdat = str.IndexOf("RDAT", rdatIndex + 1);
                stream.Position = rdatIndex + 6 + loc.Min;
                var index = stream.ReadUInt32();
                rdats[index] =
                    new RangeInt64(
                        rdatIndex + loc.Min,
                        nextRdat == -1 ? loc.Max : nextRdat - 1 + loc.Min);
                rdatIndex = nextRdat;
            }
            foreach (var item in rdats.Reverse())
            {
                if (item.Key == (int)RegionData.RegionDataType.Icon) continue;
                instr.Moves.Add(
                    new Move()
                    {
                        LocationToMove = loc.Max + 1,
                        SectionToMove = item.Value
                    });
            }

            if (rdats.ContainsKey((int)RegionData.RegionDataType.Icon))
            { // Need to create icon record
                var edidIndex = str.IndexOf("EDID");
                if (edidIndex == -1)
                {
                    throw new ArgumentException();
                }
                stream.Position = edidIndex + loc.Min + Constants.HEADER_LENGTH;
                var edidLen = stream.ReadUInt16();
                stream.Position += edidLen;
                var locToPlace = stream.Position;

                // Get icon string
                var iconLoc = rdats[(int)RegionData.RegionDataType.Icon];
                stream.Position = iconLoc.Min + Region.RDAT_LEN + 6;
                var iconStr = stream.ReadString((int)(iconLoc.Max - stream.Position));

                // Get icon bytes
                MemoryStream memStream = new MemoryStream();
                using (var writer = new MutagenWriter(memStream))
                {
                    using (HeaderExport.ExportHeader(
                        writer,
                        new RecordType("ICON"),
                        ObjectType.Subrecord))
                    {
                        writer.Write(iconStr);
                        writer.Write(default(byte));
                    }
                }

                instr.Additions.Add(
                    new DataTarget()
                    {
                        Location = locToPlace,
                        Data = memStream.ToArray()
                    });
                instr.Moves.Add(
                    new Move()
                    {
                        LocationToMove = long.MaxValue,
                        SectionToMove = iconLoc
                    });
            }
        }

        private static byte[] ZeroFloat = new byte[] { 0, 0, 0, 0x80 };
        private void ProcessPlacedObject_Mismatch(
            BinaryReadStream stream,
            FormID formID,
            Type recType,
            Instruction instr,
            RangeInt64 loc,
            MajorRecordLocator.FileLocations fileLocs,
            Dictionary<long, uint> lengthTracker,
            bool processing)
        {
            if (!typeof(PlacedObject).Equals(recType)) return;
            stream.Position = loc.Min;
            var str = stream.ReadString((int)loc.Width);
            if (processing)
            {
                var datIndex = str.IndexOf("XLOC");
                if (datIndex != -1)
                {
                    stream.Position = loc.Min + datIndex;
                    stream.Position += 4;
                    var len = stream.ReadUInt16();
                    if (len == 16)
                    {
                        lengthTracker[loc.Min] = lengthTracker[loc.Min] - 4;
                        var removeStart = loc.Min + datIndex + 6 + 12;
                        instr.Substitutions.Add(
                            new DataTarget()
                            {
                                Location = loc.Min + datIndex + 4,
                                Data = new byte[] { 12, 0 }
                            });
                        instr.Moves.Add(
                            new Move()
                            {
                                SectionToMove = new RangeInt64(
                                     removeStart,
                                     removeStart + 3),
                                LocationToMove = long.MaxValue,
                            });
                        foreach (var k in fileLocs.GetContainingGroupLocations(formID))
                        {
                            lengthTracker[k] = lengthTracker[k] - 4;
                        }
                    }
                }
                datIndex = str.IndexOf("XSED");
                if (datIndex != -1)
                {
                    stream.Position = loc.Min + datIndex;
                    stream.Position += 4;
                    var len = stream.ReadUInt16();
                    if (len == 4)
                    {
                        lengthTracker[loc.Min] = lengthTracker[loc.Min] - 3;
                        var removeStart = loc.Min + datIndex + 6 + 1;
                        instr.Substitutions.Add(
                            new DataTarget()
                            {
                                Location = loc.Min + datIndex + 4,
                                Data = new byte[] { 1, 0 }
                            });
                        instr.Moves.Add(
                            new Move()
                            {
                                SectionToMove = new RangeInt64(
                                     removeStart,
                                     removeStart + 2),
                                LocationToMove = long.MaxValue,
                            });
                        foreach (var k in fileLocs.GetContainingGroupLocations(formID))
                        {
                            lengthTracker[k] = lengthTracker[k] - 3;
                        }
                    }
                }
            }
            else
            {
                var datIndex = str.IndexOf("DATA");
                if (datIndex != -1)
                {
                    stream.Position = loc.Min + datIndex;
                    stream.Position += 6;
                    for (int i = 0; i < 6; i++)
                    {
                        var bytes = stream.ReadBytes(4);
                        if (bytes.SequenceEqual(ZeroFloat))
                        {
                            instr.IgnoreDifferenceSections.Add(new RangeInt64(stream.Position - 4, stream.Position - 1));
                        }
                    }
                }

                datIndex = str.IndexOf("XLOC");
                if (datIndex != -1)
                {
                    instr.IgnoreDifferenceSections.Add(
                        new RangeInt64(
                            loc.Min + datIndex + 7,
                            loc.Min + datIndex + 9));
                }

                datIndex = str.IndexOf("XTEL");
                if (datIndex != -1)
                {
                    stream.Position = loc.Min + datIndex + 10;
                    for (int i = 0; i < 6; i++)
                    {
                        var bytes = stream.ReadBytes(4);
                        if (bytes.SequenceEqual(ZeroFloat))
                        {
                            instr.IgnoreDifferenceSections.Add(new RangeInt64(stream.Position - 4, stream.Position - 1));
                        }
                    }
                }
            }
        }

        private void ProcessCells(
            BinaryReadStream stream,
            FormID formID,
            Type recType,
            Instruction instr,
            RangeInt64 loc,
            MajorRecordLocator.FileLocations fileLocs,
            Dictionary<long, uint> lengthTracker,
            bool processing)
        {
            if (!processing) return;
            if (!typeof(Cell).Equals(recType)) return;

            // Clean empty child groups
            List<RangeInt64> moves = new List<RangeInt64>();
            stream.Position = loc.Min + 4;
            var len = stream.ReadUInt32();
            stream.Position += len + 12;
            var grupPos = stream.Position;
            var grup = stream.ReadString(4);
            if (!grup.Equals("GRUP")) return;
            var grupLen = stream.ReadUInt32();
            if (grupLen == 0x14)
            {
                moves.Add(new RangeInt64(grupPos, grupPos + 0x14));
            }
            else
            {
                stream.Position += 4;
                var grupType = (GroupTypeEnum)stream.ReadUInt32();
                if (grupType != GroupTypeEnum.CellChildren) return;
                stream.Position += 4;
                for (int i = 0; i < 3; i++)
                {
                    var startPos = stream.Position;
                    var subGrup = stream.ReadString(4);
                    if (!subGrup.Equals("GRUP")) break;
                    var subGrupLen = stream.ReadUInt32();
                    stream.Position = startPos + subGrupLen;
                    if (subGrupLen == 0x14)
                    { // Empty group
                        lengthTracker[grupPos] = lengthTracker[grupPos] - 0x14;
                        moves.Add(new RangeInt64(stream.Position - 0x14, stream.Position - 1));
                    }
                }
            }

            if (moves.Count == 0) return;
            var parentGrups = fileLocs.GetContainingGroupLocations(formID);
            foreach (var move in moves)
            {
                instr.Moves.Add(
                    new Move()
                    {
                        LocationToMove = long.MaxValue,
                        SectionToMove = move
                    });
                foreach (var parentGroup in parentGrups)
                {
                    lengthTracker[parentGroup] = (uint)(lengthTracker[parentGroup] - move.Width);
                }
            }

            if (lengthTracker[grupPos] == 0x14)
            {
                var move = new RangeInt64(grupPos, grupPos + 0x13);
                instr.Moves.Add(
                    new Move()
                    {
                        LocationToMove = long.MaxValue,
                        SectionToMove = move
                    });
                foreach (var parentGroup in parentGrups)
                {
                    lengthTracker[parentGroup] = (uint)(lengthTracker[parentGroup] - move.Width);
                }
            }
        }

        private void ProcessDialogTopics(
            BinaryReadStream stream,
            FormID formID,
            Type recType,
            Instruction instr,
            RangeInt64 loc,
            MajorRecordLocator.FileLocations fileLocs,
            Dictionary<long, uint> lengthTracker,
            bool processing)
        {
            if (!typeof(DialogTopic).Equals(recType)) return;

            // Clean empty child groups
            stream.Position = loc.Min + 4;
            var len = stream.ReadUInt32();
            stream.Position += len + 12;
            var grupPos = stream.Position;
            var grup = stream.ReadString(4);
            if (grup.Equals("GRUP"))
            {
                var parentGrups = fileLocs.GetContainingGroupLocations(formID);
                var grupLen = stream.ReadUInt32();
                if (grupLen == 0x14)
                {
                    instr.Moves.Add(
                        new Move()
                        {
                            SectionToMove = new RangeInt64(grupPos, grupPos + 0x14 - 1),
                            LocationToMove = long.MaxValue
                        });

                    foreach (var parentGroup in parentGrups)
                    {
                        lengthTracker[parentGroup] = (uint)(lengthTracker[parentGroup] - 0x14);
                    }
                }
            }
        }

        private void ProcessDialogItems(
            BinaryReadStream stream,
            FormID formID,
            Type recType,
            Instruction instr,
            RangeInt64 loc,
            MajorRecordLocator.FileLocations fileLocs,
            Dictionary<long, uint> lengthTracker,
            bool processing)
        {
            if (!typeof(DialogItem).Equals(recType)) return;

            stream.Position = loc.Min;
            var str = stream.ReadString((int)loc.Width + Constants.RECORD_HEADER_LENGTH);
            var dataIndex = -1;
            var parentGrups = fileLocs.GetContainingGroupLocations(formID);
            int amount = 0;
            while ((dataIndex = str.IndexOf("CTDT", dataIndex + 1)) != -1)
            {
                instr.Substitutions.Add(
                    new DataTarget()
                    {
                        Location = dataIndex + loc.Min + 3,
                        Data = new byte[] { (byte)'A', 0x18 }
                    });
                instr.Additions.Add(
                    new DataTarget()
                    {
                        Data = new byte[4],
                        Location = dataIndex + loc.Min + 0x1A
                    });
                foreach (var parentGroup in parentGrups)
                {
                    lengthTracker[parentGroup] = (uint)(lengthTracker[parentGroup] + 4);
                }
                amount += 4;
            }

            dataIndex = -1;
            while ((dataIndex = str.IndexOf("SCHD", dataIndex + 1)) != -1)
            {
                stream.Position = loc.Min + dataIndex + 4;
                var existingLen = stream.ReadUInt16();
                var diff = existingLen - 0x14;
                instr.Substitutions.Add(
                    new DataTarget()
                    {
                        Location = dataIndex + loc.Min + 3,
                        Data = new byte[] { (byte)'R', 0x14 }
                    });
                if (diff == 0) continue;
                var locToRemove = loc.Min + dataIndex + 6 + 0x14;
                instr.Moves.Add(
                    new Move()
                    {
                        SectionToMove = new RangeInt64(
                             locToRemove,
                             locToRemove + diff - 1),
                        LocationToMove = long.MaxValue
                    });
                foreach (var parentGroup in parentGrups)
                {
                    lengthTracker[parentGroup] = (uint)(lengthTracker[parentGroup] - diff);
                }
                amount -= diff;
            }

            if (amount != 0)
            {
                // Modify Length
                stream.Position = loc.Min + Constants.HEADER_LENGTH;
                var existingLen = stream.ReadUInt16();
                byte[] lenData = new byte[2];
                using (var writer = new MutagenWriter(new MemoryStream(lenData)))
                {
                    writer.Write((ushort)(existingLen + amount));
                }
                instr.Substitutions.Add(
                    new DataTarget()
                    {
                        Location = loc.Min + Constants.HEADER_LENGTH,
                        Data = lenData
                    });
            }
        }
        
        private bool DynamicMove(
            string str,
            Instruction instr,
            RangeInt64 loc,
            IEnumerable<RecordType> offendingIndices,
            IEnumerable<RecordType> offendingLimits,
            IEnumerable<RecordType> locationsToMove,
            bool enforcePast = false)
        {
            if (!LocateFirstOf(
                str,
                loc.Min,
                offendingIndices,
                out var offender)) return false;
            if (!LocateFirstOf(
                str,
                loc.Min,
                offendingLimits,
                out var limit)) return false;
            if (!LocateFirstOf(
                str,
                loc.Min,
                locationsToMove,
                out var locToMove,
                past: enforcePast ? offender : default(long?)))
            {
                locToMove = loc.Min + str.Length;
            }
            if (limit == locToMove) return false;
            if (offender < limit)
            {
                if (locToMove < offender)
                {
                    throw new ArgumentException();
                }
                instr.Moves.Add(
                    new Move()
                    {
                        SectionToMove = new RangeInt64(offender, limit - 1),
                        LocationToMove = locToMove
                    });
                return true;
            }
            return false;
        }

        private void AlignRecords(
            BinaryReadStream stream,
            Instruction instr,
            RangeInt64 loc,
            IEnumerable<RecordType> rectypes)
        {
            stream.Position = loc.Min;
            var bytes = stream.ReadBytes((int)loc.Width);
            var str = BinaryUtility.BytesToString(bytes);
            List<(RecordType rec, int sourceIndex, int loc)> list = new List<(RecordType rec, int sourceIndex, int loc)>();
            int recTypeIndex = -1;
            foreach (var rec in rectypes)
            {
                recTypeIndex++;
                var index = str.IndexOf(rec.Type, Constants.RECORD_HEADER_LENGTH);
                if (index == -1) continue;
                list.Add((rec, recTypeIndex, index));
            }
            if (list.Count == 0) return;
            List<int> locs = new List<int>(list.OrderBy((l) => l.loc).Select((l) => l.loc));
            var orderedList = list.OrderBy((l) => l.loc).ToList();
            if (list.Select(i => i.rec).SequenceEqual(orderedList.Select(i => i.rec))) return;
            int start = orderedList[0].loc;
            foreach (var item in list)
            {
                var locIndex = locs.IndexOf(item.loc);
                int len;
                if (locIndex == locs.Count - 1)
                {
                    len = str.Length - item.loc;
                }
                else
                {
                    len = locs[locIndex + 1] - item.loc;
                }
                if (item.loc == start)
                {
                    start += len;
                    continue;
                }
                var data = new byte[len];
                for (int index = 0; index < len; index++)
                {
                    data[index] = bytes[item.loc + index];
                }
                instr.Substitutions.Add(
                    new DataTarget()
                    {
                        Location = start + loc.Min,
                        Data = data
                    });
                start += len;
            }
        }

        private bool LocateFirstOf(
            string str,
            long offset,
            IEnumerable<RecordType> types,
            out long loc,
            long? past = null)
        {
            List<int> indices = new List<int>(types
                .Select((r) => str.IndexOf(r.Type))
                .Where((i) => i != -1)
                .Where((i) => !past.HasValue || i > past));
            if (indices.Count == 0)
            {
                loc = default(long);
                return false;
            }
            loc = MathExt.Min(indices) + offset;
            return true;
        }

        public Task OblivionESM_Binary()
        {
            return OblivionESM_Binary_Internal(deleteAfter: true);
        }

        public async Task OblivionESM_Binary_Internal(bool deleteAfter)
        {
            await OblivionESM_Typical(deleteAfter: deleteAfter);
        }

        public ModAligner.AlignmentRules GetAlignmentRules()
        {
            var ret = new ModAligner.AlignmentRules();
            ret.AddAlignments(
                Cell_Registration.CELL_HEADER,
                new RecordType("EDID"),
                new RecordType("FULL"),
                new RecordType("DATA"),
                new RecordType("XCLC"),
                new RecordType("XCLL"),
                new RecordType("XCLR"),
                new RecordType("XCMT"),
                new RecordType("XCLW"),
                new RecordType("XCCM"),
                new RecordType("XCWT"),
                new RecordType("XOWN"),
                new RecordType("XRNK"),
                new RecordType("XGLB"));
            ret.AddAlignments(
                Worldspace_Registration.WRLD_HEADER,
                new RecordType("EDID"),
                new RecordType("FULL"),
                new RecordType("WNAM"),
                new RecordType("CNAM"),
                new RecordType("NAM2"),
                new RecordType("ICON"),
                new RecordType("MNAM"),
                new RecordType("DATA"),
                new RecordType("NAM0"),
                new RecordType("NAM9"),
                new RecordType("SNAM"),
                new RecordType("XXXX"));
            ret.StopMarkers[Worldspace_Registration.WRLD_HEADER] = new List<RecordType>()
            {
                new RecordType("OFST"),
            };
            ret.AddAlignments(
                PlacedObject_Registration.REFR_HEADER,
                new ModAligner.AlignmentStraightRecord("EDID"),
                new ModAligner.AlignmentStraightRecord("NAME"),
                new ModAligner.AlignmentStraightRecord("XPCI"),
                new ModAligner.AlignmentStraightRecord("FULL"),
                new ModAligner.AlignmentStraightRecord("XTEL"),
                new ModAligner.AlignmentStraightRecord("XLOC"),
                new ModAligner.AlignmentStraightRecord("XOWN"),
                new ModAligner.AlignmentStraightRecord("XRNK"),
                new ModAligner.AlignmentStraightRecord("XGLB"),
                new ModAligner.AlignmentStraightRecord("XESP"),
                new ModAligner.AlignmentStraightRecord("XTRG"),
                new ModAligner.AlignmentStraightRecord("XSED"),
                new ModAligner.AlignmentStraightRecord("XLOD"),
                new ModAligner.AlignmentStraightRecord("XCHG"),
                new ModAligner.AlignmentStraightRecord("XHLT"),
                new ModAligner.AlignmentStraightRecord("XLCM"),
                new ModAligner.AlignmentStraightRecord("XRTM"),
                new ModAligner.AlignmentStraightRecord("XACT"),
                new ModAligner.AlignmentStraightRecord("XCNT"),
                new ModAligner.AlignmentSubRule(
                    new RecordType("XMRK"),
                    new RecordType("FNAM"),
                    new RecordType("FULL"),
                    new RecordType("TNAM")),
                new ModAligner.AlignmentStraightRecord("ONAM"),
                new ModAligner.AlignmentStraightRecord("XRGD"),
                new ModAligner.AlignmentStraightRecord("XSCL"),
                new ModAligner.AlignmentStraightRecord("XSOL"),
                new ModAligner.AlignmentStraightRecord("DATA"));
            ret.AddAlignments(
                PlacedCreature_Registration.ACRE_HEADER,
                new RecordType("EDID"),
                new RecordType("NAME"),
                new RecordType("XOWN"),
                new RecordType("XRNK"),
                new RecordType("XGLB"),
                new RecordType("XESP"),
                new RecordType("XRGD"),
                new RecordType("XSCL"),
                new RecordType("DATA"));
            ret.AddAlignments(
                PlacedNPC_Registration.ACHR_HEADER,
                new RecordType("EDID"),
                new RecordType("NAME"),
                new RecordType("XPCI"),
                new RecordType("FULL"),
                new RecordType("XLOD"),
                new RecordType("XESP"),
                new RecordType("XMRC"),
                new RecordType("XHRS"),
                new RecordType("XRGD"),
                new RecordType("XSCL"),
                new RecordType("DATA"));
            ret.SetGroupAlignment(
                GroupTypeEnum.CellTemporaryChildren,
                new RecordType("LAND"),
                new RecordType("PGRD"));
            return ret;
        }

        public Dictionary<Type, List<FormID>> ImportExport(
            string inputPath,
            string outputPath)
        {
            var mod = OblivionMod.Create_Binary(
                inputPath,
                out var inputErrMask);
            Assert.False(inputErrMask?.IsInError() ?? false);

            foreach (var record in mod.MajorRecords.Values)
            {
                if (record.MajorRecordFlags.HasFlag(MajorRecord.MajorRecordFlag.Compressed))
                {
                    record.MajorRecordFlags &= ~MajorRecord.MajorRecordFlag.Compressed;
                }
            }

            mod.Write_Binary(outputPath, out var outputErrMask);
            Assert.False(outputErrMask?.IsInError() ?? false);

            Dictionary<Type, List<FormID>> ret = new Dictionary<Type, List<FormID>>();
            foreach (var rec in mod.MajorRecords.Values)
            {
                ret.TryCreateValue(rec.GetType()).Add(rec.FormID);
            }
            return ret;
        }

        private async Task OblivionESM_Typical(bool deleteAfter)
        {
            using (var tmp = new TempFolder(new DirectoryInfo(Path.Combine(Path.GetTempPath(), "Mutagen_Oblivion_Binary")), deleteAfter: deleteAfter))
            {
                var oblivionOutputPath = Path.Combine(tmp.Dir.Path, Constants.OBLIVION_ESM);
                var uncompressedPath = Path.Combine(tmp.Dir.Path, $"{Constants.OBLIVION_ESM}_Uncompressed");
                var alignedPath = Path.Combine(tmp.Dir.Path, $"{Constants.OBLIVION_ESM}_Aligned");
                var processedPath = Path.Combine(tmp.Dir.Path, $"{Constants.OBLIVION_ESM}_Processed");

                ModDecompressor.Decompress(
                    inputPath: Properties.Settings.Default.OblivionESM,
                    outputPath: uncompressedPath);

                var importRecs = ImportExport(uncompressedPath, oblivionOutputPath);

                ModAligner.Align(
                    inputPath: uncompressedPath,
                    outputPath: alignedPath,
                    alignmentRules: GetAlignmentRules(),
                    temp: tmp);

                var alignedFileLocs = MajorRecordLocator.GetFileLocations(
                    alignedPath);

                Dictionary<long, uint> lengthTracker = new Dictionary<long, uint>();

                using (var reader = new BinaryReadStream(alignedPath))
                {
                    foreach (var grup in alignedFileLocs.GrupLocations.And(alignedFileLocs.ListedRecords.Keys))
                    {
                        reader.Position = grup + 4;
                        lengthTracker[grup] = reader.ReadUInt32();
                    }
                }

                var instructions = GetOblivionInstructions(
                    lengthTracker,
                    alignedFileLocs);

                using (var stream = new BinaryReadStream(alignedPath))
                {
                    foreach (var recType in importRecs)
                    {
                        foreach (var id in recType.Value)
                        {
                            AddDynamicProcessorInstructions(
                                stream: stream,
                                formID: id,
                                recType: recType.Key,
                                instr: instructions.Instruction,
                                loc: alignedFileLocs[id],
                                fileLocs: alignedFileLocs,
                                lengthTracker: lengthTracker,
                                processing: true);
                        }
                    }
                }

                using (var reader = new BinaryReadStream(alignedPath))
                {
                    foreach (var grup in lengthTracker)
                    {
                        reader.Position = grup.Key + 4;
                        if (grup.Value == reader.ReadUInt32()) continue;
                        instructions.Instruction.Substitutions.Add(
                            new DataTarget()
                            {
                                Location = grup.Key + 4,
                                Data = BitConverter.GetBytes(grup.Value)
                            });
                    }
                }

                var binConfig = instructions.Instruction.ToProcessorConfig();
                using (var processor = new BinaryFileProcessor(
                    new FileStream(alignedPath, FileMode.Open, FileAccess.Read),
                    binConfig))
                {
                    using (var outStream = new FileStream(processedPath, FileMode.Create, FileAccess.Write))
                    {
                        processor.CopyTo(outStream);
                    }
                }

                var processedFileLocs = MajorRecordLocator.GetFileLocations(
                    processedPath);
                using (var stream = new BinaryReadStream(processedPath))
                {
                    foreach (var recType in importRecs)
                    {
                        foreach (var id in recType.Value)
                        {
                            AddDynamicProcessorInstructions(
                                stream: stream,
                                formID: id,
                                recType: recType.Key,
                                instr: instructions.Instruction,
                                loc: processedFileLocs[id],
                                fileLocs: processedFileLocs,
                                lengthTracker: null,
                                processing: false);
                        }
                    }
                }

                using (var stream = new BinaryReadStream(processedPath))
                {
                    var ret = Passthrough_Tests.AssertFilesEqual(
                        stream,
                        oblivionOutputPath,
                        ignoreList: new RangeCollection(instructions.Instruction.IgnoreDifferenceSections),
                        sourceSkips: new RangeCollection(instructions.Instruction.SkipSourceSections),
                        targetSkips: new RangeCollection(instructions.Instruction.SkipOutputSections),
                        amountToReport: 15);
                    if (ret.Exception != null)
                    {
                        throw ret.Exception;
                    }
                }
            }
        }

        public async Task OblivionESM_GroupMask_Import()
        {
            var mod = OblivionMod.Create_Binary(
                Properties.Settings.Default.OblivionESM,
                out var inputErrMask,
                importMask: new GroupMask()
                {
                    NPCs = true
                });
            Assert.False(inputErrMask?.IsInError() ?? false);

            using (var tmp = new TempFolder("Mutagen_Oblivion_Binary_GroupMask_Import"))
            {
                var oblivionOutputPath = Path.Combine(tmp.Dir.Path, Constants.OBLIVION_ESM);
                mod.Write_Binary(
                    oblivionOutputPath,
                    out var outputErrMask);
                Assert.False(outputErrMask?.IsInError() ?? false);
                var fileLocs = MajorRecordLocator.GetFileLocations(oblivionOutputPath);
                using (var reader = new BinaryReadStream(oblivionOutputPath))
                {
                    foreach (var rec in fileLocs.ListedRecords.Keys)
                    {
                        reader.Position = rec;
                        var t = HeaderTranslation.ReadNextRecordType(reader);
                        if (!t.Equals(NPC_Registration.NPC__HEADER))
                        {
                            throw new ArgumentException("Exported a non-NPC record.");
                        }
                    }
                }
            }
        }

        public async Task OblivionESM_GroupMask_Export()
        {
            var mod = OblivionMod.Create_Binary(
                Properties.Settings.Default.OblivionESM,
                out var inputErrMask);
            Assert.False(inputErrMask?.IsInError() ?? false);

            using (var tmp = new TempFolder("Mutagen_Oblivion_Binary_GroupMask_Export"))
            {
                var oblivionOutputPath = Path.Combine(tmp.Dir.Path, Constants.OBLIVION_ESM);
                mod.Write_Binary(
                    oblivionOutputPath,
                    out var outputErrMask,
                    importMask: new GroupMask()
                    {
                        NPCs = true
                    });
                Assert.False(outputErrMask?.IsInError() ?? false);
                var fileLocs = MajorRecordLocator.GetFileLocations(oblivionOutputPath);
                using (var reader = new BinaryReadStream(oblivionOutputPath))
                {
                    foreach (var rec in fileLocs.ListedRecords.Keys)
                    {
                        reader.Position = rec;
                        var t = HeaderTranslation.ReadNextRecordType(reader);
                        if (!t.Equals(NPC_Registration.NPC__HEADER))
                        {
                            throw new ArgumentException("Exported a non-NPC record.");
                        }
                    }
                }
            }
        }

        private void CopyOverOffendingRecords(
            OblivionMod mod,
            IEnumerable<(RangeInt64 Source, RangeInt64? Output)> sections,
            string tmpFolder,
            string origPath,
            string processedPath,
            string outputPath,
            MajorRecordLocator.FileLocations originalFileLocs)
        {
            if (!sections.Any()) return;

            var outputFileLocs = MajorRecordLocator.GetFileLocations(outputPath);

            HashSet<FormID> ids = new HashSet<FormID>();
            foreach (var (Source, Output) in sections)
            {
                if (!originalFileLocs.TryGetRecords(Source, out var foundIDs)) continue;
                foreach (var id in foundIDs)
                {
                    if (!ids.Add(id)) continue;
                    var majorRec = mod[id];
                    var origRecOutputPath = Path.Combine(tmpFolder, majorRec.TitleString);
                    if (!originalFileLocs.TryGetSection(id, out var sourceLoc))
                    {
                        throw new NotImplementedException();
                    }
                    var output = Path.Combine(tmpFolder, $"{majorRec.TitleString} - Original");
                    using (var inStream = new BinaryReadStream(File.OpenRead(origPath)))
                    {
                        inStream.Position = sourceLoc.Min;
                        using (var outStream = new MutagenWriter(origRecOutputPath))
                        {
                            outStream.Write(inStream.ReadBytes((int)sourceLoc.Width));
                        }
                    }
                    output = Path.Combine(tmpFolder, $"{majorRec.TitleString} - Processed");
                    using (var inStream = new BinaryReadStream(File.OpenRead(processedPath)))
                    {
                        inStream.Position = sourceLoc.Min;
                        using (var outStream = new MutagenWriter(output))
                        {
                            outStream.Write(inStream.ReadBytes((int)sourceLoc.Width));
                        }
                    }
                    if (!Output.HasValue) continue;

                    if (!outputFileLocs.TryGetSection(id, out var outputLoc))
                    {
                        throw new NotImplementedException();
                    }
                    output = Path.Combine(tmpFolder, $"{majorRec.TitleString} - Output");
                    using (var inStream = new BinaryReadStream(File.OpenRead(outputPath)))
                    {
                        inStream.Position = outputLoc.Min;
                        using (var outStream = new MutagenWriter(output))
                        {
                            outStream.Write(inStream.ReadBytes((int)outputLoc.Width));
                        }
                    }
                }
            }
        }

        public async Task OblivionESM_Folder_Reimport()
        {
            var mod = OblivionMod.Create_Binary(
                Properties.Settings.Default.OblivionESM,
                out var inputErrMask);
            Assert.False(inputErrMask?.IsInError() ?? false);
            using (var tmp = new TempFolder("Mutagen_Oblivion_XmlFolder", deleteAfter: false))
            {
                mod[FormID.Factory("0006371E")].Write_XML(Path.Combine(tmp.Dir.Path, "Test"));
                var exportMask = await mod.Write_XmlFolder(
                    tmp.Dir);
                Assert.False(exportMask?.IsInError() ?? false);
            }
        }

        public void OblivionESM_Equals()
        {
            throw new NotImplementedException();
        }

        public void KnightsESP_Binary()
        {
            //OblivionMod_ErrorMask inputErrMask, outputErrMask;
            //var mod = OblivionMod.Create_Binary(
            //    Properties.Settings.Default.KnightsESP,
            //    out inputErrMask);
            //using (var tmp = new TempFolder(new DirectoryInfo(Path.Combine(Path.GetTempPath(), "Mutagen_Knights_Binary"))))
            //{
            //    var outputPath = Path.Combine(tmp.Dir.FullName, Constants.KNIGHTS_ESP);
            //    mod.Write_Binary(
            //        outputPath,
            //        out outputErrMask);
            //    AssertFilesEqual(Properties.Settings.Default.KnightsESP, outputPath);
            //    Assert.Null(inputErrMask);
            //    Assert.Null(outputErrMask);
            //}
        }

        public void OblivionESM_XML()
        {
            var modFromBinary = OblivionMod.Create_Binary(
                Properties.Settings.Default.OblivionESM,
                out var binInputErrMask);
            Assert.Null(binInputErrMask);
            using (var tmp = new TempFolder("Mutagen_Oblivion_XML"))
            {
                var outputPath = Path.Combine(tmp.Dir.Path, Path.GetRandomFileName());
                modFromBinary.Write_XML(
                    outputPath,
                    out var outputErrMask);
                var modFromXML = OblivionMod.Create_XML(
                    outputPath,
                    out var xmlInputErrMask);
                Assert.Equal(modFromBinary, modFromXML);
                Assert.Null(xmlInputErrMask);
                Assert.Null(outputErrMask);
            }
        }

        public void KnightsESP_XML()
        {
            var modFromBinary = OblivionMod.Create_Binary(
                Properties.Settings.Default.KnightsESP,
                out var binInputErrMask);
            Assert.Null(binInputErrMask);
            using (var tmp = new TempFolder("Mutagen_Knights_XML"))
            {
                var outputPath = Path.Combine(tmp.Dir.Path, Path.GetRandomFileName());
                modFromBinary.Write_XML(
                    outputPath,
                    out var outputErrMask);
                var modFromXML = OblivionMod.Create_XML(
                    outputPath,
                    out var xmlInputErrMask);
                Assert.Equal(modFromBinary, modFromXML);
                Assert.Null(xmlInputErrMask);
                Assert.Null(outputErrMask);
            }
        }
    }
}