/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
#region Usings
using Loqui;
using Loqui.Internal;
using Mutagen.Bethesda;
using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Internals;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Skyrim.Internals;
using Noggog;
using System;
using System.Buffers.Binary;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Skyrim
{
    #region Class
    public abstract partial class ASpell :
        SkyrimMajorRecord,
        IASpellInternal,
        ILoquiObjectSetter<ASpell>,
        IEquatable<IASpellGetter>
    {
        #region Ctor
        protected ASpell()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion


        #region To String

        public override void ToString(
            FileGeneration fg,
            string? name = null)
        {
            ASpellMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (!(obj is IASpellGetter rhs)) return false;
            return ((ASpellCommon)((IASpellGetter)this).CommonInstance()!).Equals(this, rhs);
        }

        public bool Equals(IASpellGetter? obj)
        {
            return ((ASpellCommon)((IASpellGetter)this).CommonInstance()!).Equals(this, obj);
        }

        public override int GetHashCode() => ((ASpellCommon)((IASpellGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            SkyrimMajorRecord.Mask<TItem>,
            IMask<TItem>,
            IEquatable<Mask<TItem>>
        {
            #region Ctors
            public Mask(TItem initialValue)
            : base(initialValue)
            {
            }

            public Mask(
                TItem MajorRecordFlagsRaw,
                TItem FormKey,
                TItem VersionControl,
                TItem EditorID,
                TItem FormVersion,
                TItem Version2)
            : base(
                MajorRecordFlagsRaw: MajorRecordFlagsRaw,
                FormKey: FormKey,
                VersionControl: VersionControl,
                EditorID: EditorID,
                FormVersion: FormVersion,
                Version2: Version2)
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
                var ret = new ASpell.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
            }
            #endregion

            #region To String
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(ASpell.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, ASpell.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(ASpell.Mask<TItem>)} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                }
                fg.AppendLine("]");
            }
            #endregion

        }

        public new class ErrorMask :
            SkyrimMajorRecord.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                ASpell_FieldIndex enu = (ASpell_FieldIndex)index;
                switch (enu)
                {
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                ASpell_FieldIndex enu = (ASpell_FieldIndex)index;
                switch (enu)
                {
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                ASpell_FieldIndex enu = (ASpell_FieldIndex)index;
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
            public override string ToString()
            {
                var fg = new FileGeneration();
                ToString(fg, null);
                return fg.ToString();
            }

            public override void ToString(FileGeneration fg, string? name = null)
            {
                fg.AppendLine($"{(name ?? "ErrorMask")} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    if (this.Overall != null)
                    {
                        fg.AppendLine("Overall =>");
                        fg.AppendLine("[");
                        using (new DepthWrapper(fg))
                        {
                            fg.AppendLine($"{this.Overall}");
                        }
                        fg.AppendLine("]");
                    }
                    ToString_FillInternal(fg);
                }
                fg.AppendLine("]");
            }
            protected override void ToString_FillInternal(FileGeneration fg)
            {
                base.ToString_FillInternal(fg);
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
            SkyrimMajorRecord.TranslationMask,
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

        #region Mutagen
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override IEnumerable<FormKey> LinkFormKeys => ASpellCommon.Instance.GetLinkFormKeys(this);
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IEnumerable<FormKey> ILinkedFormKeyContainerGetter.LinkFormKeys => ASpellCommon.Instance.GetLinkFormKeys(this);
        protected override void RemapLinks(IReadOnlyDictionary<FormKey, FormKey> mapping) => ASpellCommon.Instance.RemapLinks(this, mapping);
        void ILinkedFormKeyContainer.RemapLinks(IReadOnlyDictionary<FormKey, FormKey> mapping) => ASpellCommon.Instance.RemapLinks(this, mapping);
        public ASpell(FormKey formKey)
        {
            this.FormKey = formKey;
            CustomCtor();
        }

        public ASpell(IMod mod)
            : this(mod.GetNextFormKey())
        {
        }

        public ASpell(IMod mod, string editorID)
            : this(mod.GetNextFormKey(editorID))
        {
            this.EditorID = editorID;
        }

        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => ASpellBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((ASpellBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }
        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        void IClearable.Clear()
        {
            ((ASpellSetterCommon)((IASpellGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new ASpell GetNew()
        {
            throw new ArgumentException("New called on an abstract class.");
        }

    }
    #endregion

    #region Interface
    public partial interface IASpell :
        IASpellGetter,
        ISkyrimMajorRecord,
        ILoquiObjectSetter<IASpellInternal>,
        ILinkedFormKeyContainer
    {
    }

    public partial interface IASpellInternal :
        ISkyrimMajorRecordInternal,
        IASpell,
        IASpellGetter
    {
    }

    public partial interface IASpellGetter :
        ISkyrimMajorRecordGetter,
        ILoquiObject<IASpellGetter>,
        ILinkedFormKeyContainerGetter,
        IBinaryItem
    {
        static new ILoquiRegistration Registration => ASpell_Registration.Instance;

    }

    #endregion

    #region Common MixIn
    public static partial class ASpellMixIn
    {
        public static void Clear(this IASpellInternal item)
        {
            ((ASpellSetterCommon)((IASpellGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static ASpell.Mask<bool> GetEqualsMask(
            this IASpellGetter item,
            IASpellGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((ASpellCommon)((IASpellGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this IASpellGetter item,
            string? name = null,
            ASpell.Mask<bool>? printMask = null)
        {
            return ((ASpellCommon)((IASpellGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this IASpellGetter item,
            FileGeneration fg,
            string? name = null,
            ASpell.Mask<bool>? printMask = null)
        {
            ((ASpellCommon)((IASpellGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IASpellGetter item,
            IASpellGetter rhs)
        {
            return ((ASpellCommon)((IASpellGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs);
        }

        public static void DeepCopyIn(
            this IASpellInternal lhs,
            IASpellGetter rhs,
            out ASpell.ErrorMask errorMask,
            ASpell.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((ASpellSetterTranslationCommon)((IASpellGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = ASpell.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IASpellInternal lhs,
            IASpellGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((ASpellSetterTranslationCommon)((IASpellGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static ASpell DeepCopy(
            this IASpellGetter item,
            ASpell.TranslationMask? copyMask = null)
        {
            return ((ASpellSetterTranslationCommon)((IASpellGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static ASpell DeepCopy(
            this IASpellGetter item,
            out ASpell.ErrorMask errorMask,
            ASpell.TranslationMask? copyMask = null)
        {
            return ((ASpellSetterTranslationCommon)((IASpellGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static ASpell DeepCopy(
            this IASpellGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((ASpellSetterTranslationCommon)((IASpellGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IASpellInternal item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((ASpellSetterCommon)((IASpellGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Skyrim.Internals
{
    #region Field Index
    public enum ASpell_FieldIndex
    {
        MajorRecordFlagsRaw = 0,
        FormKey = 1,
        VersionControl = 2,
        EditorID = 3,
        FormVersion = 4,
        Version2 = 5,
    }
    #endregion

    #region Registration
    public partial class ASpell_Registration : ILoquiRegistration
    {
        public static readonly ASpell_Registration Instance = new ASpell_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Skyrim.ProtocolKey,
            msgID: 145,
            version: 0);

        public const string GUID = "cef2b193-aa35-4417-afd6-a3bf0f7824f8";

        public const ushort AdditionalFieldCount = 0;

        public const ushort FieldCount = 6;

        public static readonly Type MaskType = typeof(ASpell.Mask<>);

        public static readonly Type ErrorMaskType = typeof(ASpell.ErrorMask);

        public static readonly Type ClassType = typeof(ASpell);

        public static readonly Type GetterType = typeof(IASpellGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IASpell);

        public static readonly Type? InternalSetterType = typeof(IASpellInternal);

        public const string FullName = "Mutagen.Bethesda.Skyrim.ASpell";

        public const string Name = "ASpell";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static ICollectionGetter<RecordType> TriggeringRecordTypes => _TriggeringRecordTypes.Value;
        private static readonly Lazy<ICollectionGetter<RecordType>> _TriggeringRecordTypes = new Lazy<ICollectionGetter<RecordType>>(() =>
        {
            return new CollectionGetterWrapper<RecordType>(
                new HashSet<RecordType>(
                    new RecordType[]
                    {
                        RecordTypes.LVSP,
                        RecordTypes.SHOU,
                        RecordTypes.SPEL
                    })
            );
        });
        public static readonly Type BinaryWriteTranslation = typeof(ASpellBinaryWriteTranslation);
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
    public partial class ASpellSetterCommon : SkyrimMajorRecordSetterCommon
    {
        public new static readonly ASpellSetterCommon Instance = new ASpellSetterCommon();

        partial void ClearPartial();
        
        public virtual void Clear(IASpellInternal item)
        {
            ClearPartial();
            base.Clear(item);
        }
        
        public override void Clear(ISkyrimMajorRecordInternal item)
        {
            Clear(item: (IASpellInternal)item);
        }
        
        public override void Clear(IMajorRecordInternal item)
        {
            Clear(item: (IASpellInternal)item);
        }
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IASpellInternal item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
        }
        
        public override void CopyInFromBinary(
            ISkyrimMajorRecordInternal item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            CopyInFromBinary(
                item: (ASpell)item,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
        }
        
        public override void CopyInFromBinary(
            IMajorRecordInternal item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            CopyInFromBinary(
                item: (ASpell)item,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
        }
        
        #endregion
        
    }
    public partial class ASpellCommon : SkyrimMajorRecordCommon
    {
        public new static readonly ASpellCommon Instance = new ASpellCommon();

        public ASpell.Mask<bool> GetEqualsMask(
            IASpellGetter item,
            IASpellGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new ASpell.Mask<bool>(false);
            ((ASpellCommon)((IASpellGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IASpellGetter item,
            IASpellGetter rhs,
            ASpell.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string ToString(
            IASpellGetter item,
            string? name = null,
            ASpell.Mask<bool>? printMask = null)
        {
            var fg = new FileGeneration();
            ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
            return fg.ToString();
        }
        
        public void ToString(
            IASpellGetter item,
            FileGeneration fg,
            string? name = null,
            ASpell.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"ASpell =>");
            }
            else
            {
                fg.AppendLine($"{name} (ASpell) =>");
            }
            fg.AppendLine("[");
            using (new DepthWrapper(fg))
            {
                ToStringFields(
                    item: item,
                    fg: fg,
                    printMask: printMask);
            }
            fg.AppendLine("]");
        }
        
        protected static void ToStringFields(
            IASpellGetter item,
            FileGeneration fg,
            ASpell.Mask<bool>? printMask = null)
        {
            SkyrimMajorRecordCommon.ToStringFields(
                item: item,
                fg: fg,
                printMask: printMask);
        }
        
        public static ASpell_FieldIndex ConvertFieldIndex(SkyrimMajorRecord_FieldIndex index)
        {
            switch (index)
            {
                case SkyrimMajorRecord_FieldIndex.MajorRecordFlagsRaw:
                    return (ASpell_FieldIndex)((int)index);
                case SkyrimMajorRecord_FieldIndex.FormKey:
                    return (ASpell_FieldIndex)((int)index);
                case SkyrimMajorRecord_FieldIndex.VersionControl:
                    return (ASpell_FieldIndex)((int)index);
                case SkyrimMajorRecord_FieldIndex.EditorID:
                    return (ASpell_FieldIndex)((int)index);
                case SkyrimMajorRecord_FieldIndex.FormVersion:
                    return (ASpell_FieldIndex)((int)index);
                case SkyrimMajorRecord_FieldIndex.Version2:
                    return (ASpell_FieldIndex)((int)index);
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast_Enum_Only()}");
            }
        }
        
        public static new ASpell_FieldIndex ConvertFieldIndex(MajorRecord_FieldIndex index)
        {
            switch (index)
            {
                case MajorRecord_FieldIndex.MajorRecordFlagsRaw:
                    return (ASpell_FieldIndex)((int)index);
                case MajorRecord_FieldIndex.FormKey:
                    return (ASpell_FieldIndex)((int)index);
                case MajorRecord_FieldIndex.VersionControl:
                    return (ASpell_FieldIndex)((int)index);
                case MajorRecord_FieldIndex.EditorID:
                    return (ASpell_FieldIndex)((int)index);
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast_Enum_Only()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IASpellGetter? lhs,
            IASpellGetter? rhs)
        {
            if (lhs == null && rhs == null) return false;
            if (lhs == null || rhs == null) return false;
            if (!base.Equals((ISkyrimMajorRecordGetter)lhs, (ISkyrimMajorRecordGetter)rhs)) return false;
            return true;
        }
        
        public override bool Equals(
            ISkyrimMajorRecordGetter? lhs,
            ISkyrimMajorRecordGetter? rhs)
        {
            return Equals(
                lhs: (IASpellGetter?)lhs,
                rhs: rhs as IASpellGetter);
        }
        
        public override bool Equals(
            IMajorRecordGetter? lhs,
            IMajorRecordGetter? rhs)
        {
            return Equals(
                lhs: (IASpellGetter?)lhs,
                rhs: rhs as IASpellGetter);
        }
        
        public virtual int GetHashCode(IASpellGetter item)
        {
            var hash = new HashCode();
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(ISkyrimMajorRecordGetter item)
        {
            return GetHashCode(item: (IASpellGetter)item);
        }
        
        public override int GetHashCode(IMajorRecordGetter item)
        {
            return GetHashCode(item: (IASpellGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return ASpell.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<FormKey> GetLinkFormKeys(IASpellGetter obj)
        {
            foreach (var item in base.GetLinkFormKeys(obj))
            {
                yield return item;
            }
            yield break;
        }
        
        public void RemapLinks(IASpellGetter obj, IReadOnlyDictionary<FormKey, FormKey> mapping) => throw new NotImplementedException();
        partial void PostDuplicate(ASpell obj, ASpell rhs, Func<FormKey> getNextFormKey, IList<(IMajorRecordCommon Record, FormKey OriginalFormKey)>? duplicatedRecords);
        
        public override IMajorRecordCommon Duplicate(IMajorRecordCommonGetter item, Func<FormKey> getNextFormKey, IList<(IMajorRecordCommon Record, FormKey OriginalFormKey)>? duplicatedRecords)
        {
            throw new NotImplementedException();
        }
        
        #endregion
        
    }
    public partial class ASpellSetterTranslationCommon : SkyrimMajorRecordSetterTranslationCommon
    {
        public new static readonly ASpellSetterTranslationCommon Instance = new ASpellSetterTranslationCommon();

        #region DeepCopyIn
        public virtual void DeepCopyIn(
            IASpellInternal item,
            IASpellGetter rhs,
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
        
        public virtual void DeepCopyIn(
            IASpell item,
            IASpellGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (ISkyrimMajorRecord)item,
                (ISkyrimMajorRecordGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
        }
        
        public override void DeepCopyIn(
            ISkyrimMajorRecordInternal item,
            ISkyrimMajorRecordGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IASpellInternal)item,
                rhs: (IASpellGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        public override void DeepCopyIn(
            ISkyrimMajorRecord item,
            ISkyrimMajorRecordGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IASpell)item,
                rhs: (IASpellGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        public override void DeepCopyIn(
            IMajorRecordInternal item,
            IMajorRecordGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IASpellInternal)item,
                rhs: (IASpellGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        public override void DeepCopyIn(
            IMajorRecord item,
            IMajorRecordGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IASpell)item,
                rhs: (IASpellGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public ASpell DeepCopy(
            IASpellGetter item,
            ASpell.TranslationMask? copyMask = null)
        {
            ASpell ret = (ASpell)((ASpellCommon)((IASpellGetter)item).CommonInstance()!).GetNew();
            ((ASpellSetterTranslationCommon)((IASpellGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public ASpell DeepCopy(
            IASpellGetter item,
            out ASpell.ErrorMask errorMask,
            ASpell.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ASpell ret = (ASpell)((ASpellCommon)((IASpellGetter)item).CommonInstance()!).GetNew();
            ((ASpellSetterTranslationCommon)((IASpellGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = ASpell.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public ASpell DeepCopy(
            IASpellGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            ASpell ret = (ASpell)((ASpellCommon)((IASpellGetter)item).CommonInstance()!).GetNew();
            ((ASpellSetterTranslationCommon)((IASpellGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class ASpell
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => ASpell_Registration.Instance;
        public new static ASpell_Registration Registration => ASpell_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => ASpellCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return ASpellSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => ASpellSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class ASpellBinaryWriteTranslation :
        SkyrimMajorRecordBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new readonly static ASpellBinaryWriteTranslation Instance = new ASpellBinaryWriteTranslation();

        public virtual void Write(
            MutagenWriter writer,
            IASpellGetter item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            SkyrimMajorRecordBinaryWriteTranslation.WriteEmbedded(
                item: item,
                writer: writer);
            MajorRecordBinaryWriteTranslation.WriteRecordTypes(
                item: item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

        public override void Write(
            MutagenWriter writer,
            object item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            Write(
                item: (IASpellGetter)item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

        public override void Write(
            MutagenWriter writer,
            ISkyrimMajorRecordGetter item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            Write(
                item: (IASpellGetter)item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

        public override void Write(
            MutagenWriter writer,
            IMajorRecordGetter item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            Write(
                item: (IASpellGetter)item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }

    public partial class ASpellBinaryCreateTranslation : SkyrimMajorRecordBinaryCreateTranslation
    {
        public new readonly static ASpellBinaryCreateTranslation Instance = new ASpellBinaryCreateTranslation();

        public override RecordType RecordType => throw new ArgumentException();
    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class ASpellBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class ASpellBinaryOverlay :
        SkyrimMajorRecordBinaryOverlay,
        IASpellGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => ASpell_Registration.Instance;
        public new static ASpell_Registration Registration => ASpell_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => ASpellCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => ASpellSetterTranslationCommon.Instance;

        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override IEnumerable<FormKey> LinkFormKeys => ASpellCommon.Instance.GetLinkFormKeys(this);
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IEnumerable<FormKey> ILinkedFormKeyContainerGetter.LinkFormKeys => ASpellCommon.Instance.GetLinkFormKeys(this);
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => ASpellBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((ASpellBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected ASpellBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }


        #region To String

        public override void ToString(
            FileGeneration fg,
            string? name = null)
        {
            ASpellMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (!(obj is IASpellGetter rhs)) return false;
            return ((ASpellCommon)((IASpellGetter)this).CommonInstance()!).Equals(this, rhs);
        }

        public bool Equals(IASpellGetter? obj)
        {
            return ((ASpellCommon)((IASpellGetter)this).CommonInstance()!).Equals(this, obj);
        }

        public override int GetHashCode() => ((ASpellCommon)((IASpellGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

