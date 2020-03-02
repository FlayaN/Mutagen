﻿using Noggog;
using System;
using System.IO;

namespace Mutagen.Bethesda.Binary
{
    public class BooleanBinaryTranslation : PrimitiveBinaryTranslation<bool>
    {
        public readonly static BooleanBinaryTranslation Instance = new BooleanBinaryTranslation();
        public override int ExpectedLength => 1;

        public override bool ParseValue(MutagenFrame reader)
        {
            return reader.Reader.ReadBool();
        }

        public override void Write(MutagenWriter writer, bool item)
        {
            writer.Write(item);
        }
    }
}