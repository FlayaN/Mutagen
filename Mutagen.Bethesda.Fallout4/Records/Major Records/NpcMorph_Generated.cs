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
using System.Reactive.Disposables;
using System.Reactive.Linq;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Fallout4
{
    #region Class
    public partial class NpcMorph :
        IEquatable<INpcMorphGetter>,
        ILoquiObjectSetter<NpcMorph>,
        INpcMorph
    {
        #region Ctor
        public NpcMorph()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Key
        public UInt32 Key { get; set; } = default;
        #endregion
        #region Value
        public Single Value { get; set; } = default;
        #endregion

        #region To String

        public void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            NpcMorphMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not INpcMorphGetter rhs) return false;
            return ((NpcMorphCommon)((INpcMorphGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(INpcMorphGetter? obj)
        {
            return ((NpcMorphCommon)((INpcMorphGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((NpcMorphCommon)((INpcMorphGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public class Mask<TItem> :
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            {
                this.Key = initialValue;
                this.Value = initialValue;
            }

            public Mask(
                TItem Key,
                TItem Value)
            {
                this.Key = Key;
                this.Value = Value;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Key;
            public TItem Value;
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
                if (!object.Equals(this.Key, rhs.Key)) return false;
                if (!object.Equals(this.Value, rhs.Value)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Key);
                hash.Add(this.Value);
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public bool All(Func<TItem, bool> eval)
            {
                if (!eval(this.Key)) return false;
                if (!eval(this.Value)) return false;
                return true;
            }
            #endregion

            #region Any
            public bool Any(Func<TItem, bool> eval)
            {
                if (eval(this.Key)) return true;
                if (eval(this.Value)) return true;
                return false;
            }
            #endregion

            #region Translate
            public Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new NpcMorph.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                obj.Key = eval(this.Key);
                obj.Value = eval(this.Value);
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public string Print(NpcMorph.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, NpcMorph.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(NpcMorph.Mask<TItem>)} =>");
                using (sb.Brace())
                {
                    if (printMask?.Key ?? true)
                    {
                        sb.AppendItem(Key, "Key");
                    }
                    if (printMask?.Value ?? true)
                    {
                        sb.AppendItem(Value, "Value");
                    }
                }
            }
            #endregion

        }

        public class ErrorMask :
            IErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? Overall { get; set; }
            private List<string>? _warnings;
            public List<string> Warnings
            {
                get
                {
                    if (_warnings == null)
                    {
                        _warnings = new List<string>();
                    }
                    return _warnings;
                }
            }
            public Exception? Key;
            public Exception? Value;
            #endregion

            #region IErrorMask
            public object? GetNthMask(int index)
            {
                NpcMorph_FieldIndex enu = (NpcMorph_FieldIndex)index;
                switch (enu)
                {
                    case NpcMorph_FieldIndex.Key:
                        return Key;
                    case NpcMorph_FieldIndex.Value:
                        return Value;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthException(int index, Exception ex)
            {
                NpcMorph_FieldIndex enu = (NpcMorph_FieldIndex)index;
                switch (enu)
                {
                    case NpcMorph_FieldIndex.Key:
                        this.Key = ex;
                        break;
                    case NpcMorph_FieldIndex.Value:
                        this.Value = ex;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthMask(int index, object obj)
            {
                NpcMorph_FieldIndex enu = (NpcMorph_FieldIndex)index;
                switch (enu)
                {
                    case NpcMorph_FieldIndex.Key:
                        this.Key = (Exception?)obj;
                        break;
                    case NpcMorph_FieldIndex.Value:
                        this.Value = (Exception?)obj;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public bool IsInError()
            {
                if (Overall != null) return true;
                if (Key != null) return true;
                if (Value != null) return true;
                return false;
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public void Print(StructuredStringBuilder sb, string? name = null)
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
            protected void PrintFillInternal(StructuredStringBuilder sb)
            {
                {
                    sb.AppendItem(Key, "Key");
                }
                {
                    sb.AppendItem(Value, "Value");
                }
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Key = this.Key.Combine(rhs.Key);
                ret.Value = this.Value.Combine(rhs.Value);
                return ret;
            }
            public static ErrorMask? Combine(ErrorMask? lhs, ErrorMask? rhs)
            {
                if (lhs != null && rhs != null) return lhs.Combine(rhs);
                return lhs ?? rhs;
            }
            #endregion

            #region Factory
            public static ErrorMask Factory(ErrorMaskBuilder errorMask)
            {
                return new ErrorMask();
            }
            #endregion

        }
        public class TranslationMask : ITranslationMask
        {
            #region Members
            private TranslationCrystal? _crystal;
            public readonly bool DefaultOn;
            public bool OnOverall;
            public bool Key;
            public bool Value;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
            {
                this.DefaultOn = defaultOn;
                this.OnOverall = onOverall;
                this.Key = defaultOn;
                this.Value = defaultOn;
            }

            #endregion

            public TranslationCrystal GetCrystal()
            {
                if (_crystal != null) return _crystal;
                var ret = new List<(bool On, TranslationCrystal? SubCrystal)>();
                GetCrystal(ret);
                _crystal = new TranslationCrystal(ret.ToArray());
                return _crystal;
            }

            protected void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
                ret.Add((Key, null));
                ret.Add((Value, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => NpcMorphBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((NpcMorphBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public static NpcMorph CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            var ret = new NpcMorph();
            ((NpcMorphSetterCommon)((INpcMorphGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out NpcMorph item,
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
            ((NpcMorphSetterCommon)((INpcMorphGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static NpcMorph GetNew()
        {
            return new NpcMorph();
        }

    }
    #endregion

    #region Interface
    public partial interface INpcMorph :
        ILoquiObjectSetter<INpcMorph>,
        INpcMorphGetter
    {
        new UInt32 Key { get; set; }
        new Single Value { get; set; }
    }

    public partial interface INpcMorphGetter :
        ILoquiObject,
        IBinaryItem,
        ILoquiObject<INpcMorphGetter>
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object? CommonSetterInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonSetterTranslationInstance();
        static ILoquiRegistration StaticRegistration => NpcMorph_Registration.Instance;
        UInt32 Key { get; }
        Single Value { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class NpcMorphMixIn
    {
        public static void Clear(this INpcMorph item)
        {
            ((NpcMorphSetterCommon)((INpcMorphGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static NpcMorph.Mask<bool> GetEqualsMask(
            this INpcMorphGetter item,
            INpcMorphGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((NpcMorphCommon)((INpcMorphGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this INpcMorphGetter item,
            string? name = null,
            NpcMorph.Mask<bool>? printMask = null)
        {
            return ((NpcMorphCommon)((INpcMorphGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this INpcMorphGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            NpcMorph.Mask<bool>? printMask = null)
        {
            ((NpcMorphCommon)((INpcMorphGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this INpcMorphGetter item,
            INpcMorphGetter rhs,
            NpcMorph.TranslationMask? equalsMask = null)
        {
            return ((NpcMorphCommon)((INpcMorphGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this INpcMorph lhs,
            INpcMorphGetter rhs)
        {
            ((NpcMorphSetterTranslationCommon)((INpcMorphGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: default,
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this INpcMorph lhs,
            INpcMorphGetter rhs,
            NpcMorph.TranslationMask? copyMask = null)
        {
            ((NpcMorphSetterTranslationCommon)((INpcMorphGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this INpcMorph lhs,
            INpcMorphGetter rhs,
            out NpcMorph.ErrorMask errorMask,
            NpcMorph.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((NpcMorphSetterTranslationCommon)((INpcMorphGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = NpcMorph.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this INpcMorph lhs,
            INpcMorphGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((NpcMorphSetterTranslationCommon)((INpcMorphGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static NpcMorph DeepCopy(
            this INpcMorphGetter item,
            NpcMorph.TranslationMask? copyMask = null)
        {
            return ((NpcMorphSetterTranslationCommon)((INpcMorphGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static NpcMorph DeepCopy(
            this INpcMorphGetter item,
            out NpcMorph.ErrorMask errorMask,
            NpcMorph.TranslationMask? copyMask = null)
        {
            return ((NpcMorphSetterTranslationCommon)((INpcMorphGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static NpcMorph DeepCopy(
            this INpcMorphGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((NpcMorphSetterTranslationCommon)((INpcMorphGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this INpcMorph item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            ((NpcMorphSetterCommon)((INpcMorphGetter)item).CommonSetterInstance()!).CopyInFromBinary(
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
    internal enum NpcMorph_FieldIndex
    {
        Key = 0,
        Value = 1,
    }
    #endregion

    #region Registration
    internal partial class NpcMorph_Registration : ILoquiRegistration
    {
        public static readonly NpcMorph_Registration Instance = new NpcMorph_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Fallout4.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Fallout4.ProtocolKey,
            msgID: 346,
            version: 0);

        public const string GUID = "75eda107-e397-4e6f-b5e3-053fec1b45bf";

        public const ushort AdditionalFieldCount = 2;

        public const ushort FieldCount = 2;

        public static readonly Type MaskType = typeof(NpcMorph.Mask<>);

        public static readonly Type ErrorMaskType = typeof(NpcMorph.ErrorMask);

        public static readonly Type ClassType = typeof(NpcMorph);

        public static readonly Type GetterType = typeof(INpcMorphGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(INpcMorph);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Fallout4.NpcMorph";

        public const string Name = "NpcMorph";

        public const string Namespace = "Mutagen.Bethesda.Fallout4";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(NpcMorphBinaryWriteTranslation);
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
    internal partial class NpcMorphSetterCommon
    {
        public static readonly NpcMorphSetterCommon Instance = new NpcMorphSetterCommon();

        partial void ClearPartial();
        
        public void Clear(INpcMorph item)
        {
            ClearPartial();
            item.Key = default;
            item.Value = default;
        }
        
        #region Mutagen
        public void RemapLinks(INpcMorph obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            INpcMorph item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: NpcMorphBinaryCreateTranslation.FillBinaryStructs);
        }
        
        #endregion
        
    }
    internal partial class NpcMorphCommon
    {
        public static readonly NpcMorphCommon Instance = new NpcMorphCommon();

        public NpcMorph.Mask<bool> GetEqualsMask(
            INpcMorphGetter item,
            INpcMorphGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new NpcMorph.Mask<bool>(false);
            ((NpcMorphCommon)((INpcMorphGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            INpcMorphGetter item,
            INpcMorphGetter rhs,
            NpcMorph.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            ret.Key = item.Key == rhs.Key;
            ret.Value = item.Value.EqualsWithin(rhs.Value);
        }
        
        public string Print(
            INpcMorphGetter item,
            string? name = null,
            NpcMorph.Mask<bool>? printMask = null)
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
            INpcMorphGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            NpcMorph.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"NpcMorph =>");
            }
            else
            {
                sb.AppendLine($"{name} (NpcMorph) =>");
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
            INpcMorphGetter item,
            StructuredStringBuilder sb,
            NpcMorph.Mask<bool>? printMask = null)
        {
            if (printMask?.Key ?? true)
            {
                sb.AppendItem(item.Key, "Key");
            }
            if (printMask?.Value ?? true)
            {
                sb.AppendItem(item.Value, "Value");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            INpcMorphGetter? lhs,
            INpcMorphGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if ((crystal?.GetShouldTranslate((int)NpcMorph_FieldIndex.Key) ?? true))
            {
                if (lhs.Key != rhs.Key) return false;
            }
            if ((crystal?.GetShouldTranslate((int)NpcMorph_FieldIndex.Value) ?? true))
            {
                if (!lhs.Value.EqualsWithin(rhs.Value)) return false;
            }
            return true;
        }
        
        public virtual int GetHashCode(INpcMorphGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Key);
            hash.Add(item.Value);
            return hash.ToHashCode();
        }
        
        #endregion
        
        
        public object GetNew()
        {
            return NpcMorph.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(INpcMorphGetter obj)
        {
            yield break;
        }
        
        #endregion
        
    }
    internal partial class NpcMorphSetterTranslationCommon
    {
        public static readonly NpcMorphSetterTranslationCommon Instance = new NpcMorphSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            INpcMorph item,
            INpcMorphGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            if ((copyMask?.GetShouldTranslate((int)NpcMorph_FieldIndex.Key) ?? true))
            {
                item.Key = rhs.Key;
            }
            if ((copyMask?.GetShouldTranslate((int)NpcMorph_FieldIndex.Value) ?? true))
            {
                item.Value = rhs.Value;
            }
        }
        
        #endregion
        
        public NpcMorph DeepCopy(
            INpcMorphGetter item,
            NpcMorph.TranslationMask? copyMask = null)
        {
            NpcMorph ret = (NpcMorph)((NpcMorphCommon)((INpcMorphGetter)item).CommonInstance()!).GetNew();
            ((NpcMorphSetterTranslationCommon)((INpcMorphGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public NpcMorph DeepCopy(
            INpcMorphGetter item,
            out NpcMorph.ErrorMask errorMask,
            NpcMorph.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            NpcMorph ret = (NpcMorph)((NpcMorphCommon)((INpcMorphGetter)item).CommonInstance()!).GetNew();
            ((NpcMorphSetterTranslationCommon)((INpcMorphGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = NpcMorph.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public NpcMorph DeepCopy(
            INpcMorphGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            NpcMorph ret = (NpcMorph)((NpcMorphCommon)((INpcMorphGetter)item).CommonInstance()!).GetNew();
            ((NpcMorphSetterTranslationCommon)((INpcMorphGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class NpcMorph
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => NpcMorph_Registration.Instance;
        public static ILoquiRegistration StaticRegistration => NpcMorph_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => NpcMorphCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterInstance()
        {
            return NpcMorphSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => NpcMorphSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object INpcMorphGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object INpcMorphGetter.CommonSetterInstance() => this.CommonSetterInstance();
        [DebuggerStepThrough]
        object INpcMorphGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Fallout4
{
    public partial class NpcMorphBinaryWriteTranslation : IBinaryWriteTranslator
    {
        public readonly static NpcMorphBinaryWriteTranslation Instance = new NpcMorphBinaryWriteTranslation();

        public static void WriteEmbedded(
            INpcMorphGetter item,
            MutagenWriter writer)
        {
            writer.Write(item.Key);
            FloatBinaryTranslation<MutagenFrame, MutagenWriter>.Instance.Write(
                writer: writer,
                item: item.Value);
        }

        public void Write(
            MutagenWriter writer,
            INpcMorphGetter item,
            TypedWriteParams? translationParams = null)
        {
            WriteEmbedded(
                item: item,
                writer: writer);
        }

        public void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams? translationParams = null)
        {
            Write(
                item: (INpcMorphGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class NpcMorphBinaryCreateTranslation
    {
        public readonly static NpcMorphBinaryCreateTranslation Instance = new NpcMorphBinaryCreateTranslation();

        public static void FillBinaryStructs(
            INpcMorph item,
            MutagenFrame frame)
        {
            item.Key = frame.ReadUInt32();
            item.Value = FloatBinaryTranslation<MutagenFrame, MutagenWriter>.Instance.Parse(reader: frame);
        }

    }

}
namespace Mutagen.Bethesda.Fallout4
{
    #region Binary Write Mixins
    public static class NpcMorphBinaryTranslationMixIn
    {
        public static void WriteToBinary(
            this INpcMorphGetter item,
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((NpcMorphBinaryWriteTranslation)item.BinaryWriteTranslator).Write(
                item: item,
                writer: writer,
                translationParams: translationParams);
        }

    }
    #endregion


}
namespace Mutagen.Bethesda.Fallout4
{
    internal partial class NpcMorphBinaryOverlay :
        PluginBinaryOverlay,
        INpcMorphGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => NpcMorph_Registration.Instance;
        public static ILoquiRegistration StaticRegistration => NpcMorph_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => NpcMorphCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => NpcMorphSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object INpcMorphGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object? INpcMorphGetter.CommonSetterInstance() => null;
        [DebuggerStepThrough]
        object INpcMorphGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => NpcMorphBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((NpcMorphBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        public UInt32 Key => BinaryPrimitives.ReadUInt32LittleEndian(_data.Slice(0x0, 0x4));
        public Single Value => _data.Slice(0x4, 0x4).Float();
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected NpcMorphBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }

        public static INpcMorphGetter NpcMorphFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            TypedParseParams? translationParams = null)
        {
            var ret = new NpcMorphBinaryOverlay(
                bytes: stream.RemainingMemory.Slice(0, 0x8),
                package: package);
            int offset = stream.Position;
            stream.Position += 0x8;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static INpcMorphGetter NpcMorphFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams? translationParams = null)
        {
            return NpcMorphFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                translationParams: translationParams);
        }

        #region To String

        public void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            NpcMorphMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not INpcMorphGetter rhs) return false;
            return ((NpcMorphCommon)((INpcMorphGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(INpcMorphGetter? obj)
        {
            return ((NpcMorphCommon)((INpcMorphGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((NpcMorphCommon)((INpcMorphGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

