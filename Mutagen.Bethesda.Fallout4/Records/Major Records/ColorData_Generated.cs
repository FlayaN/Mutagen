/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
#region Usings
using Loqui;
using Loqui.Interfaces;
using Loqui.Internal;
using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Fallout4.Internals;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Binary.Headers;
using Mutagen.Bethesda.Plugins.Binary.Overlay;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Binary.Translations;
using Mutagen.Bethesda.Plugins.Exceptions;
using Mutagen.Bethesda.Plugins.Internals;
using Mutagen.Bethesda.Plugins.Records;
using Mutagen.Bethesda.Plugins.Records.Internals;
using Mutagen.Bethesda.Plugins.Records.Mapping;
using Mutagen.Bethesda.Translations.Binary;
using Noggog;
using Noggog.StructuredStrings;
using Noggog.StructuredStrings.CSharp;
using RecordTypeInts = Mutagen.Bethesda.Fallout4.Internals.RecordTypeInts;
using RecordTypes = Mutagen.Bethesda.Fallout4.Internals.RecordTypes;
using System.Buffers.Binary;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Reactive.Disposables;
using System.Reactive.Linq;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Fallout4
{
    #region Class
    public partial class ColorData :
        AColorRecordData,
        IColorData,
        IEquatable<IColorDataGetter>,
        ILoquiObjectSetter<ColorData>
    {
        #region Ctor
        public ColorData()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Color
        public Color Color { get; set; } = default;
        #endregion

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            ColorDataMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IColorDataGetter rhs) return false;
            return ((ColorDataCommon)((IColorDataGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(IColorDataGetter? obj)
        {
            return ((ColorDataCommon)((IColorDataGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((ColorDataCommon)((IColorDataGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            AColorRecordData.Mask<TItem>,
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem Color)
            : base()
            {
                this.Color = Color;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Color;
            #endregion

            #region Equals
            public override bool Equals(object? obj)
            {
                if (!(obj is Mask<TItem> rhs)) return false;
                return Equals(rhs);
            }

            public bool Equals(Mask<TItem>? rhs)
            {
                if (rhs == null) return false;
                if (!base.Equals(rhs)) return false;
                if (!object.Equals(this.Color, rhs.Color)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Color);
                hash.Add(base.GetHashCode());
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public override bool All(Func<TItem, bool> eval)
            {
                if (!base.All(eval)) return false;
                if (!eval(this.Color)) return false;
                return true;
            }
            #endregion

            #region Any
            public override bool Any(Func<TItem, bool> eval)
            {
                if (base.Any(eval)) return true;
                if (eval(this.Color)) return true;
                return false;
            }
            #endregion

            #region Translate
            public new Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new ColorData.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
                obj.Color = eval(this.Color);
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public string Print(ColorData.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, ColorData.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(ColorData.Mask<TItem>)} =>");
                using (sb.Brace())
                {
                    if (printMask?.Color ?? true)
                    {
                        sb.AppendItem(Color, "Color");
                    }
                }
            }
            #endregion

        }

        public new class ErrorMask :
            AColorRecordData.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? Color;
            #endregion

            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                ColorData_FieldIndex enu = (ColorData_FieldIndex)index;
                switch (enu)
                {
                    case ColorData_FieldIndex.Color:
                        return Color;
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                ColorData_FieldIndex enu = (ColorData_FieldIndex)index;
                switch (enu)
                {
                    case ColorData_FieldIndex.Color:
                        this.Color = ex;
                        break;
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                ColorData_FieldIndex enu = (ColorData_FieldIndex)index;
                switch (enu)
                {
                    case ColorData_FieldIndex.Color:
                        this.Color = (Exception?)obj;
                        break;
                    default:
                        base.SetNthMask(index, obj);
                        break;
                }
            }

            public override bool IsInError()
            {
                if (Overall != null) return true;
                if (Color != null) return true;
                return false;
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public override void Print(StructuredStringBuilder sb, string? name = null)
            {
                sb.AppendLine($"{(name ?? "ErrorMask")} =>");
                using (sb.Brace())
                {
                    if (this.Overall != null)
                    {
                        sb.AppendLine("Overall =>");
                        using (sb.Brace())
                        {
                            sb.AppendLine($"{this.Overall}");
                        }
                    }
                    PrintFillInternal(sb);
                }
            }
            protected override void PrintFillInternal(StructuredStringBuilder sb)
            {
                base.PrintFillInternal(sb);
                {
                    sb.AppendItem(Color, "Color");
                }
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Color = this.Color.Combine(rhs.Color);
                return ret;
            }
            public static ErrorMask? Combine(ErrorMask? lhs, ErrorMask? rhs)
            {
                if (lhs != null && rhs != null) return lhs.Combine(rhs);
                return lhs ?? rhs;
            }
            #endregion

            #region Factory
            public static new ErrorMask Factory(ErrorMaskBuilder errorMask)
            {
                return new ErrorMask();
            }
            #endregion

        }
        public new class TranslationMask :
            AColorRecordData.TranslationMask,
            ITranslationMask
        {
            #region Members
            public bool Color;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
                : base(defaultOn, onOverall)
            {
                this.Color = defaultOn;
            }

            #endregion

            protected override void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
                base.GetCrystal(ret);
                ret.Add((Color, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => ColorDataBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((ColorDataBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public new static ColorData CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            var ret = new ColorData();
            ((ColorDataSetterCommon)((IColorDataGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out ColorData item,
            TypedParseParams translationParams = default)
        {
            var startPos = frame.Position;
            item = CreateFromBinary(
                frame: frame,
                translationParams: translationParams);
            return startPos != frame.Position;
        }
        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        void IClearable.Clear()
        {
            ((ColorDataSetterCommon)((IColorDataGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new ColorData GetNew()
        {
            return new ColorData();
        }

    }
    #endregion

    #region Interface
    public partial interface IColorData :
        IAColorRecordData,
        IColorDataGetter,
        ILoquiObjectSetter<IColorData>
    {
        new Color Color { get; set; }
    }

    public partial interface IColorDataGetter :
        IAColorRecordDataGetter,
        IBinaryItem,
        ILoquiObject<IColorDataGetter>
    {
        static new ILoquiRegistration StaticRegistration => ColorData_Registration.Instance;
        Color Color { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class ColorDataMixIn
    {
        public static void Clear(this IColorData item)
        {
            ((ColorDataSetterCommon)((IColorDataGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static ColorData.Mask<bool> GetEqualsMask(
            this IColorDataGetter item,
            IColorDataGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((ColorDataCommon)((IColorDataGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this IColorDataGetter item,
            string? name = null,
            ColorData.Mask<bool>? printMask = null)
        {
            return ((ColorDataCommon)((IColorDataGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this IColorDataGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            ColorData.Mask<bool>? printMask = null)
        {
            ((ColorDataCommon)((IColorDataGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IColorDataGetter item,
            IColorDataGetter rhs,
            ColorData.TranslationMask? equalsMask = null)
        {
            return ((ColorDataCommon)((IColorDataGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                equalsMask: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IColorData lhs,
            IColorDataGetter rhs,
            out ColorData.ErrorMask errorMask,
            ColorData.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((ColorDataSetterTranslationCommon)((IColorDataGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = ColorData.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IColorData lhs,
            IColorDataGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((ColorDataSetterTranslationCommon)((IColorDataGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static ColorData DeepCopy(
            this IColorDataGetter item,
            ColorData.TranslationMask? copyMask = null)
        {
            return ((ColorDataSetterTranslationCommon)((IColorDataGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static ColorData DeepCopy(
            this IColorDataGetter item,
            out ColorData.ErrorMask errorMask,
            ColorData.TranslationMask? copyMask = null)
        {
            return ((ColorDataSetterTranslationCommon)((IColorDataGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static ColorData DeepCopy(
            this IColorDataGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((ColorDataSetterTranslationCommon)((IColorDataGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IColorData item,
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            ((ColorDataSetterCommon)((IColorDataGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                translationParams: translationParams);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Fallout4
{
    #region Field Index
    internal enum ColorData_FieldIndex
    {
        Color = 0,
    }
    #endregion

    #region Registration
    internal partial class ColorData_Registration : ILoquiRegistration
    {
        public static readonly ColorData_Registration Instance = new ColorData_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Fallout4.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Fallout4.ProtocolKey,
            msgID: 649,
            version: 0);

        public const string GUID = "6236ceeb-5c16-4b04-a6c1-160a789e87de";

        public const ushort AdditionalFieldCount = 1;

        public const ushort FieldCount = 1;

        public static readonly Type MaskType = typeof(ColorData.Mask<>);

        public static readonly Type ErrorMaskType = typeof(ColorData.ErrorMask);

        public static readonly Type ClassType = typeof(ColorData);

        public static readonly Type GetterType = typeof(IColorDataGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IColorData);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Fallout4.ColorData";

        public const string Name = "ColorData";

        public const string Namespace = "Mutagen.Bethesda.Fallout4";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(ColorDataBinaryWriteTranslation);
        #region Interface
        ProtocolKey ILoquiRegistration.ProtocolKey => ProtocolKey;
        ObjectKey ILoquiRegistration.ObjectKey => ObjectKey;
        string ILoquiRegistration.GUID => GUID;
        ushort ILoquiRegistration.FieldCount => FieldCount;
        ushort ILoquiRegistration.AdditionalFieldCount => AdditionalFieldCount;
        Type ILoquiRegistration.MaskType => MaskType;
        Type ILoquiRegistration.ErrorMaskType => ErrorMaskType;
        Type ILoquiRegistration.ClassType => ClassType;
        Type ILoquiRegistration.SetterType => SetterType;
        Type? ILoquiRegistration.InternalSetterType => InternalSetterType;
        Type ILoquiRegistration.GetterType => GetterType;
        Type? ILoquiRegistration.InternalGetterType => InternalGetterType;
        string ILoquiRegistration.FullName => FullName;
        string ILoquiRegistration.Name => Name;
        string ILoquiRegistration.Namespace => Namespace;
        byte ILoquiRegistration.GenericCount => GenericCount;
        Type? ILoquiRegistration.GenericRegistrationType => GenericRegistrationType;
        ushort? ILoquiRegistration.GetNameIndex(StringCaseAgnostic name) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsEnumerable(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsLoqui(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsSingleton(ushort index) => throw new NotImplementedException();
        string ILoquiRegistration.GetNthName(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.IsNthDerivative(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.IsProtected(ushort index) => throw new NotImplementedException();
        Type ILoquiRegistration.GetNthType(ushort index) => throw new NotImplementedException();
        #endregion

    }
    #endregion

    #region Common
    internal partial class ColorDataSetterCommon : AColorRecordDataSetterCommon
    {
        public new static readonly ColorDataSetterCommon Instance = new ColorDataSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IColorData item)
        {
            ClearPartial();
            item.Color = default;
            base.Clear(item);
        }
        
        public override void Clear(IAColorRecordData item)
        {
            Clear(item: (IColorData)item);
        }
        
        #region Mutagen
        public void RemapLinks(IColorData obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IColorData item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: ColorDataBinaryCreateTranslation.FillBinaryStructs);
        }
        
        public override void CopyInFromBinary(
            IAColorRecordData item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            CopyInFromBinary(
                item: (ColorData)item,
                frame: frame,
                translationParams: translationParams);
        }
        
        #endregion
        
    }
    internal partial class ColorDataCommon : AColorRecordDataCommon
    {
        public new static readonly ColorDataCommon Instance = new ColorDataCommon();

        public ColorData.Mask<bool> GetEqualsMask(
            IColorDataGetter item,
            IColorDataGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new ColorData.Mask<bool>(false);
            ((ColorDataCommon)((IColorDataGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IColorDataGetter item,
            IColorDataGetter rhs,
            ColorData.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            ret.Color = item.Color.ColorOnlyEquals(rhs.Color);
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string Print(
            IColorDataGetter item,
            string? name = null,
            ColorData.Mask<bool>? printMask = null)
        {
            var sb = new StructuredStringBuilder();
            Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
            return sb.ToString();
        }
        
        public void Print(
            IColorDataGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            ColorData.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"ColorData =>");
            }
            else
            {
                sb.AppendLine($"{name} (ColorData) =>");
            }
            using (sb.Brace())
            {
                ToStringFields(
                    item: item,
                    sb: sb,
                    printMask: printMask);
            }
        }
        
        protected static void ToStringFields(
            IColorDataGetter item,
            StructuredStringBuilder sb,
            ColorData.Mask<bool>? printMask = null)
        {
            AColorRecordDataCommon.ToStringFields(
                item: item,
                sb: sb,
                printMask: printMask);
            if (printMask?.Color ?? true)
            {
                sb.AppendItem(item.Color, "Color");
            }
        }
        
        public static ColorData_FieldIndex ConvertFieldIndex(AColorRecordData_FieldIndex index)
        {
            switch (index)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast_Enum_Only()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IColorDataGetter? lhs,
            IColorDataGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if (!base.Equals((IAColorRecordDataGetter)lhs, (IAColorRecordDataGetter)rhs, equalsMask)) return false;
            if ((equalsMask?.GetShouldTranslate((int)ColorData_FieldIndex.Color) ?? true))
            {
                if (!lhs.Color.ColorOnlyEquals(rhs.Color)) return false;
            }
            return true;
        }
        
        public override bool Equals(
            IAColorRecordDataGetter? lhs,
            IAColorRecordDataGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            return Equals(
                lhs: (IColorDataGetter?)lhs,
                rhs: rhs as IColorDataGetter,
                equalsMask: equalsMask);
        }
        
        public virtual int GetHashCode(IColorDataGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Color);
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IAColorRecordDataGetter item)
        {
            return GetHashCode(item: (IColorDataGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return ColorData.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(IColorDataGetter obj)
        {
            yield break;
        }
        
        #endregion
        
    }
    internal partial class ColorDataSetterTranslationCommon : AColorRecordDataSetterTranslationCommon
    {
        public new static readonly ColorDataSetterTranslationCommon Instance = new ColorDataSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IColorData item,
            IColorDataGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IAColorRecordData)item,
                (IAColorRecordDataGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
            if ((copyMask?.GetShouldTranslate((int)ColorData_FieldIndex.Color) ?? true))
            {
                item.Color = rhs.Color;
            }
        }
        
        
        public override void DeepCopyIn(
            IAColorRecordData item,
            IAColorRecordDataGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IColorData)item,
                rhs: (IColorDataGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public ColorData DeepCopy(
            IColorDataGetter item,
            ColorData.TranslationMask? copyMask = null)
        {
            ColorData ret = (ColorData)((ColorDataCommon)((IColorDataGetter)item).CommonInstance()!).GetNew();
            ((ColorDataSetterTranslationCommon)((IColorDataGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public ColorData DeepCopy(
            IColorDataGetter item,
            out ColorData.ErrorMask errorMask,
            ColorData.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ColorData ret = (ColorData)((ColorDataCommon)((IColorDataGetter)item).CommonInstance()!).GetNew();
            ((ColorDataSetterTranslationCommon)((IColorDataGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = ColorData.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public ColorData DeepCopy(
            IColorDataGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            ColorData ret = (ColorData)((ColorDataCommon)((IColorDataGetter)item).CommonInstance()!).GetNew();
            ((ColorDataSetterTranslationCommon)((IColorDataGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: true);
            return ret;
        }
        
    }
    #endregion

}

namespace Mutagen.Bethesda.Fallout4
{
    public partial class ColorData
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => ColorData_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => ColorData_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => ColorDataCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return ColorDataSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => ColorDataSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Fallout4
{
    public partial class ColorDataBinaryWriteTranslation :
        AColorRecordDataBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new static readonly ColorDataBinaryWriteTranslation Instance = new();

        public static void WriteEmbedded(
            IColorDataGetter item,
            MutagenWriter writer)
        {
            ColorBinaryTranslation.Instance.Write(
                writer: writer,
                item: item.Color);
        }

        public void Write(
            MutagenWriter writer,
            IColorDataGetter item,
            TypedWriteParams translationParams)
        {
            WriteEmbedded(
                item: item,
                writer: writer);
        }

        public override void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams translationParams = default)
        {
            Write(
                item: (IColorDataGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

        public override void Write(
            MutagenWriter writer,
            IAColorRecordDataGetter item,
            TypedWriteParams translationParams)
        {
            Write(
                item: (IColorDataGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class ColorDataBinaryCreateTranslation : AColorRecordDataBinaryCreateTranslation
    {
        public new static readonly ColorDataBinaryCreateTranslation Instance = new ColorDataBinaryCreateTranslation();

        public static void FillBinaryStructs(
            IColorData item,
            MutagenFrame frame)
        {
            item.Color = frame.ReadColor(ColorBinaryType.Alpha);
        }

    }

}
namespace Mutagen.Bethesda.Fallout4
{
    #region Binary Write Mixins
    public static class ColorDataBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Fallout4
{
    internal partial class ColorDataBinaryOverlay :
        AColorRecordDataBinaryOverlay,
        IColorDataGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => ColorData_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => ColorData_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => ColorDataCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => ColorDataSetterTranslationCommon.Instance;

        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => ColorDataBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((ColorDataBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        public Color Color => _structData.Slice(0x0, 0x4).ReadColor(ColorBinaryType.Alpha);
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected ColorDataBinaryOverlay(
            MemoryPair memoryPair,
            BinaryOverlayFactoryPackage package)
            : base(
                memoryPair: memoryPair,
                package: package)
        {
            this.CustomCtor();
        }

        public static IColorDataGetter ColorDataFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            stream = ExtractTypelessSubrecordStructMemory(
                stream: stream,
                meta: package.MetaData.Constants,
                translationParams: translationParams,
                length: 0x4,
                memoryPair: out var memoryPair,
                offset: out var offset);
            var ret = new ColorDataBinaryOverlay(
                memoryPair: memoryPair,
                package: package);
            stream.Position += 0x4;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static IColorDataGetter ColorDataFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            return ColorDataFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                translationParams: translationParams);
        }

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            ColorDataMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IColorDataGetter rhs) return false;
            return ((ColorDataCommon)((IColorDataGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(IColorDataGetter? obj)
        {
            return ((ColorDataCommon)((IColorDataGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((ColorDataCommon)((IColorDataGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

