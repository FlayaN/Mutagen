﻿using Noggog;
using System;
using System.IO;

namespace Mutagen.Bethesda.Binary
{
    public class BinaryTranslationCaster<T, M> : IBinaryTranslation<Object, Object>
    {
        public IBinaryTranslation<T, M> Source { get; }

        public BinaryTranslationCaster(IBinaryTranslation<T, M> src)
        {
            this.Source = src;
        }

        void IBinaryTranslation<object, object>.Write(MutagenWriter writer, object item, ContentLength length, bool doMasks, out object maskObj)
        {
            Source.Write(writer, (T)item, length, doMasks, out var subMaskObj);
            maskObj = subMaskObj;
        }

        TryGet<object> IBinaryTranslation<object, object>.Parse(MutagenFrame frame, bool doMasks, out object maskObj)
        {
            var ret = Source.Parse(frame, doMasks, out var subMaskObj).Bubble<object>((i) => i);
            maskObj = subMaskObj;
            return ret;
        }
    }
}