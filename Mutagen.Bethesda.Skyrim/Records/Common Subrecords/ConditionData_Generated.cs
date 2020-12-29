/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
#region Usings
using Loqui;
using Loqui.Internal;
using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Internals;
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
    /// <summary>
    /// Implemented by: [FunctionConditionData, GetEventData]
    /// </summary>
    public abstract partial class ConditionData :
        IConditionData,
        ILoquiObjectSetter<ConditionData>,
        IEquatable<IConditionDataGetter>
    {
        #region Ctor
        public ConditionData()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion


        #region To String

        public virtual void ToString(
            FileGeneration fg,
            string? name = null)
        {
            ConditionDataMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (!(obj is IConditionDataGetter rhs)) return false;
            return ((ConditionDataCommon)((IConditionDataGetter)this).CommonInstance()!).Equals(this, rhs);
        }

        public bool Equals(IConditionDataGetter? obj)
        {
            return ((ConditionDataCommon)((IConditionDataGetter)this).CommonInstance()!).Equals(this, obj);
        }

        public override int GetHashCode() => ((ConditionDataCommon)((IConditionDataGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public class Mask<TItem> :
            IMask<TItem>,
            IEquatable<Mask<TItem>>
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
                var ret = new ConditionData.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
            }
            #endregion

            #region To String
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(ConditionData.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, ConditionData.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(ConditionData.Mask<TItem>)} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                }
                fg.AppendLine("]");
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
                ConditionData_FieldIndex enu = (ConditionData_FieldIndex)index;
                switch (enu)
                {
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public virtual void SetNthException(int index, Exception ex)
            {
                ConditionData_FieldIndex enu = (ConditionData_FieldIndex)index;
                switch (enu)
                {
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public virtual void SetNthMask(int index, object obj)
            {
                ConditionData_FieldIndex enu = (ConditionData_FieldIndex)index;
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
            public override string ToString()
            {
                var fg = new FileGeneration();
                ToString(fg, null);
                return fg.ToString();
            }

            public virtual void ToString(FileGeneration fg, string? name = null)
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
            protected virtual void ToString_FillInternal(FileGeneration fg)
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
        public virtual IEnumerable<FormLinkInformation> ContainedFormLinks => ConditionDataCommon.Instance.GetContainedFormLinks(this);
        public virtual void RemapLinks(IReadOnlyDictionary<FormKey, FormKey> mapping) => ConditionDataSetterCommon.Instance.RemapLinks(this, mapping);
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected virtual object BinaryWriteTranslator => ConditionDataBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((ConditionDataBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }
        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        void IClearable.Clear()
        {
            ((ConditionDataSetterCommon)((IConditionDataGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static ConditionData GetNew()
        {
            throw new ArgumentException("New called on an abstract class.");
        }

    }
    #endregion

    #region Interface
    /// <summary>
    /// Implemented by: [FunctionConditionData, GetEventData]
    /// </summary>
    public partial interface IConditionData :
        IConditionDataGetter,
        ILoquiObjectSetter<IConditionData>,
        IFormLinkContainer
    {
    }

    /// <summary>
    /// Implemented by: [FunctionConditionData, GetEventData]
    /// </summary>
    public partial interface IConditionDataGetter :
        ILoquiObject,
        ILoquiObject<IConditionDataGetter>,
        IFormLinkContainerGetter,
        IBinaryItem
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object? CommonSetterInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonSetterTranslationInstance();
        static ILoquiRegistration Registration => ConditionData_Registration.Instance;

    }

    #endregion

    #region Common MixIn
    public static partial class ConditionDataMixIn
    {
        public static void Clear(this IConditionData item)
        {
            ((ConditionDataSetterCommon)((IConditionDataGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static ConditionData.Mask<bool> GetEqualsMask(
            this IConditionDataGetter item,
            IConditionDataGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((ConditionDataCommon)((IConditionDataGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this IConditionDataGetter item,
            string? name = null,
            ConditionData.Mask<bool>? printMask = null)
        {
            return ((ConditionDataCommon)((IConditionDataGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this IConditionDataGetter item,
            FileGeneration fg,
            string? name = null,
            ConditionData.Mask<bool>? printMask = null)
        {
            ((ConditionDataCommon)((IConditionDataGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IConditionDataGetter item,
            IConditionDataGetter rhs)
        {
            return ((ConditionDataCommon)((IConditionDataGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs);
        }

        public static void DeepCopyIn(
            this IConditionData lhs,
            IConditionDataGetter rhs)
        {
            ((ConditionDataSetterTranslationCommon)((IConditionDataGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: default,
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IConditionData lhs,
            IConditionDataGetter rhs,
            ConditionData.TranslationMask? copyMask = null)
        {
            ((ConditionDataSetterTranslationCommon)((IConditionDataGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IConditionData lhs,
            IConditionDataGetter rhs,
            out ConditionData.ErrorMask errorMask,
            ConditionData.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((ConditionDataSetterTranslationCommon)((IConditionDataGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = ConditionData.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IConditionData lhs,
            IConditionDataGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((ConditionDataSetterTranslationCommon)((IConditionDataGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static ConditionData DeepCopy(
            this IConditionDataGetter item,
            ConditionData.TranslationMask? copyMask = null)
        {
            return ((ConditionDataSetterTranslationCommon)((IConditionDataGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static ConditionData DeepCopy(
            this IConditionDataGetter item,
            out ConditionData.ErrorMask errorMask,
            ConditionData.TranslationMask? copyMask = null)
        {
            return ((ConditionDataSetterTranslationCommon)((IConditionDataGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static ConditionData DeepCopy(
            this IConditionDataGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((ConditionDataSetterTranslationCommon)((IConditionDataGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IConditionData item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((ConditionDataSetterCommon)((IConditionDataGetter)item).CommonSetterInstance()!).CopyInFromBinary(
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
    public enum ConditionData_FieldIndex
    {
    }
    #endregion

    #region Registration
    public partial class ConditionData_Registration : ILoquiRegistration
    {
        public static readonly ConditionData_Registration Instance = new ConditionData_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Skyrim.ProtocolKey,
            msgID: 41,
            version: 0);

        public const string GUID = "01abc3c5-fb9d-4e48-a375-fe2f3a4fa044";

        public const ushort AdditionalFieldCount = 0;

        public const ushort FieldCount = 0;

        public static readonly Type MaskType = typeof(ConditionData.Mask<>);

        public static readonly Type ErrorMaskType = typeof(ConditionData.ErrorMask);

        public static readonly Type ClassType = typeof(ConditionData);

        public static readonly Type GetterType = typeof(IConditionDataGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IConditionData);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Skyrim.ConditionData";

        public const string Name = "ConditionData";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(ConditionDataBinaryWriteTranslation);
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
    public partial class ConditionDataSetterCommon
    {
        public static readonly ConditionDataSetterCommon Instance = new ConditionDataSetterCommon();

        partial void ClearPartial();
        
        public virtual void Clear(IConditionData item)
        {
            ClearPartial();
        }
        
        #region Mutagen
        public void RemapLinks(IConditionData obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IConditionData item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
        }
        
        #endregion
        
    }
    public partial class ConditionDataCommon
    {
        public static readonly ConditionDataCommon Instance = new ConditionDataCommon();

        public ConditionData.Mask<bool> GetEqualsMask(
            IConditionDataGetter item,
            IConditionDataGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new ConditionData.Mask<bool>(false);
            ((ConditionDataCommon)((IConditionDataGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IConditionDataGetter item,
            IConditionDataGetter rhs,
            ConditionData.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
        }
        
        public string ToString(
            IConditionDataGetter item,
            string? name = null,
            ConditionData.Mask<bool>? printMask = null)
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
            IConditionDataGetter item,
            FileGeneration fg,
            string? name = null,
            ConditionData.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"ConditionData =>");
            }
            else
            {
                fg.AppendLine($"{name} (ConditionData) =>");
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
            IConditionDataGetter item,
            FileGeneration fg,
            ConditionData.Mask<bool>? printMask = null)
        {
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IConditionDataGetter? lhs,
            IConditionDataGetter? rhs)
        {
            if (lhs == null && rhs == null) return false;
            if (lhs == null || rhs == null) return false;
            return true;
        }
        
        public virtual int GetHashCode(IConditionDataGetter item)
        {
            var hash = new HashCode();
            return hash.ToHashCode();
        }
        
        #endregion
        
        
        public virtual object GetNew()
        {
            return ConditionData.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<FormLinkInformation> GetContainedFormLinks(IConditionDataGetter obj)
        {
            yield break;
        }
        
        #endregion
        
    }
    public partial class ConditionDataSetterTranslationCommon
    {
        public static readonly ConditionDataSetterTranslationCommon Instance = new ConditionDataSetterTranslationCommon();

        #region DeepCopyIn
        public virtual void DeepCopyIn(
            IConditionData item,
            IConditionDataGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
        }
        
        #endregion
        
        public ConditionData DeepCopy(
            IConditionDataGetter item,
            ConditionData.TranslationMask? copyMask = null)
        {
            ConditionData ret = (ConditionData)((ConditionDataCommon)((IConditionDataGetter)item).CommonInstance()!).GetNew();
            ((ConditionDataSetterTranslationCommon)((IConditionDataGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public ConditionData DeepCopy(
            IConditionDataGetter item,
            out ConditionData.ErrorMask errorMask,
            ConditionData.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ConditionData ret = (ConditionData)((ConditionDataCommon)((IConditionDataGetter)item).CommonInstance()!).GetNew();
            ((ConditionDataSetterTranslationCommon)((IConditionDataGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = ConditionData.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public ConditionData DeepCopy(
            IConditionDataGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            ConditionData ret = (ConditionData)((ConditionDataCommon)((IConditionDataGetter)item).CommonInstance()!).GetNew();
            ((ConditionDataSetterTranslationCommon)((IConditionDataGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class ConditionData
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => ConditionData_Registration.Instance;
        public static ConditionData_Registration Registration => ConditionData_Registration.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonInstance() => ConditionDataCommon.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonSetterInstance()
        {
            return ConditionDataSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected virtual object CommonSetterTranslationInstance() => ConditionDataSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IConditionDataGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object IConditionDataGetter.CommonSetterInstance() => this.CommonSetterInstance();
        [DebuggerStepThrough]
        object IConditionDataGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class ConditionDataBinaryWriteTranslation : IBinaryWriteTranslator
    {
        public readonly static ConditionDataBinaryWriteTranslation Instance = new ConditionDataBinaryWriteTranslation();

        public virtual void Write(
            MutagenWriter writer,
            IConditionDataGetter item,
            RecordTypeConverter? recordTypeConverter = null)
        {
        }

        public virtual void Write(
            MutagenWriter writer,
            object item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            Write(
                item: (IConditionDataGetter)item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }

    public partial class ConditionDataBinaryCreateTranslation
    {
        public readonly static ConditionDataBinaryCreateTranslation Instance = new ConditionDataBinaryCreateTranslation();

    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class ConditionDataBinaryTranslationMixIn
    {
        public static void WriteToBinary(
            this IConditionDataGetter item,
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((ConditionDataBinaryWriteTranslation)item.BinaryWriteTranslator).Write(
                item: item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class ConditionDataBinaryOverlay :
        BinaryOverlay,
        IConditionDataGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => ConditionData_Registration.Instance;
        public static ConditionData_Registration Registration => ConditionData_Registration.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonInstance() => ConditionDataCommon.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonSetterTranslationInstance() => ConditionDataSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IConditionDataGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object? IConditionDataGetter.CommonSetterInstance() => null;
        [DebuggerStepThrough]
        object IConditionDataGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        public virtual IEnumerable<FormLinkInformation> ContainedFormLinks => ConditionDataCommon.Instance.GetContainedFormLinks(this);
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected virtual object BinaryWriteTranslator => ConditionDataBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((ConditionDataBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected ConditionDataBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }


        #region To String

        public virtual void ToString(
            FileGeneration fg,
            string? name = null)
        {
            ConditionDataMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (!(obj is IConditionDataGetter rhs)) return false;
            return ((ConditionDataCommon)((IConditionDataGetter)this).CommonInstance()!).Equals(this, rhs);
        }

        public bool Equals(IConditionDataGetter? obj)
        {
            return ((ConditionDataCommon)((IConditionDataGetter)this).CommonInstance()!).Equals(this, obj);
        }

        public override int GetHashCode() => ((ConditionDataCommon)((IConditionDataGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

