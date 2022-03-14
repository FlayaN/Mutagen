/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
#region Usings
using Loqui;
using Loqui.Internal;
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
    public partial class DebugStructOrder :
        IDebugStructOrder,
        IEquatable<IDebugStructOrderGetter>,
        ILoquiObjectSetter<DebugStructOrder>
    {
        #region Ctor
        public DebugStructOrder()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region ObjectName
        public String ObjectName { get; set; } = string.Empty;
        #endregion
        #region OrderName
        public String OrderName { get; set; } = string.Empty;
        #endregion
        #region Names
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ExtendedList<String> _Names = new ExtendedList<String>();
        public ExtendedList<String> Names
        {
            get => this._Names;
            init => this._Names = value;
        }
        #region Interface Members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IReadOnlyList<String> IDebugStructOrderGetter.Names => _Names;
        #endregion

        #endregion

        #region To String

        public void ToString(
            FileGeneration fg,
            string? name = null)
        {
            DebugStructOrderMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IDebugStructOrderGetter rhs) return false;
            return ((DebugStructOrderCommon)((IDebugStructOrderGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IDebugStructOrderGetter? obj)
        {
            return ((DebugStructOrderCommon)((IDebugStructOrderGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((DebugStructOrderCommon)((IDebugStructOrderGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public class Mask<TItem> :
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            {
                this.ObjectName = initialValue;
                this.OrderName = initialValue;
                this.Names = new MaskItem<TItem, IEnumerable<(int Index, TItem Value)>?>(initialValue, Enumerable.Empty<(int Index, TItem Value)>());
            }

            public Mask(
                TItem ObjectName,
                TItem OrderName,
                TItem Names)
            {
                this.ObjectName = ObjectName;
                this.OrderName = OrderName;
                this.Names = new MaskItem<TItem, IEnumerable<(int Index, TItem Value)>?>(Names, Enumerable.Empty<(int Index, TItem Value)>());
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem ObjectName;
            public TItem OrderName;
            public MaskItem<TItem, IEnumerable<(int Index, TItem Value)>?>? Names;
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
                if (!object.Equals(this.ObjectName, rhs.ObjectName)) return false;
                if (!object.Equals(this.OrderName, rhs.OrderName)) return false;
                if (!object.Equals(this.Names, rhs.Names)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.ObjectName);
                hash.Add(this.OrderName);
                hash.Add(this.Names);
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public bool All(Func<TItem, bool> eval)
            {
                if (!eval(this.ObjectName)) return false;
                if (!eval(this.OrderName)) return false;
                if (this.Names != null)
                {
                    if (!eval(this.Names.Overall)) return false;
                    if (this.Names.Specific != null)
                    {
                        foreach (var item in this.Names.Specific)
                        {
                            if (!eval(item.Value)) return false;
                        }
                    }
                }
                return true;
            }
            #endregion

            #region Any
            public bool Any(Func<TItem, bool> eval)
            {
                if (eval(this.ObjectName)) return true;
                if (eval(this.OrderName)) return true;
                if (this.Names != null)
                {
                    if (eval(this.Names.Overall)) return true;
                    if (this.Names.Specific != null)
                    {
                        foreach (var item in this.Names.Specific)
                        {
                            if (!eval(item.Value)) return false;
                        }
                    }
                }
                return false;
            }
            #endregion

            #region Translate
            public Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new DebugStructOrder.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                obj.ObjectName = eval(this.ObjectName);
                obj.OrderName = eval(this.OrderName);
                if (Names != null)
                {
                    obj.Names = new MaskItem<R, IEnumerable<(int Index, R Value)>?>(eval(this.Names.Overall), Enumerable.Empty<(int Index, R Value)>());
                    if (Names.Specific != null)
                    {
                        var l = new List<(int Index, R Item)>();
                        obj.Names.Specific = l;
                        foreach (var item in Names.Specific)
                        {
                            R mask = eval(item.Value);
                            l.Add((item.Index, mask));
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

            public string ToString(DebugStructOrder.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, DebugStructOrder.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(DebugStructOrder.Mask<TItem>)} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    if (printMask?.ObjectName ?? true)
                    {
                        fg.AppendItem(ObjectName, "ObjectName");
                    }
                    if (printMask?.OrderName ?? true)
                    {
                        fg.AppendItem(OrderName, "OrderName");
                    }
                    if ((printMask?.Names?.Overall ?? true)
                        && Names is {} NamesItem)
                    {
                        fg.AppendLine("Names =>");
                        fg.AppendLine("[");
                        using (new DepthWrapper(fg))
                        {
                            fg.AppendItem(NamesItem.Overall);
                            if (NamesItem.Specific != null)
                            {
                                foreach (var subItem in NamesItem.Specific)
                                {
                                    fg.AppendLine("[");
                                    using (new DepthWrapper(fg))
                                    {
                                        fg.AppendItem(subItem);
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
            public Exception? ObjectName;
            public Exception? OrderName;
            public MaskItem<Exception?, IEnumerable<(int Index, Exception Value)>?>? Names;
            #endregion

            #region IErrorMask
            public object? GetNthMask(int index)
            {
                DebugStructOrder_FieldIndex enu = (DebugStructOrder_FieldIndex)index;
                switch (enu)
                {
                    case DebugStructOrder_FieldIndex.ObjectName:
                        return ObjectName;
                    case DebugStructOrder_FieldIndex.OrderName:
                        return OrderName;
                    case DebugStructOrder_FieldIndex.Names:
                        return Names;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthException(int index, Exception ex)
            {
                DebugStructOrder_FieldIndex enu = (DebugStructOrder_FieldIndex)index;
                switch (enu)
                {
                    case DebugStructOrder_FieldIndex.ObjectName:
                        this.ObjectName = ex;
                        break;
                    case DebugStructOrder_FieldIndex.OrderName:
                        this.OrderName = ex;
                        break;
                    case DebugStructOrder_FieldIndex.Names:
                        this.Names = new MaskItem<Exception?, IEnumerable<(int Index, Exception Value)>?>(ex, null);
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthMask(int index, object obj)
            {
                DebugStructOrder_FieldIndex enu = (DebugStructOrder_FieldIndex)index;
                switch (enu)
                {
                    case DebugStructOrder_FieldIndex.ObjectName:
                        this.ObjectName = (Exception?)obj;
                        break;
                    case DebugStructOrder_FieldIndex.OrderName:
                        this.OrderName = (Exception?)obj;
                        break;
                    case DebugStructOrder_FieldIndex.Names:
                        this.Names = (MaskItem<Exception?, IEnumerable<(int Index, Exception Value)>?>)obj;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public bool IsInError()
            {
                if (Overall != null) return true;
                if (ObjectName != null) return true;
                if (OrderName != null) return true;
                if (Names != null) return true;
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
                fg.AppendItem(ObjectName, "ObjectName");
                fg.AppendItem(OrderName, "OrderName");
                if (Names is {} NamesItem)
                {
                    fg.AppendLine("Names =>");
                    fg.AppendLine("[");
                    using (new DepthWrapper(fg))
                    {
                        fg.AppendItem(NamesItem.Overall);
                        if (NamesItem.Specific != null)
                        {
                            foreach (var subItem in NamesItem.Specific)
                            {
                                fg.AppendLine("[");
                                using (new DepthWrapper(fg))
                                {
                                    fg.AppendItem(subItem);
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
                ret.ObjectName = this.ObjectName.Combine(rhs.ObjectName);
                ret.OrderName = this.OrderName.Combine(rhs.OrderName);
                ret.Names = new MaskItem<Exception?, IEnumerable<(int Index, Exception Value)>?>(ExceptionExt.Combine(this.Names?.Overall, rhs.Names?.Overall), ExceptionExt.Combine(this.Names?.Specific, rhs.Names?.Specific));
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
            public bool ObjectName;
            public bool OrderName;
            public bool Names;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
            {
                this.DefaultOn = defaultOn;
                this.OnOverall = onOverall;
                this.ObjectName = defaultOn;
                this.OrderName = defaultOn;
                this.Names = defaultOn;
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
                ret.Add((ObjectName, null));
                ret.Add((OrderName, null));
                ret.Add((Names, null));
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
            ((DebugStructOrderSetterCommon)((IDebugStructOrderGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static DebugStructOrder GetNew()
        {
            return new DebugStructOrder();
        }

    }
    #endregion

    #region Interface
    public partial interface IDebugStructOrder :
        IDebugStructOrderGetter,
        ILoquiObjectSetter<IDebugStructOrder>
    {
        new String ObjectName { get; set; }
        new String OrderName { get; set; }
        new ExtendedList<String> Names { get; }
    }

    public partial interface IDebugStructOrderGetter :
        ILoquiObject,
        ILoquiObject<IDebugStructOrderGetter>
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object? CommonSetterInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonSetterTranslationInstance();
        static ILoquiRegistration StaticRegistration => DebugStructOrder_Registration.Instance;
        String ObjectName { get; }
        String OrderName { get; }
        IReadOnlyList<String> Names { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class DebugStructOrderMixIn
    {
        public static void Clear(this IDebugStructOrder item)
        {
            ((DebugStructOrderSetterCommon)((IDebugStructOrderGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static DebugStructOrder.Mask<bool> GetEqualsMask(
            this IDebugStructOrderGetter item,
            IDebugStructOrderGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((DebugStructOrderCommon)((IDebugStructOrderGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this IDebugStructOrderGetter item,
            string? name = null,
            DebugStructOrder.Mask<bool>? printMask = null)
        {
            return ((DebugStructOrderCommon)((IDebugStructOrderGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this IDebugStructOrderGetter item,
            FileGeneration fg,
            string? name = null,
            DebugStructOrder.Mask<bool>? printMask = null)
        {
            ((DebugStructOrderCommon)((IDebugStructOrderGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IDebugStructOrderGetter item,
            IDebugStructOrderGetter rhs,
            DebugStructOrder.TranslationMask? equalsMask = null)
        {
            return ((DebugStructOrderCommon)((IDebugStructOrderGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IDebugStructOrder lhs,
            IDebugStructOrderGetter rhs)
        {
            ((DebugStructOrderSetterTranslationCommon)((IDebugStructOrderGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: default,
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IDebugStructOrder lhs,
            IDebugStructOrderGetter rhs,
            DebugStructOrder.TranslationMask? copyMask = null)
        {
            ((DebugStructOrderSetterTranslationCommon)((IDebugStructOrderGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IDebugStructOrder lhs,
            IDebugStructOrderGetter rhs,
            out DebugStructOrder.ErrorMask errorMask,
            DebugStructOrder.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((DebugStructOrderSetterTranslationCommon)((IDebugStructOrderGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = DebugStructOrder.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IDebugStructOrder lhs,
            IDebugStructOrderGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((DebugStructOrderSetterTranslationCommon)((IDebugStructOrderGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static DebugStructOrder DeepCopy(
            this IDebugStructOrderGetter item,
            DebugStructOrder.TranslationMask? copyMask = null)
        {
            return ((DebugStructOrderSetterTranslationCommon)((IDebugStructOrderGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static DebugStructOrder DeepCopy(
            this IDebugStructOrderGetter item,
            out DebugStructOrder.ErrorMask errorMask,
            DebugStructOrder.TranslationMask? copyMask = null)
        {
            return ((DebugStructOrderSetterTranslationCommon)((IDebugStructOrderGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static DebugStructOrder DeepCopy(
            this IDebugStructOrderGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((DebugStructOrderSetterTranslationCommon)((IDebugStructOrderGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
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
    public enum DebugStructOrder_FieldIndex
    {
        ObjectName = 0,
        OrderName = 1,
        Names = 2,
    }
    #endregion

    #region Registration
    public partial class DebugStructOrder_Registration : ILoquiRegistration
    {
        public static readonly DebugStructOrder_Registration Instance = new DebugStructOrder_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Pex.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Pex.ProtocolKey,
            msgID: 4,
            version: 0);

        public const string GUID = "fd8ffb0e-b1ca-4a61-b7f4-5eccff10d9ca";

        public const ushort AdditionalFieldCount = 3;

        public const ushort FieldCount = 3;

        public static readonly Type MaskType = typeof(DebugStructOrder.Mask<>);

        public static readonly Type ErrorMaskType = typeof(DebugStructOrder.ErrorMask);

        public static readonly Type ClassType = typeof(DebugStructOrder);

        public static readonly Type GetterType = typeof(IDebugStructOrderGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IDebugStructOrder);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Pex.DebugStructOrder";

        public const string Name = "DebugStructOrder";

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
    public partial class DebugStructOrderSetterCommon
    {
        public static readonly DebugStructOrderSetterCommon Instance = new DebugStructOrderSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IDebugStructOrder item)
        {
            ClearPartial();
            item.ObjectName = string.Empty;
            item.OrderName = string.Empty;
            item.Names.Clear();
        }
        
    }
    public partial class DebugStructOrderCommon
    {
        public static readonly DebugStructOrderCommon Instance = new DebugStructOrderCommon();

        public DebugStructOrder.Mask<bool> GetEqualsMask(
            IDebugStructOrderGetter item,
            IDebugStructOrderGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new DebugStructOrder.Mask<bool>(false);
            ((DebugStructOrderCommon)((IDebugStructOrderGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IDebugStructOrderGetter item,
            IDebugStructOrderGetter rhs,
            DebugStructOrder.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            ret.ObjectName = string.Equals(item.ObjectName, rhs.ObjectName);
            ret.OrderName = string.Equals(item.OrderName, rhs.OrderName);
            ret.Names = item.Names.CollectionEqualsHelper(
                rhs.Names,
                (l, r) => string.Equals(l, r),
                include);
        }
        
        public string ToString(
            IDebugStructOrderGetter item,
            string? name = null,
            DebugStructOrder.Mask<bool>? printMask = null)
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
            IDebugStructOrderGetter item,
            FileGeneration fg,
            string? name = null,
            DebugStructOrder.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"DebugStructOrder =>");
            }
            else
            {
                fg.AppendLine($"{name} (DebugStructOrder) =>");
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
            IDebugStructOrderGetter item,
            FileGeneration fg,
            DebugStructOrder.Mask<bool>? printMask = null)
        {
            if (printMask?.ObjectName ?? true)
            {
                fg.AppendItem(item.ObjectName, "ObjectName");
            }
            if (printMask?.OrderName ?? true)
            {
                fg.AppendItem(item.OrderName, "OrderName");
            }
            if (printMask?.Names?.Overall ?? true)
            {
                fg.AppendLine("Names =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    foreach (var subItem in item.Names)
                    {
                        fg.AppendLine("[");
                        using (new DepthWrapper(fg))
                        {
                            fg.AppendItem(subItem);
                        }
                        fg.AppendLine("]");
                    }
                }
                fg.AppendLine("]");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IDebugStructOrderGetter? lhs,
            IDebugStructOrderGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if ((crystal?.GetShouldTranslate((int)DebugStructOrder_FieldIndex.ObjectName) ?? true))
            {
                if (!string.Equals(lhs.ObjectName, rhs.ObjectName)) return false;
            }
            if ((crystal?.GetShouldTranslate((int)DebugStructOrder_FieldIndex.OrderName) ?? true))
            {
                if (!string.Equals(lhs.OrderName, rhs.OrderName)) return false;
            }
            if ((crystal?.GetShouldTranslate((int)DebugStructOrder_FieldIndex.Names) ?? true))
            {
                if (!lhs.Names.SequenceEqualNullable(rhs.Names)) return false;
            }
            return true;
        }
        
        public virtual int GetHashCode(IDebugStructOrderGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.ObjectName);
            hash.Add(item.OrderName);
            hash.Add(item.Names);
            return hash.ToHashCode();
        }
        
        #endregion
        
        
        public object GetNew()
        {
            return DebugStructOrder.GetNew();
        }
        
    }
    public partial class DebugStructOrderSetterTranslationCommon
    {
        public static readonly DebugStructOrderSetterTranslationCommon Instance = new DebugStructOrderSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IDebugStructOrder item,
            IDebugStructOrderGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            if ((copyMask?.GetShouldTranslate((int)DebugStructOrder_FieldIndex.ObjectName) ?? true))
            {
                item.ObjectName = rhs.ObjectName;
            }
            if ((copyMask?.GetShouldTranslate((int)DebugStructOrder_FieldIndex.OrderName) ?? true))
            {
                item.OrderName = rhs.OrderName;
            }
            if ((copyMask?.GetShouldTranslate((int)DebugStructOrder_FieldIndex.Names) ?? true))
            {
                errorMask?.PushIndex((int)DebugStructOrder_FieldIndex.Names);
                try
                {
                    item.Names.SetTo(rhs.Names);
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
        
        public DebugStructOrder DeepCopy(
            IDebugStructOrderGetter item,
            DebugStructOrder.TranslationMask? copyMask = null)
        {
            DebugStructOrder ret = (DebugStructOrder)((DebugStructOrderCommon)((IDebugStructOrderGetter)item).CommonInstance()!).GetNew();
            ((DebugStructOrderSetterTranslationCommon)((IDebugStructOrderGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public DebugStructOrder DeepCopy(
            IDebugStructOrderGetter item,
            out DebugStructOrder.ErrorMask errorMask,
            DebugStructOrder.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            DebugStructOrder ret = (DebugStructOrder)((DebugStructOrderCommon)((IDebugStructOrderGetter)item).CommonInstance()!).GetNew();
            ((DebugStructOrderSetterTranslationCommon)((IDebugStructOrderGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = DebugStructOrder.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public DebugStructOrder DeepCopy(
            IDebugStructOrderGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            DebugStructOrder ret = (DebugStructOrder)((DebugStructOrderCommon)((IDebugStructOrderGetter)item).CommonInstance()!).GetNew();
            ((DebugStructOrderSetterTranslationCommon)((IDebugStructOrderGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class DebugStructOrder
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => DebugStructOrder_Registration.Instance;
        public static DebugStructOrder_Registration StaticRegistration => DebugStructOrder_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => DebugStructOrderCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterInstance()
        {
            return DebugStructOrderSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => DebugStructOrderSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IDebugStructOrderGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object IDebugStructOrderGetter.CommonSetterInstance() => this.CommonSetterInstance();
        [DebuggerStepThrough]
        object IDebugStructOrderGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

    }
}

