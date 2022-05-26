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
using Mutagen.Bethesda.Plugins.Aspects;
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
using System.Reactive.Disposables;
using System.Reactive.Linq;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Fallout4
{
    #region Class
    public partial class PackageDataFloat :
        APackageData,
        IEquatable<IPackageDataFloatGetter>,
        ILoquiObjectSetter<PackageDataFloat>,
        IPackageDataFloat
    {
        #region Ctor
        public PackageDataFloat()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Data
        public Single Data { get; set; } = default;
        #endregion

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            PackageDataFloatMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IPackageDataFloatGetter rhs) return false;
            return ((PackageDataFloatCommon)((IPackageDataFloatGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IPackageDataFloatGetter? obj)
        {
            return ((PackageDataFloatCommon)((IPackageDataFloatGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((PackageDataFloatCommon)((IPackageDataFloatGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            APackageData.Mask<TItem>,
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            : base(initialValue)
            {
                this.Data = initialValue;
            }

            public Mask(
                TItem Name,
                TItem Flags,
                TItem Data)
            : base(
                Name: Name,
                Flags: Flags)
            {
                this.Data = Data;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Data;
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
                if (!object.Equals(this.Data, rhs.Data)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Data);
                hash.Add(base.GetHashCode());
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public override bool All(Func<TItem, bool> eval)
            {
                if (!base.All(eval)) return false;
                if (!eval(this.Data)) return false;
                return true;
            }
            #endregion

            #region Any
            public override bool Any(Func<TItem, bool> eval)
            {
                if (base.Any(eval)) return true;
                if (eval(this.Data)) return true;
                return false;
            }
            #endregion

            #region Translate
            public new Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new PackageDataFloat.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
                obj.Data = eval(this.Data);
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public string Print(PackageDataFloat.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, PackageDataFloat.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(PackageDataFloat.Mask<TItem>)} =>");
                using (sb.Brace())
                {
                    if (printMask?.Data ?? true)
                    {
                        sb.AppendItem(Data, "Data");
                    }
                }
            }
            #endregion

        }

        public new class ErrorMask :
            APackageData.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? Data;
            #endregion

            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                PackageDataFloat_FieldIndex enu = (PackageDataFloat_FieldIndex)index;
                switch (enu)
                {
                    case PackageDataFloat_FieldIndex.Data:
                        return Data;
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                PackageDataFloat_FieldIndex enu = (PackageDataFloat_FieldIndex)index;
                switch (enu)
                {
                    case PackageDataFloat_FieldIndex.Data:
                        this.Data = ex;
                        break;
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                PackageDataFloat_FieldIndex enu = (PackageDataFloat_FieldIndex)index;
                switch (enu)
                {
                    case PackageDataFloat_FieldIndex.Data:
                        this.Data = (Exception?)obj;
                        break;
                    default:
                        base.SetNthMask(index, obj);
                        break;
                }
            }

            public override bool IsInError()
            {
                if (Overall != null) return true;
                if (Data != null) return true;
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
                    sb.AppendItem(Data, "Data");
                }
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Data = this.Data.Combine(rhs.Data);
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
            APackageData.TranslationMask,
            ITranslationMask
        {
            #region Members
            public bool Data;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
                : base(defaultOn, onOverall)
            {
                this.Data = defaultOn;
            }

            #endregion

            protected override void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
                base.GetCrystal(ret);
                ret.Add((Data, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => PackageDataFloatBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((PackageDataFloatBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public new static PackageDataFloat CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            var ret = new PackageDataFloat();
            ((PackageDataFloatSetterCommon)((IPackageDataFloatGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out PackageDataFloat item,
            TypedParseParams? translationParams = null)
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
            ((PackageDataFloatSetterCommon)((IPackageDataFloatGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new PackageDataFloat GetNew()
        {
            return new PackageDataFloat();
        }

    }
    #endregion

    #region Interface
    public partial interface IPackageDataFloat :
        IAPackageData,
        ILoquiObjectSetter<IPackageDataFloat>,
        INamed,
        INamedRequired,
        IPackageDataFloatGetter
    {
        new Single Data { get; set; }
    }

    public partial interface IPackageDataFloatGetter :
        IAPackageDataGetter,
        IBinaryItem,
        ILoquiObject<IPackageDataFloatGetter>,
        INamedGetter,
        INamedRequiredGetter
    {
        static new ILoquiRegistration StaticRegistration => PackageDataFloat_Registration.Instance;
        Single Data { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class PackageDataFloatMixIn
    {
        public static void Clear(this IPackageDataFloat item)
        {
            ((PackageDataFloatSetterCommon)((IPackageDataFloatGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static PackageDataFloat.Mask<bool> GetEqualsMask(
            this IPackageDataFloatGetter item,
            IPackageDataFloatGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((PackageDataFloatCommon)((IPackageDataFloatGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this IPackageDataFloatGetter item,
            string? name = null,
            PackageDataFloat.Mask<bool>? printMask = null)
        {
            return ((PackageDataFloatCommon)((IPackageDataFloatGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this IPackageDataFloatGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            PackageDataFloat.Mask<bool>? printMask = null)
        {
            ((PackageDataFloatCommon)((IPackageDataFloatGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IPackageDataFloatGetter item,
            IPackageDataFloatGetter rhs,
            PackageDataFloat.TranslationMask? equalsMask = null)
        {
            return ((PackageDataFloatCommon)((IPackageDataFloatGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IPackageDataFloat lhs,
            IPackageDataFloatGetter rhs,
            out PackageDataFloat.ErrorMask errorMask,
            PackageDataFloat.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((PackageDataFloatSetterTranslationCommon)((IPackageDataFloatGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = PackageDataFloat.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IPackageDataFloat lhs,
            IPackageDataFloatGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((PackageDataFloatSetterTranslationCommon)((IPackageDataFloatGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static PackageDataFloat DeepCopy(
            this IPackageDataFloatGetter item,
            PackageDataFloat.TranslationMask? copyMask = null)
        {
            return ((PackageDataFloatSetterTranslationCommon)((IPackageDataFloatGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static PackageDataFloat DeepCopy(
            this IPackageDataFloatGetter item,
            out PackageDataFloat.ErrorMask errorMask,
            PackageDataFloat.TranslationMask? copyMask = null)
        {
            return ((PackageDataFloatSetterTranslationCommon)((IPackageDataFloatGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static PackageDataFloat DeepCopy(
            this IPackageDataFloatGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((PackageDataFloatSetterTranslationCommon)((IPackageDataFloatGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IPackageDataFloat item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            ((PackageDataFloatSetterCommon)((IPackageDataFloatGetter)item).CommonSetterInstance()!).CopyInFromBinary(
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
    internal enum PackageDataFloat_FieldIndex
    {
        Name = 0,
        Flags = 1,
        Data = 2,
    }
    #endregion

    #region Registration
    internal partial class PackageDataFloat_Registration : ILoquiRegistration
    {
        public static readonly PackageDataFloat_Registration Instance = new PackageDataFloat_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Fallout4.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Fallout4.ProtocolKey,
            msgID: 570,
            version: 0);

        public const string GUID = "bfeae534-e6c5-404e-ad1d-942dc2f88d96";

        public const ushort AdditionalFieldCount = 1;

        public const ushort FieldCount = 3;

        public static readonly Type MaskType = typeof(PackageDataFloat.Mask<>);

        public static readonly Type ErrorMaskType = typeof(PackageDataFloat.ErrorMask);

        public static readonly Type ClassType = typeof(PackageDataFloat);

        public static readonly Type GetterType = typeof(IPackageDataFloatGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IPackageDataFloat);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Fallout4.PackageDataFloat";

        public const string Name = "PackageDataFloat";

        public const string Namespace = "Mutagen.Bethesda.Fallout4";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static RecordTriggerSpecs TriggerSpecs => _recordSpecs.Value;
        private static readonly Lazy<RecordTriggerSpecs> _recordSpecs = new Lazy<RecordTriggerSpecs>(() =>
        {
            var all = RecordCollection.Factory(
                RecordTypes.BNAM,
                RecordTypes.PNAM);
            return new RecordTriggerSpecs(allRecordTypes: all);
        });
        public static readonly Type BinaryWriteTranslation = typeof(PackageDataFloatBinaryWriteTranslation);
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
    internal partial class PackageDataFloatSetterCommon : APackageDataSetterCommon
    {
        public new static readonly PackageDataFloatSetterCommon Instance = new PackageDataFloatSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IPackageDataFloat item)
        {
            ClearPartial();
            item.Data = default;
            base.Clear(item);
        }
        
        public override void Clear(IAPackageData item)
        {
            Clear(item: (IPackageDataFloat)item);
        }
        
        #region Mutagen
        public void RemapLinks(IPackageDataFloat obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
            base.RemapLinks(obj, mapping);
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IPackageDataFloat item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: PackageDataFloatBinaryCreateTranslation.FillBinaryStructs,
                fillTyped: PackageDataFloatBinaryCreateTranslation.FillBinaryRecordTypes);
        }
        
        public override void CopyInFromBinary(
            IAPackageData item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            CopyInFromBinary(
                item: (PackageDataFloat)item,
                frame: frame,
                translationParams: translationParams);
        }
        
        #endregion
        
    }
    internal partial class PackageDataFloatCommon : APackageDataCommon
    {
        public new static readonly PackageDataFloatCommon Instance = new PackageDataFloatCommon();

        public PackageDataFloat.Mask<bool> GetEqualsMask(
            IPackageDataFloatGetter item,
            IPackageDataFloatGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new PackageDataFloat.Mask<bool>(false);
            ((PackageDataFloatCommon)((IPackageDataFloatGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IPackageDataFloatGetter item,
            IPackageDataFloatGetter rhs,
            PackageDataFloat.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            ret.Data = item.Data.EqualsWithin(rhs.Data);
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string Print(
            IPackageDataFloatGetter item,
            string? name = null,
            PackageDataFloat.Mask<bool>? printMask = null)
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
            IPackageDataFloatGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            PackageDataFloat.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"PackageDataFloat =>");
            }
            else
            {
                sb.AppendLine($"{name} (PackageDataFloat) =>");
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
            IPackageDataFloatGetter item,
            StructuredStringBuilder sb,
            PackageDataFloat.Mask<bool>? printMask = null)
        {
            APackageDataCommon.ToStringFields(
                item: item,
                sb: sb,
                printMask: printMask);
            if (printMask?.Data ?? true)
            {
                sb.AppendItem(item.Data, "Data");
            }
        }
        
        public static PackageDataFloat_FieldIndex ConvertFieldIndex(APackageData_FieldIndex index)
        {
            switch (index)
            {
                case APackageData_FieldIndex.Name:
                    return (PackageDataFloat_FieldIndex)((int)index);
                case APackageData_FieldIndex.Flags:
                    return (PackageDataFloat_FieldIndex)((int)index);
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast_Enum_Only()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IPackageDataFloatGetter? lhs,
            IPackageDataFloatGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if (!base.Equals((IAPackageDataGetter)lhs, (IAPackageDataGetter)rhs, crystal)) return false;
            if ((crystal?.GetShouldTranslate((int)PackageDataFloat_FieldIndex.Data) ?? true))
            {
                if (!lhs.Data.EqualsWithin(rhs.Data)) return false;
            }
            return true;
        }
        
        public override bool Equals(
            IAPackageDataGetter? lhs,
            IAPackageDataGetter? rhs,
            TranslationCrystal? crystal)
        {
            return Equals(
                lhs: (IPackageDataFloatGetter?)lhs,
                rhs: rhs as IPackageDataFloatGetter,
                crystal: crystal);
        }
        
        public virtual int GetHashCode(IPackageDataFloatGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Data);
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IAPackageDataGetter item)
        {
            return GetHashCode(item: (IPackageDataFloatGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return PackageDataFloat.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(IPackageDataFloatGetter obj)
        {
            foreach (var item in base.EnumerateFormLinks(obj))
            {
                yield return item;
            }
            yield break;
        }
        
        #endregion
        
    }
    internal partial class PackageDataFloatSetterTranslationCommon : APackageDataSetterTranslationCommon
    {
        public new static readonly PackageDataFloatSetterTranslationCommon Instance = new PackageDataFloatSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IPackageDataFloat item,
            IPackageDataFloatGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IAPackageData)item,
                (IAPackageDataGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
            if ((copyMask?.GetShouldTranslate((int)PackageDataFloat_FieldIndex.Data) ?? true))
            {
                item.Data = rhs.Data;
            }
        }
        
        
        public override void DeepCopyIn(
            IAPackageData item,
            IAPackageDataGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IPackageDataFloat)item,
                rhs: (IPackageDataFloatGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public PackageDataFloat DeepCopy(
            IPackageDataFloatGetter item,
            PackageDataFloat.TranslationMask? copyMask = null)
        {
            PackageDataFloat ret = (PackageDataFloat)((PackageDataFloatCommon)((IPackageDataFloatGetter)item).CommonInstance()!).GetNew();
            ((PackageDataFloatSetterTranslationCommon)((IPackageDataFloatGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public PackageDataFloat DeepCopy(
            IPackageDataFloatGetter item,
            out PackageDataFloat.ErrorMask errorMask,
            PackageDataFloat.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            PackageDataFloat ret = (PackageDataFloat)((PackageDataFloatCommon)((IPackageDataFloatGetter)item).CommonInstance()!).GetNew();
            ((PackageDataFloatSetterTranslationCommon)((IPackageDataFloatGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = PackageDataFloat.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public PackageDataFloat DeepCopy(
            IPackageDataFloatGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            PackageDataFloat ret = (PackageDataFloat)((PackageDataFloatCommon)((IPackageDataFloatGetter)item).CommonInstance()!).GetNew();
            ((PackageDataFloatSetterTranslationCommon)((IPackageDataFloatGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class PackageDataFloat
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => PackageDataFloat_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => PackageDataFloat_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => PackageDataFloatCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return PackageDataFloatSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => PackageDataFloatSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Fallout4
{
    public partial class PackageDataFloatBinaryWriteTranslation :
        APackageDataBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new readonly static PackageDataFloatBinaryWriteTranslation Instance = new PackageDataFloatBinaryWriteTranslation();

        public static void WriteEmbedded(
            IPackageDataFloatGetter item,
            MutagenWriter writer)
        {
        }

        public void Write(
            MutagenWriter writer,
            IPackageDataFloatGetter item,
            TypedWriteParams? translationParams = null)
        {
            WriteEmbedded(
                item: item,
                writer: writer);
            APackageDataBinaryWriteTranslation.WriteRecordTypes(
                item: item,
                writer: writer,
                translationParams: translationParams);
        }

        public override void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams? translationParams = null)
        {
            Write(
                item: (IPackageDataFloatGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

        public override void Write(
            MutagenWriter writer,
            IAPackageDataGetter item,
            TypedWriteParams? translationParams = null)
        {
            Write(
                item: (IPackageDataFloatGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class PackageDataFloatBinaryCreateTranslation : APackageDataBinaryCreateTranslation
    {
        public new readonly static PackageDataFloatBinaryCreateTranslation Instance = new PackageDataFloatBinaryCreateTranslation();

        public static void FillBinaryStructs(
            IPackageDataFloat item,
            MutagenFrame frame)
        {
        }

    }

}
namespace Mutagen.Bethesda.Fallout4
{
    #region Binary Write Mixins
    public static class PackageDataFloatBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Fallout4
{
    internal partial class PackageDataFloatBinaryOverlay :
        APackageDataBinaryOverlay,
        IPackageDataFloatGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => PackageDataFloat_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => PackageDataFloat_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => PackageDataFloatCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => PackageDataFloatSetterTranslationCommon.Instance;

        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => PackageDataFloatBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((PackageDataFloatBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected PackageDataFloatBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }

        public static IPackageDataFloatGetter PackageDataFloatFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            TypedParseParams? parseParams = null)
        {
            var ret = new PackageDataFloatBinaryOverlay(
                bytes: stream.RemainingMemory,
                package: package);
            int offset = stream.Position;
            ret.FillTypelessSubrecordTypes(
                stream: stream,
                finalPos: stream.Length,
                offset: offset,
                parseParams: parseParams,
                fill: ret.FillRecordType);
            return ret;
        }

        public static IPackageDataFloatGetter PackageDataFloatFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams? parseParams = null)
        {
            return PackageDataFloatFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                parseParams: parseParams);
        }

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            PackageDataFloatMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IPackageDataFloatGetter rhs) return false;
            return ((PackageDataFloatCommon)((IPackageDataFloatGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IPackageDataFloatGetter? obj)
        {
            return ((PackageDataFloatCommon)((IPackageDataFloatGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((PackageDataFloatCommon)((IPackageDataFloatGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion
