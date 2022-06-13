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
using Mutagen.Bethesda.Plugins.Cache;
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
    /// <summary>
    /// Implemented by: [SceneActionTypicalType, SceneActionStartScene]
    /// </summary>
    public partial class ASceneActionType :
        IASceneActionType,
        IEquatable<IASceneActionTypeGetter>,
        ILoquiObjectSetter<ASceneActionType>
    {
        #region Ctor
        public ASceneActionType()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion


        #region To String

        public virtual void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            ASceneActionTypeMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IASceneActionTypeGetter rhs) return false;
            return ((ASceneActionTypeCommon)((IASceneActionTypeGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IASceneActionTypeGetter? obj)
        {
            return ((ASceneActionTypeCommon)((IASceneActionTypeGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((ASceneActionTypeCommon)((IASceneActionTypeGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public class Mask<TItem> :
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
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
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public virtual bool All(Func<TItem, bool> eval)
            {
                return true;
            }
            #endregion

            #region Any
            public virtual bool Any(Func<TItem, bool> eval)
            {
                return false;
            }
            #endregion

            #region Translate
            public Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new ASceneActionType.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public string Print(ASceneActionType.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, ASceneActionType.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(ASceneActionType.Mask<TItem>)} =>");
                using (sb.Brace())
                {
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
            #endregion

            #region IErrorMask
            public virtual object? GetNthMask(int index)
            {
                ASceneActionType_FieldIndex enu = (ASceneActionType_FieldIndex)index;
                switch (enu)
                {
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public virtual void SetNthException(int index, Exception ex)
            {
                ASceneActionType_FieldIndex enu = (ASceneActionType_FieldIndex)index;
                switch (enu)
                {
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public virtual void SetNthMask(int index, object obj)
            {
                ASceneActionType_FieldIndex enu = (ASceneActionType_FieldIndex)index;
                switch (enu)
                {
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public virtual bool IsInError()
            {
                if (Overall != null) return true;
                return false;
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public virtual void Print(StructuredStringBuilder sb, string? name = null)
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
            protected virtual void PrintFillInternal(StructuredStringBuilder sb)
            {
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
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
            {
                this.DefaultOn = defaultOn;
                this.OnOverall = onOverall;
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

            protected virtual void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Mutagen
        public virtual IEnumerable<IFormLinkGetter> EnumerateFormLinks() => ASceneActionTypeCommon.Instance.EnumerateFormLinks(this);
        public virtual void RemapLinks(IReadOnlyDictionary<FormKey, FormKey> mapping) => ASceneActionTypeSetterCommon.Instance.RemapLinks(this, mapping);
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected virtual object BinaryWriteTranslator => ASceneActionTypeBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((ASceneActionTypeBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public static ASceneActionType CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            var ret = new ASceneActionType();
            ((ASceneActionTypeSetterCommon)((IASceneActionTypeGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out ASceneActionType item,
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
            ((ASceneActionTypeSetterCommon)((IASceneActionTypeGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static ASceneActionType GetNew()
        {
            return new ASceneActionType();
        }

    }
    #endregion

    #region Interface
    /// <summary>
    /// Implemented by: [SceneActionTypicalType, SceneActionStartScene]
    /// </summary>
    public partial interface IASceneActionType :
        IASceneActionTypeGetter,
        IFormLinkContainer,
        ILoquiObjectSetter<IASceneActionType>
    {
    }

    /// <summary>
    /// Implemented by: [SceneActionTypicalType, SceneActionStartScene]
    /// </summary>
    public partial interface IASceneActionTypeGetter :
        ILoquiObject,
        IBinaryItem,
        IFormLinkContainerGetter,
        ILoquiObject<IASceneActionTypeGetter>
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object? CommonSetterInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonSetterTranslationInstance();
        static ILoquiRegistration StaticRegistration => ASceneActionType_Registration.Instance;

    }

    #endregion

    #region Common MixIn
    public static partial class ASceneActionTypeMixIn
    {
        public static void Clear(this IASceneActionType item)
        {
            ((ASceneActionTypeSetterCommon)((IASceneActionTypeGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static ASceneActionType.Mask<bool> GetEqualsMask(
            this IASceneActionTypeGetter item,
            IASceneActionTypeGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((ASceneActionTypeCommon)((IASceneActionTypeGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this IASceneActionTypeGetter item,
            string? name = null,
            ASceneActionType.Mask<bool>? printMask = null)
        {
            return ((ASceneActionTypeCommon)((IASceneActionTypeGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this IASceneActionTypeGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            ASceneActionType.Mask<bool>? printMask = null)
        {
            ((ASceneActionTypeCommon)((IASceneActionTypeGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IASceneActionTypeGetter item,
            IASceneActionTypeGetter rhs,
            ASceneActionType.TranslationMask? equalsMask = null)
        {
            return ((ASceneActionTypeCommon)((IASceneActionTypeGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IASceneActionType lhs,
            IASceneActionTypeGetter rhs)
        {
            ((ASceneActionTypeSetterTranslationCommon)((IASceneActionTypeGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: default,
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IASceneActionType lhs,
            IASceneActionTypeGetter rhs,
            ASceneActionType.TranslationMask? copyMask = null)
        {
            ((ASceneActionTypeSetterTranslationCommon)((IASceneActionTypeGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IASceneActionType lhs,
            IASceneActionTypeGetter rhs,
            out ASceneActionType.ErrorMask errorMask,
            ASceneActionType.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((ASceneActionTypeSetterTranslationCommon)((IASceneActionTypeGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = ASceneActionType.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IASceneActionType lhs,
            IASceneActionTypeGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((ASceneActionTypeSetterTranslationCommon)((IASceneActionTypeGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static ASceneActionType DeepCopy(
            this IASceneActionTypeGetter item,
            ASceneActionType.TranslationMask? copyMask = null)
        {
            return ((ASceneActionTypeSetterTranslationCommon)((IASceneActionTypeGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static ASceneActionType DeepCopy(
            this IASceneActionTypeGetter item,
            out ASceneActionType.ErrorMask errorMask,
            ASceneActionType.TranslationMask? copyMask = null)
        {
            return ((ASceneActionTypeSetterTranslationCommon)((IASceneActionTypeGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static ASceneActionType DeepCopy(
            this IASceneActionTypeGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((ASceneActionTypeSetterTranslationCommon)((IASceneActionTypeGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IASceneActionType item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            ((ASceneActionTypeSetterCommon)((IASceneActionTypeGetter)item).CommonSetterInstance()!).CopyInFromBinary(
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
    internal enum ASceneActionType_FieldIndex
    {
    }
    #endregion

    #region Registration
    internal partial class ASceneActionType_Registration : ILoquiRegistration
    {
        public static readonly ASceneActionType_Registration Instance = new ASceneActionType_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Fallout4.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Fallout4.ProtocolKey,
            msgID: 557,
            version: 0);

        public const string GUID = "eac0b3ca-2fa9-48e3-87f1-9268048e93dc";

        public const ushort AdditionalFieldCount = 0;

        public const ushort FieldCount = 0;

        public static readonly Type MaskType = typeof(ASceneActionType.Mask<>);

        public static readonly Type ErrorMaskType = typeof(ASceneActionType.ErrorMask);

        public static readonly Type ClassType = typeof(ASceneActionType);

        public static readonly Type GetterType = typeof(IASceneActionTypeGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IASceneActionType);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Fallout4.ASceneActionType";

        public const string Name = "ASceneActionType";

        public const string Namespace = "Mutagen.Bethesda.Fallout4";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(ASceneActionTypeBinaryWriteTranslation);
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
    internal partial class ASceneActionTypeSetterCommon
    {
        public static readonly ASceneActionTypeSetterCommon Instance = new ASceneActionTypeSetterCommon();

        partial void ClearPartial();
        
        public virtual void Clear(IASceneActionType item)
        {
            ClearPartial();
        }
        
        #region Mutagen
        public void RemapLinks(IASceneActionType obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IASceneActionType item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: ASceneActionTypeBinaryCreateTranslation.FillBinaryStructs);
        }
        
        #endregion
        
    }
    internal partial class ASceneActionTypeCommon
    {
        public static readonly ASceneActionTypeCommon Instance = new ASceneActionTypeCommon();

        public ASceneActionType.Mask<bool> GetEqualsMask(
            IASceneActionTypeGetter item,
            IASceneActionTypeGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new ASceneActionType.Mask<bool>(false);
            ((ASceneActionTypeCommon)((IASceneActionTypeGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IASceneActionTypeGetter item,
            IASceneActionTypeGetter rhs,
            ASceneActionType.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
        }
        
        public string Print(
            IASceneActionTypeGetter item,
            string? name = null,
            ASceneActionType.Mask<bool>? printMask = null)
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
            IASceneActionTypeGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            ASceneActionType.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"ASceneActionType =>");
            }
            else
            {
                sb.AppendLine($"{name} (ASceneActionType) =>");
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
            IASceneActionTypeGetter item,
            StructuredStringBuilder sb,
            ASceneActionType.Mask<bool>? printMask = null)
        {
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IASceneActionTypeGetter? lhs,
            IASceneActionTypeGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            return true;
        }
        
        public virtual int GetHashCode(IASceneActionTypeGetter item)
        {
            var hash = new HashCode();
            return hash.ToHashCode();
        }
        
        #endregion
        
        
        public virtual object GetNew()
        {
            return ASceneActionType.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(IASceneActionTypeGetter obj)
        {
            yield break;
        }
        
        #endregion
        
    }
    internal partial class ASceneActionTypeSetterTranslationCommon
    {
        public static readonly ASceneActionTypeSetterTranslationCommon Instance = new ASceneActionTypeSetterTranslationCommon();

        #region DeepCopyIn
        public virtual void DeepCopyIn(
            IASceneActionType item,
            IASceneActionTypeGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
        }
        
        #endregion
        
        public ASceneActionType DeepCopy(
            IASceneActionTypeGetter item,
            ASceneActionType.TranslationMask? copyMask = null)
        {
            ASceneActionType ret = (ASceneActionType)((ASceneActionTypeCommon)((IASceneActionTypeGetter)item).CommonInstance()!).GetNew();
            ((ASceneActionTypeSetterTranslationCommon)((IASceneActionTypeGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public ASceneActionType DeepCopy(
            IASceneActionTypeGetter item,
            out ASceneActionType.ErrorMask errorMask,
            ASceneActionType.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ASceneActionType ret = (ASceneActionType)((ASceneActionTypeCommon)((IASceneActionTypeGetter)item).CommonInstance()!).GetNew();
            ((ASceneActionTypeSetterTranslationCommon)((IASceneActionTypeGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = ASceneActionType.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public ASceneActionType DeepCopy(
            IASceneActionTypeGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            ASceneActionType ret = (ASceneActionType)((ASceneActionTypeCommon)((IASceneActionTypeGetter)item).CommonInstance()!).GetNew();
            ((ASceneActionTypeSetterTranslationCommon)((IASceneActionTypeGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class ASceneActionType
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => ASceneActionType_Registration.Instance;
        public static ILoquiRegistration StaticRegistration => ASceneActionType_Registration.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonInstance() => ASceneActionTypeCommon.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonSetterInstance()
        {
            return ASceneActionTypeSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected virtual object CommonSetterTranslationInstance() => ASceneActionTypeSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IASceneActionTypeGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object IASceneActionTypeGetter.CommonSetterInstance() => this.CommonSetterInstance();
        [DebuggerStepThrough]
        object IASceneActionTypeGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Fallout4
{
    public partial class ASceneActionTypeBinaryWriteTranslation : IBinaryWriteTranslator
    {
        public readonly static ASceneActionTypeBinaryWriteTranslation Instance = new ASceneActionTypeBinaryWriteTranslation();

        public virtual void Write(
            MutagenWriter writer,
            IASceneActionTypeGetter item,
            TypedWriteParams? translationParams = null)
        {
        }

        public virtual void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams? translationParams = null)
        {
            Write(
                item: (IASceneActionTypeGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class ASceneActionTypeBinaryCreateTranslation
    {
        public readonly static ASceneActionTypeBinaryCreateTranslation Instance = new ASceneActionTypeBinaryCreateTranslation();

        public static void FillBinaryStructs(
            IASceneActionType item,
            MutagenFrame frame)
        {
        }

    }

}
namespace Mutagen.Bethesda.Fallout4
{
    #region Binary Write Mixins
    public static class ASceneActionTypeBinaryTranslationMixIn
    {
        public static void WriteToBinary(
            this IASceneActionTypeGetter item,
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((ASceneActionTypeBinaryWriteTranslation)item.BinaryWriteTranslator).Write(
                item: item,
                writer: writer,
                translationParams: translationParams);
        }

    }
    #endregion


}
namespace Mutagen.Bethesda.Fallout4
{
    internal partial class ASceneActionTypeBinaryOverlay :
        PluginBinaryOverlay,
        IASceneActionTypeGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => ASceneActionType_Registration.Instance;
        public static ILoquiRegistration StaticRegistration => ASceneActionType_Registration.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonInstance() => ASceneActionTypeCommon.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonSetterTranslationInstance() => ASceneActionTypeSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IASceneActionTypeGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object? IASceneActionTypeGetter.CommonSetterInstance() => null;
        [DebuggerStepThrough]
        object IASceneActionTypeGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        public virtual IEnumerable<IFormLinkGetter> EnumerateFormLinks() => ASceneActionTypeCommon.Instance.EnumerateFormLinks(this);
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected virtual object BinaryWriteTranslator => ASceneActionTypeBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((ASceneActionTypeBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected ASceneActionTypeBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }

        public static IASceneActionTypeGetter ASceneActionTypeFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            TypedParseParams? translationParams = null)
        {
            var ret = new ASceneActionTypeBinaryOverlay(
                bytes: stream.RemainingMemory,
                package: package);
            int offset = stream.Position;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static IASceneActionTypeGetter ASceneActionTypeFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams? translationParams = null)
        {
            return ASceneActionTypeFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                translationParams: translationParams);
        }

        #region To String

        public virtual void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            ASceneActionTypeMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IASceneActionTypeGetter rhs) return false;
            return ((ASceneActionTypeCommon)((IASceneActionTypeGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IASceneActionTypeGetter? obj)
        {
            return ((ASceneActionTypeCommon)((IASceneActionTypeGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((ASceneActionTypeCommon)((IASceneActionTypeGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

