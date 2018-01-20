﻿using Loqui;
using Noggog;
using Noggog.Notifying;
using System;
using System.IO;

namespace Mutagen.Bethesda.Binary
{
    public class EnumBinaryTranslation<E> : IBinaryTranslation<E, Exception>, IBinaryTranslation<E?, Exception>
        where E : struct, IComparable, IConvertible
    {
        public readonly static EnumBinaryTranslation<E> Instance = new EnumBinaryTranslation<E>();

        public TryGet<E> Parse(MutagenFrame frame, bool doMasks, out Exception errorMask)
        {
            try
            {
                var parse = ParseValue(frame);
                errorMask = null;
                return TryGet<E>.Succeed(parse);
            }
            catch (Exception ex)
            {
                if (doMasks)
                {
                    errorMask = ex;
                    return TryGet<E>.Failure;
                }
                throw;
            }
        }

        public TryGet<E> Parse<M>(
            MutagenFrame frame,
            int fieldIndex,
            Func<M> errorMask)
            where M : IErrorMask
        {
            var ret = this.Parse(
                frame,
                errorMask != null,
                out var ex);
            ErrorMask.HandleErrorMask(
                errorMask,
                fieldIndex,
                ex);
            return ret;
        }

        public void Write(MutagenWriter writer, E item, ContentLength length, bool doMasks, out Exception errorMask)
        {
            Write(writer, (E?)item, length, doMasks, out errorMask);
        }

        public void Write(MutagenWriter writer, E? item, ContentLength length, bool doMasks, out Exception errorMask)
        {
            if (!item.HasValue)
            {
                errorMask = null;
                return;
            }
            try
            {
                WriteValue(writer, item.Value, length);
                errorMask = null;
            }
            catch (Exception ex)
            when (doMasks)
            {
                errorMask = ex;
            }
        }

        public void Write<M>(
            MutagenWriter writer,
            E? item,
            ContentLength length,
            int fieldIndex,
            Func<M> errorMask)
            where M : IErrorMask
        {
            if (!item.HasValue) throw new NotImplementedException();
            try
            {
                WriteValue(writer, item.Value, length);
            }
            catch (Exception ex)
            {
                ErrorMask.HandleException(
                    errorMask,
                    fieldIndex,
                    ex);
            }
        }

        public void Write<M>(
            MutagenWriter writer,
            IHasBeenSetItemGetter<E?> item,
            ContentLength length,
            int fieldIndex,
            Func<M> errorMask)
            where M : IErrorMask
        {
            if (!item.HasBeenSet) return;
            this.Write(
                writer,
                item.Item,
                length,
                fieldIndex,
                errorMask);
        }

        public void Write<M>(
            MutagenWriter writer,
            IHasBeenSetItemGetter<E> item,
            ContentLength length,
            int fieldIndex,
            Func<M> errorMask)
            where M : IErrorMask
        {
            if (!item.HasBeenSet) return;
            this.Write(
                writer,
                item.Item,
                length,
                fieldIndex,
                errorMask);
        }

        public void Write<M>(
            MutagenWriter writer,
            IHasItemGetter<E?> item,
            ContentLength length,
            int fieldIndex,
            Func<M> errorMask)
            where M : IErrorMask
        {
            this.Write(
                writer,
                item.Item,
                length,
                fieldIndex,
                errorMask);
        }

        public void Write<M>(
            MutagenWriter writer,
            IHasItemGetter<E> item,
            ContentLength length,
            int fieldIndex,
            Func<M> errorMask)
            where M : IErrorMask
        {
            this.Write(
                writer,
                item.Item,
                length,
                fieldIndex,
                errorMask);
        }

        public void Write(
            MutagenWriter writer,
            E? item,
            RecordType header,
            ContentLength length,
            bool nullable,
            bool doMasks,
            out Exception errorMask)
        {
            if (item == null)
            {
                if (nullable)
                {
                    errorMask = null;
                    return;
                }
                throw new ArgumentException("Non optional string was null.");
            }
            try
            {
                using (HeaderExport.ExportHeader(writer, header, ObjectType.Subrecord))
                {
                    WriteValue(writer, item.Value, length);
                }
                errorMask = null;
            }
            catch (Exception ex)
            when (doMasks)
            {
                errorMask = ex;
            }
        }

        public void Write<M>(
            MutagenWriter writer,
            E? item,
            RecordType header,
            ContentLength length,
            int fieldIndex,
            bool nullable,
            bool doMasks,
            Func<M> errorMask)
            where M : IErrorMask
        {
            this.Write(
                writer,
                item,
                header,
                length,
                nullable,
                doMasks,
                out var subMask);
            ErrorMask.HandleException(
                errorMask,
                fieldIndex,
                subMask);
        }

        public void Write<M>(
            MutagenWriter writer,
            IHasBeenSetItemGetter<E?> item,
            RecordType header,
            ContentLength length,
            int fieldIndex,
            bool nullable,
            Func<M> errorMask)
            where M : IErrorMask
        {
            if (!item.HasBeenSet) return;
            this.Write(
                writer,
                item.Item,
                header,
                length,
                fieldIndex,
                nullable,
                errorMask != null,
                errorMask);
        }

        public void Write<M>(
            MutagenWriter writer,
            IHasBeenSetItemGetter<E> item,
            RecordType header,
            ContentLength length,
            int fieldIndex,
            bool nullable,
            Func<M> errorMask)
            where M : IErrorMask
        {
            if (!item.HasBeenSet) return;
            this.Write(
                writer,
                item.Item,
                header,
                length,
                fieldIndex,
                nullable,
                errorMask != null,
                errorMask);
        }

        public void Write<M>(
            MutagenWriter writer,
            IHasItemGetter<E?> item,
            RecordType header,
            ContentLength length,
            int fieldIndex,
            bool nullable,
            Func<M> errorMask)
            where M : IErrorMask
        {
            this.Write(
                writer,
                item.Item,
                header,
                length,
                fieldIndex,
                nullable,
                errorMask != null,
                errorMask);
        }

        public void Write<M>(
            MutagenWriter writer,
            IHasItemGetter<E> item,
            RecordType header,
            ContentLength length,
            int fieldIndex,
            bool nullable,
            Func<M> errorMask)
            where M : IErrorMask
        {
            this.Write(
                writer,
                item.Item,
                header,
                length,
                fieldIndex,
                nullable,
                errorMask != null,
                errorMask);
        }

        public E ParseValue(MutagenFrame reader)
        {
            int i;
            switch (reader.RemainingLength.Value)
            {
                case 1:
                    i = reader.Reader.ReadByte();
                    break;
                case 2:
                    i = reader.Reader.ReadInt16();
                    break;
                case 4:
                    i = reader.Reader.ReadInt32();
                    break;
                default:
                    throw new NotImplementedException();
            }
            return (E)Enum.ToObject(typeof(E), i);
        }

        protected void WriteValue(MutagenWriter writer, E item, ContentLength length)
        {
            switch (length.Value)
            {
                case 1:
                    writer.Write(item.ToByte(null));
                    break;
                case 2:
                    writer.Write(item.ToInt16(null));
                    break;
                case 4:
                    writer.Write(item.ToInt32(null));
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        TryGet<E?> IBinaryTranslation<E?, Exception>.Parse(MutagenFrame frame, bool doMasks, out Exception maskObj)
        {
            return Parse(
                frame,
                doMasks,
                out maskObj).Bubble<E?>((t) => t);
        }
    }
}