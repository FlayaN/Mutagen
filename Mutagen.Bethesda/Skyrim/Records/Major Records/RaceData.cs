﻿using Mutagen.Bethesda.Binary;
using Noggog;
using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Text;

namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class RaceDataBinaryCreateTranslation
    {
        static partial void FillBinaryFlags2Custom(MutagenFrame frame, IRaceData item)
        {
            // Clear out upper flags
            item.Flags &= ((Race.Flag)0x00000000FFFFFFFF);

            // Set upper flags
            ulong flags2 = frame.ReadUInt32();
            flags2 <<= 32;
            item.Flags |= ((Race.Flag)flags2);
        }

        static partial void FillBinaryMountDataCustom(MutagenFrame frame, IRaceData item)
        {
            if (!frame.Complete)
            {
                throw new NotImplementedException();
            }
        }
    }

    public partial class RaceDataBinaryWriteTranslation
    {
        static partial void WriteBinaryFlags2Custom(MutagenWriter writer, IRaceDataGetter item)
        {
            ulong flags = (ulong)item.Flags;
            flags >>= 32;
            writer.Write((uint)flags);
        }

        static partial void WriteBinaryMountDataCustom(MutagenWriter writer, IRaceDataGetter item)
        {
            //ToDo
            //Implement Mount Data export
        }
    }

    public partial class RaceDataBinaryOverlay
    {
        public Race.Flag GetFlagsCustom(int location)
        {
            var flag = (Race.Flag)BinaryPrimitives.ReadInt32LittleEndian(_data.Span.Slice(location, 4));

            // Clear out upper flags
            flag &= ((Race.Flag)0x00000000FFFFFFFF);

            // Set upper flags
            ulong flags2 = BinaryPrimitives.ReadUInt32LittleEndian(_data.Span.Slice(124, 4));
            flags2 <<= 32;
            flag |= ((Race.Flag)flags2);
            return flag;
        }
    }
}