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
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Skyrim.Internals;
using Mutagen.Bethesda.Translations.Binary;
using Noggog;
using Noggog.StructuredStrings;
using Noggog.StructuredStrings.CSharp;
using RecordTypeInts = Mutagen.Bethesda.Skyrim.Internals.RecordTypeInts;
using RecordTypes = Mutagen.Bethesda.Skyrim.Internals.RecordTypes;
using System.Buffers.Binary;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reactive.Disposables;
using System.Reactive.Linq;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Skyrim
{
    #region Class
    public partial class MagicEffectGuideArchetype :
        MagicEffectArchetype,
        IEquatable<IMagicEffectGuideArchetypeGetter>,
        ILoquiObjectSetter<MagicEffectGuideArchetype>,
        IMagicEffectGuideArchetypeInternal
    {

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            MagicEffectGuideArchetypeMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IMagicEffectGuideArchetypeGetter rhs) return false;
            return ((MagicEffectGuideArchetypeCommon)((IMagicEffectGuideArchetypeGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IMagicEffectGuideArchetypeGetter? obj)
        {
            return ((MagicEffectGuideArchetypeCommon)((IMagicEffectGuideArchetypeGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((MagicEffectGuideArchetypeCommon)((IMagicEffectGuideArchetypeGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            MagicEffectArchetype.Mask<TItem>,
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            : base(initialValue)
            {
            }

            public Mask(
                TItem Type,
                TItem AssociationKey,
                TItem ActorValue)
            : base(
                Type: Type,
                AssociationKey: AssociationKey,
                ActorValue: ActorValue)
            {
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

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
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(base.GetHashCode());
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public override bool All(Func<TItem, bool> eval)
            {
                if (!base.All(eval)) return false;
                return true;
            }
            #endregion

            #region Any
            public override bool Any(Func<TItem, bool> eval)
            {
                if (base.Any(eval)) return true;
                return false;
            }
            #endregion

            #region Translate
            public new Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new MagicEffectGuideArchetype.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public string Print(MagicEffectGuideArchetype.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, MagicEffectGuideArchetype.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(MagicEffectGuideArchetype.Mask<TItem>)} =>");
                using (sb.Brace())
                {
                }
            }
            #endregion

        }

        public new class ErrorMask :
            MagicEffectArchetype.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                MagicEffectGuideArchetype_FieldIndex enu = (MagicEffectGuideArchetype_FieldIndex)index;
                switch (enu)
                {
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                MagicEffectGuideArchetype_FieldIndex enu = (MagicEffectGuideArchetype_FieldIndex)index;
                switch (enu)
                {
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                MagicEffectGuideArchetype_FieldIndex enu = (MagicEffectGuideArchetype_FieldIndex)index;
                switch (enu)
                {
                    default:
                        base.SetNthMask(index, obj);
                        break;
                }
            }

            public override bool IsInError()
            {
                if (Overall != null) return true;
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
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
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
            MagicEffectArchetype.TranslationMask,
            ITranslationMask
        {
            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
                : base(defaultOn, onOverall)
            {
            }

            #endregion

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => MagicEffectGuideArchetypeBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((MagicEffectGuideArchetypeBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public new static MagicEffectGuideArchetype CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            var ret = new MagicEffectGuideArchetype();
            ((MagicEffectGuideArchetypeSetterCommon)((IMagicEffectGuideArchetypeGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out MagicEffectGuideArchetype item,
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
            ((MagicEffectGuideArchetypeSetterCommon)((IMagicEffectGuideArchetypeGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new MagicEffectGuideArchetype GetNew()
        {
            return new MagicEffectGuideArchetype();
        }

    }
    #endregion

    #region Interface
    public partial interface IMagicEffectGuideArchetype :
        ILoquiObjectSetter<IMagicEffectGuideArchetypeInternal>,
        IMagicEffectArchetypeInternal,
        IMagicEffectGuideArchetypeGetter
    {
    }

    public partial interface IMagicEffectGuideArchetypeInternal :
        IMagicEffectArchetypeInternal,
        IMagicEffectGuideArchetype,
        IMagicEffectGuideArchetypeGetter
    {
    }

    public partial interface IMagicEffectGuideArchetypeGetter :
        IMagicEffectArchetypeGetter,
        IBinaryItem,
        ILoquiObject<IMagicEffectGuideArchetypeGetter>
    {
        static new ILoquiRegistration StaticRegistration => MagicEffectGuideArchetype_Registration.Instance;

    }

    #endregion

    #region Common MixIn
    public static partial class MagicEffectGuideArchetypeMixIn
    {
        public static void Clear(this IMagicEffectGuideArchetypeInternal item)
        {
            ((MagicEffectGuideArchetypeSetterCommon)((IMagicEffectGuideArchetypeGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static MagicEffectGuideArchetype.Mask<bool> GetEqualsMask(
            this IMagicEffectGuideArchetypeGetter item,
            IMagicEffectGuideArchetypeGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((MagicEffectGuideArchetypeCommon)((IMagicEffectGuideArchetypeGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this IMagicEffectGuideArchetypeGetter item,
            string? name = null,
            MagicEffectGuideArchetype.Mask<bool>? printMask = null)
        {
            return ((MagicEffectGuideArchetypeCommon)((IMagicEffectGuideArchetypeGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this IMagicEffectGuideArchetypeGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            MagicEffectGuideArchetype.Mask<bool>? printMask = null)
        {
            ((MagicEffectGuideArchetypeCommon)((IMagicEffectGuideArchetypeGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IMagicEffectGuideArchetypeGetter item,
            IMagicEffectGuideArchetypeGetter rhs,
            MagicEffectGuideArchetype.TranslationMask? equalsMask = null)
        {
            return ((MagicEffectGuideArchetypeCommon)((IMagicEffectGuideArchetypeGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IMagicEffectGuideArchetypeInternal lhs,
            IMagicEffectGuideArchetypeGetter rhs,
            out MagicEffectGuideArchetype.ErrorMask errorMask,
            MagicEffectGuideArchetype.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((MagicEffectGuideArchetypeSetterTranslationCommon)((IMagicEffectGuideArchetypeGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = MagicEffectGuideArchetype.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IMagicEffectGuideArchetypeInternal lhs,
            IMagicEffectGuideArchetypeGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((MagicEffectGuideArchetypeSetterTranslationCommon)((IMagicEffectGuideArchetypeGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static MagicEffectGuideArchetype DeepCopy(
            this IMagicEffectGuideArchetypeGetter item,
            MagicEffectGuideArchetype.TranslationMask? copyMask = null)
        {
            return ((MagicEffectGuideArchetypeSetterTranslationCommon)((IMagicEffectGuideArchetypeGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static MagicEffectGuideArchetype DeepCopy(
            this IMagicEffectGuideArchetypeGetter item,
            out MagicEffectGuideArchetype.ErrorMask errorMask,
            MagicEffectGuideArchetype.TranslationMask? copyMask = null)
        {
            return ((MagicEffectGuideArchetypeSetterTranslationCommon)((IMagicEffectGuideArchetypeGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static MagicEffectGuideArchetype DeepCopy(
            this IMagicEffectGuideArchetypeGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((MagicEffectGuideArchetypeSetterTranslationCommon)((IMagicEffectGuideArchetypeGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IMagicEffectGuideArchetypeInternal item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            ((MagicEffectGuideArchetypeSetterCommon)((IMagicEffectGuideArchetypeGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                translationParams: translationParams);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Skyrim
{
    #region Field Index
    internal enum MagicEffectGuideArchetype_FieldIndex
    {
        Type = 0,
        AssociationKey = 1,
        ActorValue = 2,
    }
    #endregion

    #region Registration
    internal partial class MagicEffectGuideArchetype_Registration : ILoquiRegistration
    {
        public static readonly MagicEffectGuideArchetype_Registration Instance = new MagicEffectGuideArchetype_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Skyrim.ProtocolKey,
            msgID: 125,
            version: 0);

        public const string GUID = "ab6820d2-0b6e-46bb-b163-f00eaada140c";

        public const ushort AdditionalFieldCount = 0;

        public const ushort FieldCount = 3;

        public static readonly Type MaskType = typeof(MagicEffectGuideArchetype.Mask<>);

        public static readonly Type ErrorMaskType = typeof(MagicEffectGuideArchetype.ErrorMask);

        public static readonly Type ClassType = typeof(MagicEffectGuideArchetype);

        public static readonly Type GetterType = typeof(IMagicEffectGuideArchetypeGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IMagicEffectGuideArchetype);

        public static readonly Type? InternalSetterType = typeof(IMagicEffectGuideArchetypeInternal);

        public const string FullName = "Mutagen.Bethesda.Skyrim.MagicEffectGuideArchetype";

        public const string Name = "MagicEffectGuideArchetype";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(MagicEffectGuideArchetypeBinaryWriteTranslation);
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
    internal partial class MagicEffectGuideArchetypeSetterCommon : MagicEffectArchetypeSetterCommon
    {
        public new static readonly MagicEffectGuideArchetypeSetterCommon Instance = new MagicEffectGuideArchetypeSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IMagicEffectGuideArchetypeInternal item)
        {
            ClearPartial();
            base.Clear(item);
        }
        
        public override void Clear(IMagicEffectArchetypeInternal item)
        {
            Clear(item: (IMagicEffectGuideArchetypeInternal)item);
        }
        
        #region Mutagen
        public void RemapLinks(IMagicEffectGuideArchetype obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IMagicEffectGuideArchetypeInternal item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: MagicEffectGuideArchetypeBinaryCreateTranslation.FillBinaryStructs);
        }
        
        public override void CopyInFromBinary(
            IMagicEffectArchetypeInternal item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            CopyInFromBinary(
                item: (MagicEffectGuideArchetype)item,
                frame: frame,
                translationParams: translationParams);
        }
        
        #endregion
        
    }
    internal partial class MagicEffectGuideArchetypeCommon : MagicEffectArchetypeCommon
    {
        public new static readonly MagicEffectGuideArchetypeCommon Instance = new MagicEffectGuideArchetypeCommon();

        public MagicEffectGuideArchetype.Mask<bool> GetEqualsMask(
            IMagicEffectGuideArchetypeGetter item,
            IMagicEffectGuideArchetypeGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new MagicEffectGuideArchetype.Mask<bool>(false);
            ((MagicEffectGuideArchetypeCommon)((IMagicEffectGuideArchetypeGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IMagicEffectGuideArchetypeGetter item,
            IMagicEffectGuideArchetypeGetter rhs,
            MagicEffectGuideArchetype.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string Print(
            IMagicEffectGuideArchetypeGetter item,
            string? name = null,
            MagicEffectGuideArchetype.Mask<bool>? printMask = null)
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
            IMagicEffectGuideArchetypeGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            MagicEffectGuideArchetype.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"MagicEffectGuideArchetype =>");
            }
            else
            {
                sb.AppendLine($"{name} (MagicEffectGuideArchetype) =>");
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
            IMagicEffectGuideArchetypeGetter item,
            StructuredStringBuilder sb,
            MagicEffectGuideArchetype.Mask<bool>? printMask = null)
        {
            MagicEffectArchetypeCommon.ToStringFields(
                item: item,
                sb: sb,
                printMask: printMask);
        }
        
        public static MagicEffectGuideArchetype_FieldIndex ConvertFieldIndex(MagicEffectArchetype_FieldIndex index)
        {
            switch (index)
            {
                case MagicEffectArchetype_FieldIndex.Type:
                    return (MagicEffectGuideArchetype_FieldIndex)((int)index);
                case MagicEffectArchetype_FieldIndex.AssociationKey:
                    return (MagicEffectGuideArchetype_FieldIndex)((int)index);
                case MagicEffectArchetype_FieldIndex.ActorValue:
                    return (MagicEffectGuideArchetype_FieldIndex)((int)index);
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast_Enum_Only()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IMagicEffectGuideArchetypeGetter? lhs,
            IMagicEffectGuideArchetypeGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if (!base.Equals((IMagicEffectArchetypeGetter)lhs, (IMagicEffectArchetypeGetter)rhs, crystal)) return false;
            return true;
        }
        
        public override bool Equals(
            IMagicEffectArchetypeGetter? lhs,
            IMagicEffectArchetypeGetter? rhs,
            TranslationCrystal? crystal)
        {
            return Equals(
                lhs: (IMagicEffectGuideArchetypeGetter?)lhs,
                rhs: rhs as IMagicEffectGuideArchetypeGetter,
                crystal: crystal);
        }
        
        public virtual int GetHashCode(IMagicEffectGuideArchetypeGetter item)
        {
            var hash = new HashCode();
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IMagicEffectArchetypeGetter item)
        {
            return GetHashCode(item: (IMagicEffectGuideArchetypeGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return MagicEffectGuideArchetype.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(IMagicEffectGuideArchetypeGetter obj)
        {
            yield break;
        }
        
        #endregion
        
    }
    internal partial class MagicEffectGuideArchetypeSetterTranslationCommon : MagicEffectArchetypeSetterTranslationCommon
    {
        public new static readonly MagicEffectGuideArchetypeSetterTranslationCommon Instance = new MagicEffectGuideArchetypeSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IMagicEffectGuideArchetypeInternal item,
            IMagicEffectGuideArchetypeGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                item,
                rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
        }
        
        public void DeepCopyIn(
            IMagicEffectGuideArchetype item,
            IMagicEffectGuideArchetypeGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IMagicEffectArchetype)item,
                (IMagicEffectArchetypeGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
        }
        
        public override void DeepCopyIn(
            IMagicEffectArchetypeInternal item,
            IMagicEffectArchetypeGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IMagicEffectGuideArchetypeInternal)item,
                rhs: (IMagicEffectGuideArchetypeGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        public override void DeepCopyIn(
            IMagicEffectArchetype item,
            IMagicEffectArchetypeGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IMagicEffectGuideArchetype)item,
                rhs: (IMagicEffectGuideArchetypeGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public MagicEffectGuideArchetype DeepCopy(
            IMagicEffectGuideArchetypeGetter item,
            MagicEffectGuideArchetype.TranslationMask? copyMask = null)
        {
            MagicEffectGuideArchetype ret = (MagicEffectGuideArchetype)((MagicEffectGuideArchetypeCommon)((IMagicEffectGuideArchetypeGetter)item).CommonInstance()!).GetNew();
            ((MagicEffectGuideArchetypeSetterTranslationCommon)((IMagicEffectGuideArchetypeGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public MagicEffectGuideArchetype DeepCopy(
            IMagicEffectGuideArchetypeGetter item,
            out MagicEffectGuideArchetype.ErrorMask errorMask,
            MagicEffectGuideArchetype.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            MagicEffectGuideArchetype ret = (MagicEffectGuideArchetype)((MagicEffectGuideArchetypeCommon)((IMagicEffectGuideArchetypeGetter)item).CommonInstance()!).GetNew();
            ((MagicEffectGuideArchetypeSetterTranslationCommon)((IMagicEffectGuideArchetypeGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = MagicEffectGuideArchetype.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public MagicEffectGuideArchetype DeepCopy(
            IMagicEffectGuideArchetypeGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            MagicEffectGuideArchetype ret = (MagicEffectGuideArchetype)((MagicEffectGuideArchetypeCommon)((IMagicEffectGuideArchetypeGetter)item).CommonInstance()!).GetNew();
            ((MagicEffectGuideArchetypeSetterTranslationCommon)((IMagicEffectGuideArchetypeGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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

namespace Mutagen.Bethesda.Skyrim
{
    public partial class MagicEffectGuideArchetype
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => MagicEffectGuideArchetype_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => MagicEffectGuideArchetype_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => MagicEffectGuideArchetypeCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return MagicEffectGuideArchetypeSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => MagicEffectGuideArchetypeSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim
{
    public partial class MagicEffectGuideArchetypeBinaryWriteTranslation :
        MagicEffectArchetypeBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new readonly static MagicEffectGuideArchetypeBinaryWriteTranslation Instance = new MagicEffectGuideArchetypeBinaryWriteTranslation();

        public void Write(
            MutagenWriter writer,
            IMagicEffectGuideArchetypeGetter item,
            TypedWriteParams? translationParams = null)
        {
            MagicEffectArchetypeBinaryWriteTranslation.WriteEmbedded(
                item: item,
                writer: writer);
        }

        public override void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams? translationParams = null)
        {
            Write(
                item: (IMagicEffectGuideArchetypeGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

        public override void Write(
            MutagenWriter writer,
            IMagicEffectArchetypeGetter item,
            TypedWriteParams? translationParams = null)
        {
            Write(
                item: (IMagicEffectGuideArchetypeGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class MagicEffectGuideArchetypeBinaryCreateTranslation : MagicEffectArchetypeBinaryCreateTranslation
    {
        public new readonly static MagicEffectGuideArchetypeBinaryCreateTranslation Instance = new MagicEffectGuideArchetypeBinaryCreateTranslation();

    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class MagicEffectGuideArchetypeBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim
{
    internal partial class MagicEffectGuideArchetypeBinaryOverlay :
        MagicEffectArchetypeBinaryOverlay,
        IMagicEffectGuideArchetypeGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => MagicEffectGuideArchetype_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => MagicEffectGuideArchetype_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => MagicEffectGuideArchetypeCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => MagicEffectGuideArchetypeSetterTranslationCommon.Instance;

        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => MagicEffectGuideArchetypeBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((MagicEffectGuideArchetypeBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected MagicEffectGuideArchetypeBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }

        public static IMagicEffectGuideArchetypeGetter MagicEffectGuideArchetypeFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            TypedParseParams? translationParams = null)
        {
            var ret = new MagicEffectGuideArchetypeBinaryOverlay(
                bytes: stream.RemainingMemory,
                package: package);
            int offset = stream.Position;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static IMagicEffectGuideArchetypeGetter MagicEffectGuideArchetypeFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams? translationParams = null)
        {
            return MagicEffectGuideArchetypeFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                translationParams: translationParams);
        }

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            MagicEffectGuideArchetypeMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IMagicEffectGuideArchetypeGetter rhs) return false;
            return ((MagicEffectGuideArchetypeCommon)((IMagicEffectGuideArchetypeGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IMagicEffectGuideArchetypeGetter? obj)
        {
            return ((MagicEffectGuideArchetypeCommon)((IMagicEffectGuideArchetypeGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((MagicEffectGuideArchetypeCommon)((IMagicEffectGuideArchetypeGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

