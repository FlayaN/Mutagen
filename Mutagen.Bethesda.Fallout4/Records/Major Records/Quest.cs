using Mutagen.Bethesda.Fallout4.Internals;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Binary.Overlay;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Binary.Translations;
using Mutagen.Bethesda.Plugins.Exceptions;
using Mutagen.Bethesda.Plugins.Meta;
using Mutagen.Bethesda.Plugins.Records;
using Noggog;
using System.Buffers.Binary;
using System.Diagnostics.CodeAnalysis;

namespace Mutagen.Bethesda.Fallout4;

partial class Quest
{
    [Flags]
    public enum MajorFlag
    {
        PartialForm = 0x4000
    }

    [Flags]
    public enum Flag
    {
        StartGameEnabled = 0x0001,
        Completed = 0x0002,
        AddIdleTopicToHello = 0x0004,
        AllowRepeatedStages = 0x0008,
        StartsEnabled = 0x0010,
        DisplaysInHud = 0x0020,
        Failed = 0x0040,
        StageWait = 0x0080,
        RunOnce = 0x0100,
        ExcludeFromDialogExport = 0x0200,
        WarnOnAliasFillFailure = 0x0400,
        Active = 0x0800,
        RepeatsConditions = 0x1000,
        KeepInstance = 0x2000,
        WantDormant = 0x4000,
        HasDialogueData = 0x8000,
    }

    public enum TypeEnum
    {
        None = 0,
        MainQuest = 1,
        BrotherhoodOfSteel = 2,
        Institute = 3,
        Minutemen = 4,
        Railroad = 5,
        Misc = 6,
        SideQuests = 7,
        DLC01 = 8,
        DLC02 = 9,
        DLC03 = 10,
        DLC04 = 11,
        DLC05 = 12,
        DLC06 = 13,
        DLC07 = 14,
    }

    [Flags]
    public enum TargetFlag
    {
        CompassMarkerIgnoresLocks = 0x1,
        Hostile = 0x2,
        UseStraightLinePathing = 0x4
    }
}

partial class QuestBinaryCreateTranslation
{
    public static partial void FillBinaryDialogConditionsCustom(MutagenFrame frame, IQuestInternal item)
    {
        ConditionBinaryCreateTranslation.FillConditionsList(item.DialogConditions, frame);
    }

    public static partial ParseResult FillBinaryUnusedConditionsLogicCustom(MutagenFrame frame, IQuestInternal item)
    {
        var nextHeader = frame.ReadSubrecord();
        if (nextHeader.RecordType != RecordTypes.NEXT
            || nextHeader.Content.Length != 0)
        {
            throw new ArgumentException("Unexpected NEXT header");
        }
        ConditionBinaryCreateTranslation.FillConditionsList(item.UnusedConditions, frame);
        return null;
    }

    public static partial ParseResult FillBinaryAliasParseCustom(MutagenFrame frame, IQuestInternal item)
    {
        frame = frame.SpawnAll();
        frame.TryReadSubrecord(RecordTypes.ANAM, out _);
        item.Aliases.Clear();
        while (frame.TryReadSubrecord(out var subRec))
        {
            switch (subRec.RecordTypeInt)
            {
                case RecordTypeInts.ALST:
                    {
                        var id = subRec.AsUInt32();
                        var ret = QuestReferenceAlias.CreateFromBinary(frame);
                        ret.ID = id;
                        item.Aliases.Add(ret);
                        break;
                    }
                case RecordTypeInts.ALLS:
                    {
                        var id = subRec.AsUInt32();
                        var ret = QuestLocationAlias.CreateFromBinary(frame);
                        ret.ID = id;
                        item.Aliases.Add(ret);
                        break;
                    }
                case RecordTypeInts.ALCS:
                case RecordTypeInts.ALMI:
                    {
                        frame.Position -= subRec.TotalLength;
                        var ret = new QuestCollectionAlias();
                        ret.Collection.SetTo(
                            ListBinaryTranslation<CollectionAlias>.Instance.Parse(
                                frame,
                                CollectionAlias.TryCreateFromBinary));
                        item.Aliases.Add(ret);
                        break;
                    }
                default:
                    frame.Position -= subRec.TotalLength;
                    return (int)Quest_FieldIndex.Aliases;
            }
        }
        return (int)Quest_FieldIndex.Aliases;
    }

    public static partial void CustomBinaryEndImport(MutagenFrame frame, IQuestInternal obj)
    {
        try
        {
            if (frame.Reader.Complete) return;
            if (!frame.TryGetGroupHeader(out var groupMeta)) return;
            if (groupMeta.GroupType == (int)GroupTypeEnum.QuestChildren)
            {
                obj.Timestamp = BinaryPrimitives.ReadInt32LittleEndian(groupMeta.LastModifiedData);
                obj.Unknown = frame.GetInt32(offset: 20);
                if (FormKey.Factory(frame.MetaData.MasterReferences!, BinaryPrimitives.ReadUInt32LittleEndian(groupMeta.ContainedRecordTypeData)) != obj.FormKey)
                {
                    throw new ArgumentException("Quest children group did not match the FormID of the parent.");
                }
            }
            else
            {
                return;
            }
            frame.Reader.Position += groupMeta.HeaderLength;
            frame = frame.SpawnWithLength(groupMeta.ContentLength);
            var records = ListBinaryTranslation<IMajorRecord>.Instance.Parse(
                reader: frame,
                transl: (MutagenFrame r, RecordType header, [MaybeNullWhen(false)] out IMajorRecord rec) =>
                {
                    switch (header.TypeInt)
                    {
                        case RecordTypeInts.DIAL:
                            rec = DialogTopic.CreateFromBinary(r);
                            return true;
                        case RecordTypeInts.SCEN:
                            rec = Scene.CreateFromBinary(r);
                            return true;
                        case RecordTypeInts.DLBR:
                            rec = DialogBranch.CreateFromBinary(r);
                            return true;
                        default:
                            throw new NotImplementedException();
                    }
                });
            obj.Scenes.SetTo(records.WhereCastable<IMajorRecord, Scene>());
            obj.DialogTopics.SetTo(records.WhereCastable<IMajorRecord, DialogTopic>());
            obj.DialogBranches.SetTo(records.WhereCastable<IMajorRecord, DialogBranch>());
        }
        catch (Exception ex)
        {
            throw RecordException.Enrich(ex, obj);
        }
    }
}

partial class QuestBinaryWriteTranslation
{
    public static partial void WriteBinaryDialogConditionsCustom(MutagenWriter writer, IQuestGetter item)
    {
        ConditionBinaryWriteTranslation.WriteConditionsList(item.DialogConditions, writer);
    }

    public static partial void WriteBinaryUnusedConditionsLogicCustom(MutagenWriter writer, IQuestGetter item)
    {
        using (HeaderExport.Subrecord(writer, RecordTypes.NEXT)) { }
        ConditionBinaryWriteTranslation.WriteConditionsList(item.UnusedConditions, writer);
    }

    public static partial void WriteBinaryAliasParseCustom(MutagenWriter writer, IQuestGetter item)
    {
        var aliases = item.Aliases;
        using (HeaderExport.Subrecord(writer, RecordTypes.ANAM))
        {
            if (aliases.Count == 0)
            {
                writer.Write(0);
            }
            else
            {
                var max = aliases.Select(x =>
                {
                    switch (x)
                    {
                        case IQuestReferenceAliasGetter refAlias:
                            return refAlias.ID;
                        case IQuestLocationAliasGetter locAlias:
                            return locAlias.ID;
                        case IQuestCollectionAliasGetter collAlias:
                            return default(UInt32);
                        default:
                            throw new NotImplementedException();
                    }
                }).Max();
                writer.Write(max + 1);
            }
        }
        foreach (var alias in aliases)
        {
            switch (alias)
            {
                case IQuestReferenceAliasGetter refAlias:
                    using (HeaderExport.Subrecord(writer, RecordTypes.ALST))
                    {
                        writer.Write(refAlias.ID);
                    }
                    refAlias.WriteToBinary(writer);
                    break;
                case IQuestLocationAliasGetter locAlias:
                    using (HeaderExport.Subrecord(writer, RecordTypes.ALLS))
                    {
                        writer.Write(locAlias.ID);
                    }
                    locAlias.WriteToBinary(writer);
                    break;
                case IQuestCollectionAliasGetter collAlias:
                    collAlias.WriteToBinary(writer);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }

    public static partial void CustomBinaryEndExport(MutagenWriter writer, IQuestGetter obj)
    {
        try
        {
            var scenes = obj.Scenes;
            var dialogTopics = obj.DialogTopics;
            var dialogBranches = obj.DialogBranches;
            if (scenes.Count == 0
                && dialogTopics.Count == 0
                && dialogBranches.Count == 0)
            {
                return;
            }
            using (HeaderExport.Header(writer, RecordTypes.GRUP, ObjectType.Group))
            {
                FormKeyBinaryTranslation.Instance.Write(
                    writer,
                    obj.FormKey);
                writer.Write((int)GroupTypeEnum.QuestChildren);
                writer.Write(obj.Timestamp);
                writer.Write(obj.Unknown);
                ListBinaryTranslation<ISceneGetter>.Instance.Write(
                    writer: writer,
                    items: scenes,
                    transl: (MutagenWriter subWriter, ISceneGetter subItem) =>
                    {
                        subItem.WriteToBinary(subWriter);
                    });
                ListBinaryTranslation<IDialogTopicGetter>.Instance.Write(
                    writer: writer,
                    items: dialogTopics,
                    transl: (MutagenWriter subWriter, IDialogTopicGetter subItem) =>
                    {
                        subItem.WriteToBinary(subWriter);
                    });
                ListBinaryTranslation<IDialogBranchGetter>.Instance.Write(
                    writer: writer,
                    items: dialogBranches,
                    transl: (MutagenWriter subWriter, IDialogBranchGetter subItem) =>
                    {
                        subItem.WriteToBinary(subWriter);
                    });
            }
        }
        catch (Exception ex)
        {
            throw RecordException.Enrich(ex, obj);
        }
    }
}

partial class QuestBinaryOverlay
{
    public IReadOnlyList<IConditionGetter> DialogConditions { get; private set; } = Array.Empty<IConditionGetter>();
    public IReadOnlyList<IConditionGetter> UnusedConditions { get; private set; } = Array.Empty<IConditionGetter>();
    public IReadOnlyList<IAQuestAliasGetter> Aliases => throw new NotImplementedException();
    public int Timestamp => throw new NotImplementedException();

    public int Unknown => throw new NotImplementedException();

    public IReadOnlyList<ISceneGetter> Scenes => throw new NotImplementedException();

    public IReadOnlyList<IDialogTopicGetter> DialogTopics => throw new NotImplementedException();

    public IReadOnlyList<IDialogBranchGetter> DialogBranches => throw new NotImplementedException();

    partial void DialogConditionsCustomParse(OverlayStream stream, long finalPos, int offset, RecordType type, PreviousParse lastParsed)
    {
        DialogConditions = ConditionBinaryOverlay.ConstructBinayOverlayList(stream, _package);
    }

    public partial ParseResult UnusedConditionsLogicCustomParse(OverlayStream stream, int offset)
    {
        var nextHeader = stream.ReadSubrecord();
        if (nextHeader.RecordType != RecordTypes.NEXT
            || nextHeader.Content.Length != 0)
        {
            throw new ArgumentException("Unexpected NEXT header");
        }
        UnusedConditions = ConditionBinaryOverlay.ConstructBinayOverlayList(stream, _package);

        return null;
    }

    public partial ParseResult AliasParseCustomParse(OverlayStream stream, int offset)
    {
        throw new NotImplementedException();
    }
}