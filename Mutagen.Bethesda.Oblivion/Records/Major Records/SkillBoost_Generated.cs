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
using Mutagen.Bethesda.Oblivion.Internals;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Binary.Overlay;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Binary.Translations;
using Mutagen.Bethesda.Plugins.Exceptions;
using Mutagen.Bethesda.Plugins.Records;
using Mutagen.Bethesda.Plugins.Records.Internals;
using Mutagen.Bethesda.Translations.Binary;
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
namespace Mutagen.Bethesda.Oblivion
{
    #region Class
    public partial class SkillBoost :
        IEquatable<ISkillBoostGetter>,
        ILoquiObjectSetter<SkillBoost>,
        ISkillBoost
    {
        #region Ctor
        public SkillBoost()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Skill
        public ActorValue Skill { get; set; } = default;
        #endregion
        #region Boost
        public SByte Boost { get; set; } = default;
        #endregion

        #region To String

        public void ToString(
            FileGeneration fg,
            string? name = null)
        {
            SkillBoostMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not ISkillBoostGetter rhs) return false;
            return ((SkillBoostCommon)((ISkillBoostGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(ISkillBoostGetter? obj)
        {
            return ((SkillBoostCommon)((ISkillBoostGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((SkillBoostCommon)((ISkillBoostGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public class Mask<TItem> :
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            {
                this.Skill = initialValue;
                this.Boost = initialValue;
            }

            public Mask(
                TItem Skill,
                TItem Boost)
            {
                this.Skill = Skill;
                this.Boost = Boost;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Skill;
            public TItem Boost;
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
                if (!object.Equals(this.Skill, rhs.Skill)) return false;
                if (!object.Equals(this.Boost, rhs.Boost)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Skill);
                hash.Add(this.Boost);
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public bool All(Func<TItem, bool> eval)
            {
                if (!eval(this.Skill)) return false;
                if (!eval(this.Boost)) return false;
                return true;
            }
            #endregion

            #region Any
            public bool Any(Func<TItem, bool> eval)
            {
                if (eval(this.Skill)) return true;
                if (eval(this.Boost)) return true;
                return false;
            }
            #endregion

            #region Translate
            public Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new SkillBoost.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                obj.Skill = eval(this.Skill);
                obj.Boost = eval(this.Boost);
            }
            #endregion

            #region To String
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(SkillBoost.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, SkillBoost.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(SkillBoost.Mask<TItem>)} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    if (printMask?.Skill ?? true)
                    {
                        fg.AppendItem(Skill, "Skill");
                    }
                    if (printMask?.Boost ?? true)
                    {
                        fg.AppendItem(Boost, "Boost");
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
            public Exception? Skill;
            public Exception? Boost;
            #endregion

            #region IErrorMask
            public object? GetNthMask(int index)
            {
                SkillBoost_FieldIndex enu = (SkillBoost_FieldIndex)index;
                switch (enu)
                {
                    case SkillBoost_FieldIndex.Skill:
                        return Skill;
                    case SkillBoost_FieldIndex.Boost:
                        return Boost;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthException(int index, Exception ex)
            {
                SkillBoost_FieldIndex enu = (SkillBoost_FieldIndex)index;
                switch (enu)
                {
                    case SkillBoost_FieldIndex.Skill:
                        this.Skill = ex;
                        break;
                    case SkillBoost_FieldIndex.Boost:
                        this.Boost = ex;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthMask(int index, object obj)
            {
                SkillBoost_FieldIndex enu = (SkillBoost_FieldIndex)index;
                switch (enu)
                {
                    case SkillBoost_FieldIndex.Skill:
                        this.Skill = (Exception?)obj;
                        break;
                    case SkillBoost_FieldIndex.Boost:
                        this.Boost = (Exception?)obj;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public bool IsInError()
            {
                if (Overall != null) return true;
                if (Skill != null) return true;
                if (Boost != null) return true;
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
                fg.AppendItem(Skill, "Skill");
                fg.AppendItem(Boost, "Boost");
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Skill = this.Skill.Combine(rhs.Skill);
                ret.Boost = this.Boost.Combine(rhs.Boost);
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
            public bool Skill;
            public bool Boost;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
            {
                this.DefaultOn = defaultOn;
                this.OnOverall = onOverall;
                this.Skill = defaultOn;
                this.Boost = defaultOn;
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
                ret.Add((Skill, null));
                ret.Add((Boost, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => SkillBoostBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((SkillBoostBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public static SkillBoost CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            var ret = new SkillBoost();
            ((SkillBoostSetterCommon)((ISkillBoostGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out SkillBoost item,
            TypedParseParams? translationParams = null)
        {
            var startPos = frame.Position;
            item = CreateFromBinary(
                frame: frame,
                translationParams: translationParams);
            return startPos != frame.Position;
        }
        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        void IClearable.Clear()
        {
            ((SkillBoostSetterCommon)((ISkillBoostGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static SkillBoost GetNew()
        {
            return new SkillBoost();
        }

    }
    #endregion

    #region Interface
    public partial interface ISkillBoost :
        ILoquiObjectSetter<ISkillBoost>,
        ISkillBoostGetter
    {
        new ActorValue Skill { get; set; }
        new SByte Boost { get; set; }
    }

    public partial interface ISkillBoostGetter :
        ILoquiObject,
        IBinaryItem,
        ILoquiObject<ISkillBoostGetter>
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object? CommonSetterInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonSetterTranslationInstance();
        static ILoquiRegistration Registration => SkillBoost_Registration.Instance;
        ActorValue Skill { get; }
        SByte Boost { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class SkillBoostMixIn
    {
        public static void Clear(this ISkillBoost item)
        {
            ((SkillBoostSetterCommon)((ISkillBoostGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static SkillBoost.Mask<bool> GetEqualsMask(
            this ISkillBoostGetter item,
            ISkillBoostGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((SkillBoostCommon)((ISkillBoostGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this ISkillBoostGetter item,
            string? name = null,
            SkillBoost.Mask<bool>? printMask = null)
        {
            return ((SkillBoostCommon)((ISkillBoostGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this ISkillBoostGetter item,
            FileGeneration fg,
            string? name = null,
            SkillBoost.Mask<bool>? printMask = null)
        {
            ((SkillBoostCommon)((ISkillBoostGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this ISkillBoostGetter item,
            ISkillBoostGetter rhs,
            SkillBoost.TranslationMask? equalsMask = null)
        {
            return ((SkillBoostCommon)((ISkillBoostGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this ISkillBoost lhs,
            ISkillBoostGetter rhs)
        {
            ((SkillBoostSetterTranslationCommon)((ISkillBoostGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: default,
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this ISkillBoost lhs,
            ISkillBoostGetter rhs,
            SkillBoost.TranslationMask? copyMask = null)
        {
            ((SkillBoostSetterTranslationCommon)((ISkillBoostGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this ISkillBoost lhs,
            ISkillBoostGetter rhs,
            out SkillBoost.ErrorMask errorMask,
            SkillBoost.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((SkillBoostSetterTranslationCommon)((ISkillBoostGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = SkillBoost.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this ISkillBoost lhs,
            ISkillBoostGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((SkillBoostSetterTranslationCommon)((ISkillBoostGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static SkillBoost DeepCopy(
            this ISkillBoostGetter item,
            SkillBoost.TranslationMask? copyMask = null)
        {
            return ((SkillBoostSetterTranslationCommon)((ISkillBoostGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static SkillBoost DeepCopy(
            this ISkillBoostGetter item,
            out SkillBoost.ErrorMask errorMask,
            SkillBoost.TranslationMask? copyMask = null)
        {
            return ((SkillBoostSetterTranslationCommon)((ISkillBoostGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static SkillBoost DeepCopy(
            this ISkillBoostGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((SkillBoostSetterTranslationCommon)((ISkillBoostGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this ISkillBoost item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            ((SkillBoostSetterCommon)((ISkillBoostGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                translationParams: translationParams);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Oblivion.Internals
{
    #region Field Index
    public enum SkillBoost_FieldIndex
    {
        Skill = 0,
        Boost = 1,
    }
    #endregion

    #region Registration
    public partial class SkillBoost_Registration : ILoquiRegistration
    {
        public static readonly SkillBoost_Registration Instance = new SkillBoost_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Oblivion.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Oblivion.ProtocolKey,
            msgID: 27,
            version: 0);

        public const string GUID = "5b28ecc2-3bf5-495e-9f6f-db9ce344e94e";

        public const ushort AdditionalFieldCount = 2;

        public const ushort FieldCount = 2;

        public static readonly Type MaskType = typeof(SkillBoost.Mask<>);

        public static readonly Type ErrorMaskType = typeof(SkillBoost.ErrorMask);

        public static readonly Type ClassType = typeof(SkillBoost);

        public static readonly Type GetterType = typeof(ISkillBoostGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(ISkillBoost);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Oblivion.SkillBoost";

        public const string Name = "SkillBoost";

        public const string Namespace = "Mutagen.Bethesda.Oblivion";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(SkillBoostBinaryWriteTranslation);
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
    public partial class SkillBoostSetterCommon
    {
        public static readonly SkillBoostSetterCommon Instance = new SkillBoostSetterCommon();

        partial void ClearPartial();
        
        public void Clear(ISkillBoost item)
        {
            ClearPartial();
            item.Skill = default;
            item.Boost = default;
        }
        
        #region Mutagen
        public void RemapLinks(ISkillBoost obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            ISkillBoost item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: SkillBoostBinaryCreateTranslation.FillBinaryStructs);
        }
        
        #endregion
        
    }
    public partial class SkillBoostCommon
    {
        public static readonly SkillBoostCommon Instance = new SkillBoostCommon();

        public SkillBoost.Mask<bool> GetEqualsMask(
            ISkillBoostGetter item,
            ISkillBoostGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new SkillBoost.Mask<bool>(false);
            ((SkillBoostCommon)((ISkillBoostGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            ISkillBoostGetter item,
            ISkillBoostGetter rhs,
            SkillBoost.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            ret.Skill = item.Skill == rhs.Skill;
            ret.Boost = item.Boost == rhs.Boost;
        }
        
        public string ToString(
            ISkillBoostGetter item,
            string? name = null,
            SkillBoost.Mask<bool>? printMask = null)
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
            ISkillBoostGetter item,
            FileGeneration fg,
            string? name = null,
            SkillBoost.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"SkillBoost =>");
            }
            else
            {
                fg.AppendLine($"{name} (SkillBoost) =>");
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
            ISkillBoostGetter item,
            FileGeneration fg,
            SkillBoost.Mask<bool>? printMask = null)
        {
            if (printMask?.Skill ?? true)
            {
                fg.AppendItem(item.Skill, "Skill");
            }
            if (printMask?.Boost ?? true)
            {
                fg.AppendItem(item.Boost, "Boost");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            ISkillBoostGetter? lhs,
            ISkillBoostGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if ((crystal?.GetShouldTranslate((int)SkillBoost_FieldIndex.Skill) ?? true))
            {
                if (lhs.Skill != rhs.Skill) return false;
            }
            if ((crystal?.GetShouldTranslate((int)SkillBoost_FieldIndex.Boost) ?? true))
            {
                if (lhs.Boost != rhs.Boost) return false;
            }
            return true;
        }
        
        public virtual int GetHashCode(ISkillBoostGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Skill);
            hash.Add(item.Boost);
            return hash.ToHashCode();
        }
        
        #endregion
        
        
        public object GetNew()
        {
            return SkillBoost.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> GetContainedFormLinks(ISkillBoostGetter obj)
        {
            yield break;
        }
        
        #endregion
        
    }
    public partial class SkillBoostSetterTranslationCommon
    {
        public static readonly SkillBoostSetterTranslationCommon Instance = new SkillBoostSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            ISkillBoost item,
            ISkillBoostGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            if ((copyMask?.GetShouldTranslate((int)SkillBoost_FieldIndex.Skill) ?? true))
            {
                item.Skill = rhs.Skill;
            }
            if ((copyMask?.GetShouldTranslate((int)SkillBoost_FieldIndex.Boost) ?? true))
            {
                item.Boost = rhs.Boost;
            }
        }
        
        #endregion
        
        public SkillBoost DeepCopy(
            ISkillBoostGetter item,
            SkillBoost.TranslationMask? copyMask = null)
        {
            SkillBoost ret = (SkillBoost)((SkillBoostCommon)((ISkillBoostGetter)item).CommonInstance()!).GetNew();
            ((SkillBoostSetterTranslationCommon)((ISkillBoostGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public SkillBoost DeepCopy(
            ISkillBoostGetter item,
            out SkillBoost.ErrorMask errorMask,
            SkillBoost.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            SkillBoost ret = (SkillBoost)((SkillBoostCommon)((ISkillBoostGetter)item).CommonInstance()!).GetNew();
            ((SkillBoostSetterTranslationCommon)((ISkillBoostGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = SkillBoost.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public SkillBoost DeepCopy(
            ISkillBoostGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            SkillBoost ret = (SkillBoost)((SkillBoostCommon)((ISkillBoostGetter)item).CommonInstance()!).GetNew();
            ((SkillBoostSetterTranslationCommon)((ISkillBoostGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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

namespace Mutagen.Bethesda.Oblivion
{
    public partial class SkillBoost
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => SkillBoost_Registration.Instance;
        public static SkillBoost_Registration Registration => SkillBoost_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => SkillBoostCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterInstance()
        {
            return SkillBoostSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => SkillBoostSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object ISkillBoostGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object ISkillBoostGetter.CommonSetterInstance() => this.CommonSetterInstance();
        [DebuggerStepThrough]
        object ISkillBoostGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Oblivion.Internals
{
    public partial class SkillBoostBinaryWriteTranslation : IBinaryWriteTranslator
    {
        public readonly static SkillBoostBinaryWriteTranslation Instance = new SkillBoostBinaryWriteTranslation();

        public static void WriteEmbedded(
            ISkillBoostGetter item,
            MutagenWriter writer)
        {
            EnumBinaryTranslation<ActorValue, MutagenFrame, MutagenWriter>.Instance.Write(
                writer,
                item.Skill,
                length: 1);
            writer.Write(item.Boost);
        }

        public void Write(
            MutagenWriter writer,
            ISkillBoostGetter item,
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
                item: (ISkillBoostGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    public partial class SkillBoostBinaryCreateTranslation
    {
        public readonly static SkillBoostBinaryCreateTranslation Instance = new SkillBoostBinaryCreateTranslation();

        public static void FillBinaryStructs(
            ISkillBoost item,
            MutagenFrame frame)
        {
            item.Skill = EnumBinaryTranslation<ActorValue, MutagenFrame, MutagenWriter>.Instance.Parse(
                reader: frame,
                length: 1);
            item.Boost = frame.ReadInt8();
        }

    }

}
namespace Mutagen.Bethesda.Oblivion
{
    #region Binary Write Mixins
    public static class SkillBoostBinaryTranslationMixIn
    {
        public static void WriteToBinary(
            this ISkillBoostGetter item,
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((SkillBoostBinaryWriteTranslation)item.BinaryWriteTranslator).Write(
                item: item,
                writer: writer,
                translationParams: translationParams);
        }

    }
    #endregion


}
namespace Mutagen.Bethesda.Oblivion.Internals
{
    public partial class SkillBoostBinaryOverlay :
        PluginBinaryOverlay,
        ISkillBoostGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => SkillBoost_Registration.Instance;
        public static SkillBoost_Registration Registration => SkillBoost_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => SkillBoostCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => SkillBoostSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object ISkillBoostGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object? ISkillBoostGetter.CommonSetterInstance() => null;
        [DebuggerStepThrough]
        object ISkillBoostGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => SkillBoostBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((SkillBoostBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        public ActorValue Skill => (ActorValue)_data.Span.Slice(0x0, 0x1)[0];
        public SByte Boost => (sbyte)_data.Slice(0x1, 0x1)[0];
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected SkillBoostBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }

        public static SkillBoostBinaryOverlay SkillBoostFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            TypedParseParams? parseParams = null)
        {
            var ret = new SkillBoostBinaryOverlay(
                bytes: stream.RemainingMemory.Slice(0, 0x2),
                package: package);
            int offset = stream.Position;
            stream.Position += 0x2;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static SkillBoostBinaryOverlay SkillBoostFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams? parseParams = null)
        {
            return SkillBoostFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                parseParams: parseParams);
        }

        #region To String

        public void ToString(
            FileGeneration fg,
            string? name = null)
        {
            SkillBoostMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not ISkillBoostGetter rhs) return false;
            return ((SkillBoostCommon)((ISkillBoostGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(ISkillBoostGetter? obj)
        {
            return ((SkillBoostCommon)((ISkillBoostGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((SkillBoostCommon)((ISkillBoostGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

