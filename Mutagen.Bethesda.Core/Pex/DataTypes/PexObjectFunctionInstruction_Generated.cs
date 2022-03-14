/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
#region Usings
using Loqui;
using Loqui.Internal;
using Mutagen.Bethesda.Pex;
using Mutagen.Bethesda.Pex.Internals;
using Noggog;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Pex
{
    #region Class
    public partial class PexObjectFunctionInstruction :
        IEquatable<IPexObjectFunctionInstructionGetter>,
        ILoquiObjectSetter<PexObjectFunctionInstruction>,
        IPexObjectFunctionInstruction
    {
        #region Ctor
        public PexObjectFunctionInstruction()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region OpCode
        public InstructionOpcode OpCode { get; set; } = default;
        #endregion
        #region Arguments
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ExtendedList<PexObjectVariableData> _Arguments = new ExtendedList<PexObjectVariableData>();
        public ExtendedList<PexObjectVariableData> Arguments
        {
            get => this._Arguments;
            init => this._Arguments = value;
        }
        #region Interface Members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IReadOnlyList<IPexObjectVariableDataGetter> IPexObjectFunctionInstructionGetter.Arguments => _Arguments;
        #endregion

        #endregion

        #region To String

        public void ToString(
            FileGeneration fg,
            string? name = null)
        {
            PexObjectFunctionInstructionMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IPexObjectFunctionInstructionGetter rhs) return false;
            return ((PexObjectFunctionInstructionCommon)((IPexObjectFunctionInstructionGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IPexObjectFunctionInstructionGetter? obj)
        {
            return ((PexObjectFunctionInstructionCommon)((IPexObjectFunctionInstructionGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((PexObjectFunctionInstructionCommon)((IPexObjectFunctionInstructionGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public class Mask<TItem> :
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            {
                this.OpCode = initialValue;
                this.Arguments = new MaskItem<TItem, IEnumerable<MaskItemIndexed<TItem, PexObjectVariableData.Mask<TItem>?>>?>(initialValue, Enumerable.Empty<MaskItemIndexed<TItem, PexObjectVariableData.Mask<TItem>?>>());
            }

            public Mask(
                TItem OpCode,
                TItem Arguments)
            {
                this.OpCode = OpCode;
                this.Arguments = new MaskItem<TItem, IEnumerable<MaskItemIndexed<TItem, PexObjectVariableData.Mask<TItem>?>>?>(Arguments, Enumerable.Empty<MaskItemIndexed<TItem, PexObjectVariableData.Mask<TItem>?>>());
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem OpCode;
            public MaskItem<TItem, IEnumerable<MaskItemIndexed<TItem, PexObjectVariableData.Mask<TItem>?>>?>? Arguments;
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
                if (!object.Equals(this.OpCode, rhs.OpCode)) return false;
                if (!object.Equals(this.Arguments, rhs.Arguments)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.OpCode);
                hash.Add(this.Arguments);
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public bool All(Func<TItem, bool> eval)
            {
                if (!eval(this.OpCode)) return false;
                if (this.Arguments != null)
                {
                    if (!eval(this.Arguments.Overall)) return false;
                    if (this.Arguments.Specific != null)
                    {
                        foreach (var item in this.Arguments.Specific)
                        {
                            if (!eval(item.Overall)) return false;
                            if (item.Specific != null && !item.Specific.All(eval)) return false;
                        }
                    }
                }
                return true;
            }
            #endregion

            #region Any
            public bool Any(Func<TItem, bool> eval)
            {
                if (eval(this.OpCode)) return true;
                if (this.Arguments != null)
                {
                    if (eval(this.Arguments.Overall)) return true;
                    if (this.Arguments.Specific != null)
                    {
                        foreach (var item in this.Arguments.Specific)
                        {
                            if (!eval(item.Overall)) return false;
                            if (item.Specific != null && !item.Specific.All(eval)) return false;
                        }
                    }
                }
                return false;
            }
            #endregion

            #region Translate
            public Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new PexObjectFunctionInstruction.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                obj.OpCode = eval(this.OpCode);
                if (Arguments != null)
                {
                    obj.Arguments = new MaskItem<R, IEnumerable<MaskItemIndexed<R, PexObjectVariableData.Mask<R>?>>?>(eval(this.Arguments.Overall), Enumerable.Empty<MaskItemIndexed<R, PexObjectVariableData.Mask<R>?>>());
                    if (Arguments.Specific != null)
                    {
                        var l = new List<MaskItemIndexed<R, PexObjectVariableData.Mask<R>?>>();
                        obj.Arguments.Specific = l;
                        foreach (var item in Arguments.Specific)
                        {
                            MaskItemIndexed<R, PexObjectVariableData.Mask<R>?>? mask = item == null ? null : new MaskItemIndexed<R, PexObjectVariableData.Mask<R>?>(item.Index, eval(item.Overall), item.Specific?.Translate(eval));
                            if (mask == null) continue;
                            l.Add(mask);
                        }
                    }
                }
            }
            #endregion

            #region To String
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(PexObjectFunctionInstruction.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, PexObjectFunctionInstruction.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(PexObjectFunctionInstruction.Mask<TItem>)} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    if (printMask?.OpCode ?? true)
                    {
                        fg.AppendItem(OpCode, "OpCode");
                    }
                    if ((printMask?.Arguments?.Overall ?? true)
                        && Arguments is {} ArgumentsItem)
                    {
                        fg.AppendLine("Arguments =>");
                        fg.AppendLine("[");
                        using (new DepthWrapper(fg))
                        {
                            fg.AppendItem(ArgumentsItem.Overall);
                            if (ArgumentsItem.Specific != null)
                            {
                                foreach (var subItem in ArgumentsItem.Specific)
                                {
                                    fg.AppendLine("[");
                                    using (new DepthWrapper(fg))
                                    {
                                        subItem?.ToString(fg);
                                    }
                                    fg.AppendLine("]");
                                }
                            }
                        }
                        fg.AppendLine("]");
                    }
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
            public Exception? OpCode;
            public MaskItem<Exception?, IEnumerable<MaskItem<Exception?, PexObjectVariableData.ErrorMask?>>?>? Arguments;
            #endregion

            #region IErrorMask
            public object? GetNthMask(int index)
            {
                PexObjectFunctionInstruction_FieldIndex enu = (PexObjectFunctionInstruction_FieldIndex)index;
                switch (enu)
                {
                    case PexObjectFunctionInstruction_FieldIndex.OpCode:
                        return OpCode;
                    case PexObjectFunctionInstruction_FieldIndex.Arguments:
                        return Arguments;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthException(int index, Exception ex)
            {
                PexObjectFunctionInstruction_FieldIndex enu = (PexObjectFunctionInstruction_FieldIndex)index;
                switch (enu)
                {
                    case PexObjectFunctionInstruction_FieldIndex.OpCode:
                        this.OpCode = ex;
                        break;
                    case PexObjectFunctionInstruction_FieldIndex.Arguments:
                        this.Arguments = new MaskItem<Exception?, IEnumerable<MaskItem<Exception?, PexObjectVariableData.ErrorMask?>>?>(ex, null);
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthMask(int index, object obj)
            {
                PexObjectFunctionInstruction_FieldIndex enu = (PexObjectFunctionInstruction_FieldIndex)index;
                switch (enu)
                {
                    case PexObjectFunctionInstruction_FieldIndex.OpCode:
                        this.OpCode = (Exception?)obj;
                        break;
                    case PexObjectFunctionInstruction_FieldIndex.Arguments:
                        this.Arguments = (MaskItem<Exception?, IEnumerable<MaskItem<Exception?, PexObjectVariableData.ErrorMask?>>?>)obj;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public bool IsInError()
            {
                if (Overall != null) return true;
                if (OpCode != null) return true;
                if (Arguments != null) return true;
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

            public void ToString(FileGeneration fg, string? name = null)
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
            protected void ToString_FillInternal(FileGeneration fg)
            {
                fg.AppendItem(OpCode, "OpCode");
                if (Arguments is {} ArgumentsItem)
                {
                    fg.AppendLine("Arguments =>");
                    fg.AppendLine("[");
                    using (new DepthWrapper(fg))
                    {
                        fg.AppendItem(ArgumentsItem.Overall);
                        if (ArgumentsItem.Specific != null)
                        {
                            foreach (var subItem in ArgumentsItem.Specific)
                            {
                                fg.AppendLine("[");
                                using (new DepthWrapper(fg))
                                {
                                    subItem?.ToString(fg);
                                }
                                fg.AppendLine("]");
                            }
                        }
                    }
                    fg.AppendLine("]");
                }
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.OpCode = this.OpCode.Combine(rhs.OpCode);
                ret.Arguments = new MaskItem<Exception?, IEnumerable<MaskItem<Exception?, PexObjectVariableData.ErrorMask?>>?>(ExceptionExt.Combine(this.Arguments?.Overall, rhs.Arguments?.Overall), ExceptionExt.Combine(this.Arguments?.Specific, rhs.Arguments?.Specific));
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
            public bool OpCode;
            public PexObjectVariableData.TranslationMask? Arguments;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
            {
                this.DefaultOn = defaultOn;
                this.OnOverall = onOverall;
                this.OpCode = defaultOn;
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
                ret.Add((OpCode, null));
                ret.Add((Arguments == null ? DefaultOn : !Arguments.GetCrystal().CopyNothing, Arguments?.GetCrystal()));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        void IClearable.Clear()
        {
            ((PexObjectFunctionInstructionSetterCommon)((IPexObjectFunctionInstructionGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static PexObjectFunctionInstruction GetNew()
        {
            return new PexObjectFunctionInstruction();
        }

    }
    #endregion

    #region Interface
    public partial interface IPexObjectFunctionInstruction :
        ILoquiObjectSetter<IPexObjectFunctionInstruction>,
        IPexObjectFunctionInstructionGetter
    {
        new InstructionOpcode OpCode { get; set; }
        new ExtendedList<PexObjectVariableData> Arguments { get; }
    }

    public partial interface IPexObjectFunctionInstructionGetter :
        ILoquiObject,
        ILoquiObject<IPexObjectFunctionInstructionGetter>
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object? CommonSetterInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonSetterTranslationInstance();
        static ILoquiRegistration StaticRegistration => PexObjectFunctionInstruction_Registration.Instance;
        InstructionOpcode OpCode { get; }
        IReadOnlyList<IPexObjectVariableDataGetter> Arguments { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class PexObjectFunctionInstructionMixIn
    {
        public static void Clear(this IPexObjectFunctionInstruction item)
        {
            ((PexObjectFunctionInstructionSetterCommon)((IPexObjectFunctionInstructionGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static PexObjectFunctionInstruction.Mask<bool> GetEqualsMask(
            this IPexObjectFunctionInstructionGetter item,
            IPexObjectFunctionInstructionGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((PexObjectFunctionInstructionCommon)((IPexObjectFunctionInstructionGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this IPexObjectFunctionInstructionGetter item,
            string? name = null,
            PexObjectFunctionInstruction.Mask<bool>? printMask = null)
        {
            return ((PexObjectFunctionInstructionCommon)((IPexObjectFunctionInstructionGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this IPexObjectFunctionInstructionGetter item,
            FileGeneration fg,
            string? name = null,
            PexObjectFunctionInstruction.Mask<bool>? printMask = null)
        {
            ((PexObjectFunctionInstructionCommon)((IPexObjectFunctionInstructionGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IPexObjectFunctionInstructionGetter item,
            IPexObjectFunctionInstructionGetter rhs,
            PexObjectFunctionInstruction.TranslationMask? equalsMask = null)
        {
            return ((PexObjectFunctionInstructionCommon)((IPexObjectFunctionInstructionGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IPexObjectFunctionInstruction lhs,
            IPexObjectFunctionInstructionGetter rhs)
        {
            ((PexObjectFunctionInstructionSetterTranslationCommon)((IPexObjectFunctionInstructionGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: default,
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IPexObjectFunctionInstruction lhs,
            IPexObjectFunctionInstructionGetter rhs,
            PexObjectFunctionInstruction.TranslationMask? copyMask = null)
        {
            ((PexObjectFunctionInstructionSetterTranslationCommon)((IPexObjectFunctionInstructionGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IPexObjectFunctionInstruction lhs,
            IPexObjectFunctionInstructionGetter rhs,
            out PexObjectFunctionInstruction.ErrorMask errorMask,
            PexObjectFunctionInstruction.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((PexObjectFunctionInstructionSetterTranslationCommon)((IPexObjectFunctionInstructionGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = PexObjectFunctionInstruction.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IPexObjectFunctionInstruction lhs,
            IPexObjectFunctionInstructionGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((PexObjectFunctionInstructionSetterTranslationCommon)((IPexObjectFunctionInstructionGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static PexObjectFunctionInstruction DeepCopy(
            this IPexObjectFunctionInstructionGetter item,
            PexObjectFunctionInstruction.TranslationMask? copyMask = null)
        {
            return ((PexObjectFunctionInstructionSetterTranslationCommon)((IPexObjectFunctionInstructionGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static PexObjectFunctionInstruction DeepCopy(
            this IPexObjectFunctionInstructionGetter item,
            out PexObjectFunctionInstruction.ErrorMask errorMask,
            PexObjectFunctionInstruction.TranslationMask? copyMask = null)
        {
            return ((PexObjectFunctionInstructionSetterTranslationCommon)((IPexObjectFunctionInstructionGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static PexObjectFunctionInstruction DeepCopy(
            this IPexObjectFunctionInstructionGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((PexObjectFunctionInstructionSetterTranslationCommon)((IPexObjectFunctionInstructionGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

    }
    #endregion

}

namespace Mutagen.Bethesda.Pex.Internals
{
    #region Field Index
    public enum PexObjectFunctionInstruction_FieldIndex
    {
        OpCode = 0,
        Arguments = 1,
    }
    #endregion

    #region Registration
    public partial class PexObjectFunctionInstruction_Registration : ILoquiRegistration
    {
        public static readonly PexObjectFunctionInstruction_Registration Instance = new PexObjectFunctionInstruction_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Pex.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Pex.ProtocolKey,
            msgID: 16,
            version: 0);

        public const string GUID = "c72c53ef-3e02-4cdb-81c0-81f8ad2d19b4";

        public const ushort AdditionalFieldCount = 2;

        public const ushort FieldCount = 2;

        public static readonly Type MaskType = typeof(PexObjectFunctionInstruction.Mask<>);

        public static readonly Type ErrorMaskType = typeof(PexObjectFunctionInstruction.ErrorMask);

        public static readonly Type ClassType = typeof(PexObjectFunctionInstruction);

        public static readonly Type GetterType = typeof(IPexObjectFunctionInstructionGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IPexObjectFunctionInstruction);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Pex.PexObjectFunctionInstruction";

        public const string Name = "PexObjectFunctionInstruction";

        public const string Namespace = "Mutagen.Bethesda.Pex";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

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
    public partial class PexObjectFunctionInstructionSetterCommon
    {
        public static readonly PexObjectFunctionInstructionSetterCommon Instance = new PexObjectFunctionInstructionSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IPexObjectFunctionInstruction item)
        {
            ClearPartial();
            item.OpCode = default;
            item.Arguments.Clear();
        }
        
    }
    public partial class PexObjectFunctionInstructionCommon
    {
        public static readonly PexObjectFunctionInstructionCommon Instance = new PexObjectFunctionInstructionCommon();

        public PexObjectFunctionInstruction.Mask<bool> GetEqualsMask(
            IPexObjectFunctionInstructionGetter item,
            IPexObjectFunctionInstructionGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new PexObjectFunctionInstruction.Mask<bool>(false);
            ((PexObjectFunctionInstructionCommon)((IPexObjectFunctionInstructionGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IPexObjectFunctionInstructionGetter item,
            IPexObjectFunctionInstructionGetter rhs,
            PexObjectFunctionInstruction.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            ret.OpCode = item.OpCode == rhs.OpCode;
            ret.Arguments = item.Arguments.CollectionEqualsHelper(
                rhs.Arguments,
                (loqLhs, loqRhs) => loqLhs.GetEqualsMask(loqRhs, include),
                include);
        }
        
        public string ToString(
            IPexObjectFunctionInstructionGetter item,
            string? name = null,
            PexObjectFunctionInstruction.Mask<bool>? printMask = null)
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
            IPexObjectFunctionInstructionGetter item,
            FileGeneration fg,
            string? name = null,
            PexObjectFunctionInstruction.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"PexObjectFunctionInstruction =>");
            }
            else
            {
                fg.AppendLine($"{name} (PexObjectFunctionInstruction) =>");
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
            IPexObjectFunctionInstructionGetter item,
            FileGeneration fg,
            PexObjectFunctionInstruction.Mask<bool>? printMask = null)
        {
            if (printMask?.OpCode ?? true)
            {
                fg.AppendItem(item.OpCode, "OpCode");
            }
            if (printMask?.Arguments?.Overall ?? true)
            {
                fg.AppendLine("Arguments =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    foreach (var subItem in item.Arguments)
                    {
                        fg.AppendLine("[");
                        using (new DepthWrapper(fg))
                        {
                            subItem?.ToString(fg, "Item");
                        }
                        fg.AppendLine("]");
                    }
                }
                fg.AppendLine("]");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IPexObjectFunctionInstructionGetter? lhs,
            IPexObjectFunctionInstructionGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if ((crystal?.GetShouldTranslate((int)PexObjectFunctionInstruction_FieldIndex.OpCode) ?? true))
            {
                if (lhs.OpCode != rhs.OpCode) return false;
            }
            if ((crystal?.GetShouldTranslate((int)PexObjectFunctionInstruction_FieldIndex.Arguments) ?? true))
            {
                if (!lhs.Arguments.SequenceEqualNullable(rhs.Arguments)) return false;
            }
            return true;
        }
        
        public virtual int GetHashCode(IPexObjectFunctionInstructionGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.OpCode);
            hash.Add(item.Arguments);
            return hash.ToHashCode();
        }
        
        #endregion
        
        
        public object GetNew()
        {
            return PexObjectFunctionInstruction.GetNew();
        }
        
    }
    public partial class PexObjectFunctionInstructionSetterTranslationCommon
    {
        public static readonly PexObjectFunctionInstructionSetterTranslationCommon Instance = new PexObjectFunctionInstructionSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IPexObjectFunctionInstruction item,
            IPexObjectFunctionInstructionGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            if ((copyMask?.GetShouldTranslate((int)PexObjectFunctionInstruction_FieldIndex.OpCode) ?? true))
            {
                item.OpCode = rhs.OpCode;
            }
            if ((copyMask?.GetShouldTranslate((int)PexObjectFunctionInstruction_FieldIndex.Arguments) ?? true))
            {
                errorMask?.PushIndex((int)PexObjectFunctionInstruction_FieldIndex.Arguments);
                try
                {
                    item.Arguments.SetTo(
                        rhs.Arguments
                        .Select(r =>
                        {
                            return r.DeepCopy(
                                errorMask: errorMask,
                                default(TranslationCrystal));
                        }));
                }
                catch (Exception ex)
                when (errorMask != null)
                {
                    errorMask.ReportException(ex);
                }
                finally
                {
                    errorMask?.PopIndex();
                }
            }
        }
        
        #endregion
        
        public PexObjectFunctionInstruction DeepCopy(
            IPexObjectFunctionInstructionGetter item,
            PexObjectFunctionInstruction.TranslationMask? copyMask = null)
        {
            PexObjectFunctionInstruction ret = (PexObjectFunctionInstruction)((PexObjectFunctionInstructionCommon)((IPexObjectFunctionInstructionGetter)item).CommonInstance()!).GetNew();
            ((PexObjectFunctionInstructionSetterTranslationCommon)((IPexObjectFunctionInstructionGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public PexObjectFunctionInstruction DeepCopy(
            IPexObjectFunctionInstructionGetter item,
            out PexObjectFunctionInstruction.ErrorMask errorMask,
            PexObjectFunctionInstruction.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            PexObjectFunctionInstruction ret = (PexObjectFunctionInstruction)((PexObjectFunctionInstructionCommon)((IPexObjectFunctionInstructionGetter)item).CommonInstance()!).GetNew();
            ((PexObjectFunctionInstructionSetterTranslationCommon)((IPexObjectFunctionInstructionGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = PexObjectFunctionInstruction.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public PexObjectFunctionInstruction DeepCopy(
            IPexObjectFunctionInstructionGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            PexObjectFunctionInstruction ret = (PexObjectFunctionInstruction)((PexObjectFunctionInstructionCommon)((IPexObjectFunctionInstructionGetter)item).CommonInstance()!).GetNew();
            ((PexObjectFunctionInstructionSetterTranslationCommon)((IPexObjectFunctionInstructionGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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

namespace Mutagen.Bethesda.Pex
{
    public partial class PexObjectFunctionInstruction
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => PexObjectFunctionInstruction_Registration.Instance;
        public static PexObjectFunctionInstruction_Registration StaticRegistration => PexObjectFunctionInstruction_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => PexObjectFunctionInstructionCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterInstance()
        {
            return PexObjectFunctionInstructionSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => PexObjectFunctionInstructionSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IPexObjectFunctionInstructionGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object IPexObjectFunctionInstructionGetter.CommonSetterInstance() => this.CommonSetterInstance();
        [DebuggerStepThrough]
        object IPexObjectFunctionInstructionGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

    }
}

