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
using Mutagen.Bethesda.Oblivion.Internals;
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
using RecordTypeInts = Mutagen.Bethesda.Oblivion.Internals.RecordTypeInts;
using RecordTypes = Mutagen.Bethesda.Oblivion.Internals.RecordTypes;
using System.Buffers.Binary;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reactive.Disposables;
using System.Reactive.Linq;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Oblivion
{
    #region Class
    public partial class Location :
        IEquatable<ILocationGetter>,
        ILocation,
        ILoquiObjectSetter<Location>
    {
        #region Ctor
        public Location()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Position
        public P3Float Position { get; set; } = default;
        #endregion
        #region Rotation
        public P3Float Rotation { get; set; } = default;
        #endregion

        #region To String

        public void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            LocationMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not ILocationGetter rhs) return false;
            return ((LocationCommon)((ILocationGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(ILocationGetter? obj)
        {
            return ((LocationCommon)((ILocationGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((LocationCommon)((ILocationGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public class Mask<TItem> :
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            {
                this.Position = initialValue;
                this.Rotation = initialValue;
            }

            public Mask(
                TItem Position,
                TItem Rotation)
            {
                this.Position = Position;
                this.Rotation = Rotation;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Position;
            public TItem Rotation;
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
                if (!object.Equals(this.Position, rhs.Position)) return false;
                if (!object.Equals(this.Rotation, rhs.Rotation)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Position);
                hash.Add(this.Rotation);
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public bool All(Func<TItem, bool> eval)
            {
                if (!eval(this.Position)) return false;
                if (!eval(this.Rotation)) return false;
                return true;
            }
            #endregion

            #region Any
            public bool Any(Func<TItem, bool> eval)
            {
                if (eval(this.Position)) return true;
                if (eval(this.Rotation)) return true;
                return false;
            }
            #endregion

            #region Translate
            public Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new Location.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                obj.Position = eval(this.Position);
                obj.Rotation = eval(this.Rotation);
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public string Print(Location.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, Location.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(Location.Mask<TItem>)} =>");
                using (sb.Brace())
                {
                    if (printMask?.Position ?? true)
                    {
                        sb.AppendItem(Position, "Position");
                    }
                    if (printMask?.Rotation ?? true)
                    {
                        sb.AppendItem(Rotation, "Rotation");
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
            public Exception? Position;
            public Exception? Rotation;
            #endregion

            #region IErrorMask
            public object? GetNthMask(int index)
            {
                Location_FieldIndex enu = (Location_FieldIndex)index;
                switch (enu)
                {
                    case Location_FieldIndex.Position:
                        return Position;
                    case Location_FieldIndex.Rotation:
                        return Rotation;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthException(int index, Exception ex)
            {
                Location_FieldIndex enu = (Location_FieldIndex)index;
                switch (enu)
                {
                    case Location_FieldIndex.Position:
                        this.Position = ex;
                        break;
                    case Location_FieldIndex.Rotation:
                        this.Rotation = ex;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthMask(int index, object obj)
            {
                Location_FieldIndex enu = (Location_FieldIndex)index;
                switch (enu)
                {
                    case Location_FieldIndex.Position:
                        this.Position = (Exception?)obj;
                        break;
                    case Location_FieldIndex.Rotation:
                        this.Rotation = (Exception?)obj;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public bool IsInError()
            {
                if (Overall != null) return true;
                if (Position != null) return true;
                if (Rotation != null) return true;
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
                    sb.AppendItem(Position, "Position");
                }
                {
                    sb.AppendItem(Rotation, "Rotation");
                }
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Position = this.Position.Combine(rhs.Position);
                ret.Rotation = this.Rotation.Combine(rhs.Rotation);
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
            public bool Position;
            public bool Rotation;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
            {
                this.DefaultOn = defaultOn;
                this.OnOverall = onOverall;
                this.Position = defaultOn;
                this.Rotation = defaultOn;
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
                ret.Add((Position, null));
                ret.Add((Rotation, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => LocationBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((LocationBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public static Location CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            var ret = new Location();
            ((LocationSetterCommon)((ILocationGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out Location item,
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
            ((LocationSetterCommon)((ILocationGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static Location GetNew()
        {
            return new Location();
        }

    }
    #endregion

    #region Interface
    public partial interface ILocation :
        ILocationGetter,
        ILoquiObjectSetter<ILocation>,
        IPositionRotation
    {
        new P3Float Position { get; set; }
        new P3Float Rotation { get; set; }
    }

    public partial interface ILocationGetter :
        ILoquiObject,
        IBinaryItem,
        ILoquiObject<ILocationGetter>,
        IPositionRotationGetter
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object? CommonSetterInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonSetterTranslationInstance();
        static ILoquiRegistration StaticRegistration => Location_Registration.Instance;
        P3Float Position { get; }
        P3Float Rotation { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class LocationMixIn
    {
        public static void Clear(this ILocation item)
        {
            ((LocationSetterCommon)((ILocationGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static Location.Mask<bool> GetEqualsMask(
            this ILocationGetter item,
            ILocationGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((LocationCommon)((ILocationGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this ILocationGetter item,
            string? name = null,
            Location.Mask<bool>? printMask = null)
        {
            return ((LocationCommon)((ILocationGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this ILocationGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            Location.Mask<bool>? printMask = null)
        {
            ((LocationCommon)((ILocationGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this ILocationGetter item,
            ILocationGetter rhs,
            Location.TranslationMask? equalsMask = null)
        {
            return ((LocationCommon)((ILocationGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this ILocation lhs,
            ILocationGetter rhs)
        {
            ((LocationSetterTranslationCommon)((ILocationGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: default,
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this ILocation lhs,
            ILocationGetter rhs,
            Location.TranslationMask? copyMask = null)
        {
            ((LocationSetterTranslationCommon)((ILocationGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this ILocation lhs,
            ILocationGetter rhs,
            out Location.ErrorMask errorMask,
            Location.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((LocationSetterTranslationCommon)((ILocationGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = Location.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this ILocation lhs,
            ILocationGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((LocationSetterTranslationCommon)((ILocationGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static Location DeepCopy(
            this ILocationGetter item,
            Location.TranslationMask? copyMask = null)
        {
            return ((LocationSetterTranslationCommon)((ILocationGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static Location DeepCopy(
            this ILocationGetter item,
            out Location.ErrorMask errorMask,
            Location.TranslationMask? copyMask = null)
        {
            return ((LocationSetterTranslationCommon)((ILocationGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static Location DeepCopy(
            this ILocationGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((LocationSetterTranslationCommon)((ILocationGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this ILocation item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            ((LocationSetterCommon)((ILocationGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                translationParams: translationParams);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Oblivion
{
    #region Field Index
    internal enum Location_FieldIndex
    {
        Position = 0,
        Rotation = 1,
    }
    #endregion

    #region Registration
    internal partial class Location_Registration : ILoquiRegistration
    {
        public static readonly Location_Registration Instance = new Location_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Oblivion.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Oblivion.ProtocolKey,
            msgID: 201,
            version: 0);

        public const string GUID = "d33c0af1-394e-4795-9a09-7497c199b745";

        public const ushort AdditionalFieldCount = 2;

        public const ushort FieldCount = 2;

        public static readonly Type MaskType = typeof(Location.Mask<>);

        public static readonly Type ErrorMaskType = typeof(Location.ErrorMask);

        public static readonly Type ClassType = typeof(Location);

        public static readonly Type GetterType = typeof(ILocationGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(ILocation);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Oblivion.Location";

        public const string Name = "Location";

        public const string Namespace = "Mutagen.Bethesda.Oblivion";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(LocationBinaryWriteTranslation);
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
    internal partial class LocationSetterCommon
    {
        public static readonly LocationSetterCommon Instance = new LocationSetterCommon();

        partial void ClearPartial();
        
        public void Clear(ILocation item)
        {
            ClearPartial();
            item.Position = default;
            item.Rotation = default;
        }
        
        #region Mutagen
        public void RemapLinks(ILocation obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            ILocation item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: LocationBinaryCreateTranslation.FillBinaryStructs);
        }
        
        #endregion
        
    }
    internal partial class LocationCommon
    {
        public static readonly LocationCommon Instance = new LocationCommon();

        public Location.Mask<bool> GetEqualsMask(
            ILocationGetter item,
            ILocationGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new Location.Mask<bool>(false);
            ((LocationCommon)((ILocationGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            ILocationGetter item,
            ILocationGetter rhs,
            Location.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            ret.Position = item.Position.Equals(rhs.Position);
            ret.Rotation = item.Rotation.Equals(rhs.Rotation);
        }
        
        public string Print(
            ILocationGetter item,
            string? name = null,
            Location.Mask<bool>? printMask = null)
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
            ILocationGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            Location.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"Location =>");
            }
            else
            {
                sb.AppendLine($"{name} (Location) =>");
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
            ILocationGetter item,
            StructuredStringBuilder sb,
            Location.Mask<bool>? printMask = null)
        {
            if (printMask?.Position ?? true)
            {
                sb.AppendItem(item.Position, "Position");
            }
            if (printMask?.Rotation ?? true)
            {
                sb.AppendItem(item.Rotation, "Rotation");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            ILocationGetter? lhs,
            ILocationGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if ((crystal?.GetShouldTranslate((int)Location_FieldIndex.Position) ?? true))
            {
                if (!lhs.Position.Equals(rhs.Position)) return false;
            }
            if ((crystal?.GetShouldTranslate((int)Location_FieldIndex.Rotation) ?? true))
            {
                if (!lhs.Rotation.Equals(rhs.Rotation)) return false;
            }
            return true;
        }
        
        public virtual int GetHashCode(ILocationGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Position);
            hash.Add(item.Rotation);
            return hash.ToHashCode();
        }
        
        #endregion
        
        
        public object GetNew()
        {
            return Location.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(ILocationGetter obj)
        {
            yield break;
        }
        
        #endregion
        
    }
    internal partial class LocationSetterTranslationCommon
    {
        public static readonly LocationSetterTranslationCommon Instance = new LocationSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            ILocation item,
            ILocationGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            if ((copyMask?.GetShouldTranslate((int)Location_FieldIndex.Position) ?? true))
            {
                item.Position = rhs.Position;
            }
            if ((copyMask?.GetShouldTranslate((int)Location_FieldIndex.Rotation) ?? true))
            {
                item.Rotation = rhs.Rotation;
            }
        }
        
        #endregion
        
        public Location DeepCopy(
            ILocationGetter item,
            Location.TranslationMask? copyMask = null)
        {
            Location ret = (Location)((LocationCommon)((ILocationGetter)item).CommonInstance()!).GetNew();
            ((LocationSetterTranslationCommon)((ILocationGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public Location DeepCopy(
            ILocationGetter item,
            out Location.ErrorMask errorMask,
            Location.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            Location ret = (Location)((LocationCommon)((ILocationGetter)item).CommonInstance()!).GetNew();
            ((LocationSetterTranslationCommon)((ILocationGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = Location.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public Location DeepCopy(
            ILocationGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            Location ret = (Location)((LocationCommon)((ILocationGetter)item).CommonInstance()!).GetNew();
            ((LocationSetterTranslationCommon)((ILocationGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class Location
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => Location_Registration.Instance;
        public static ILoquiRegistration StaticRegistration => Location_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => LocationCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterInstance()
        {
            return LocationSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => LocationSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object ILocationGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object ILocationGetter.CommonSetterInstance() => this.CommonSetterInstance();
        [DebuggerStepThrough]
        object ILocationGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Oblivion
{
    public partial class LocationBinaryWriteTranslation : IBinaryWriteTranslator
    {
        public readonly static LocationBinaryWriteTranslation Instance = new LocationBinaryWriteTranslation();

        public static void WriteEmbedded(
            ILocationGetter item,
            MutagenWriter writer)
        {
            P3FloatBinaryTranslation<MutagenFrame, MutagenWriter>.Instance.Write(
                writer: writer,
                item: item.Position);
            P3FloatBinaryTranslation<MutagenFrame, MutagenWriter>.Instance.Write(
                writer: writer,
                item: item.Rotation);
        }

        public void Write(
            MutagenWriter writer,
            ILocationGetter item,
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
                item: (ILocationGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class LocationBinaryCreateTranslation
    {
        public readonly static LocationBinaryCreateTranslation Instance = new LocationBinaryCreateTranslation();

        public static void FillBinaryStructs(
            ILocation item,
            MutagenFrame frame)
        {
            item.Position = P3FloatBinaryTranslation<MutagenFrame, MutagenWriter>.Instance.Parse(reader: frame);
            item.Rotation = P3FloatBinaryTranslation<MutagenFrame, MutagenWriter>.Instance.Parse(reader: frame);
        }

    }

}
namespace Mutagen.Bethesda.Oblivion
{
    #region Binary Write Mixins
    public static class LocationBinaryTranslationMixIn
    {
        public static void WriteToBinary(
            this ILocationGetter item,
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((LocationBinaryWriteTranslation)item.BinaryWriteTranslator).Write(
                item: item,
                writer: writer,
                translationParams: translationParams);
        }

    }
    #endregion


}
namespace Mutagen.Bethesda.Oblivion
{
    internal partial class LocationBinaryOverlay :
        PluginBinaryOverlay,
        ILocationGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => Location_Registration.Instance;
        public static ILoquiRegistration StaticRegistration => Location_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => LocationCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => LocationSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object ILocationGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object? ILocationGetter.CommonSetterInstance() => null;
        [DebuggerStepThrough]
        object ILocationGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => LocationBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((LocationBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        public P3Float Position => P3FloatBinaryTranslation<MutagenFrame, MutagenWriter>.Instance.Read(_data.Slice(0x0, 0xC));
        public P3Float Rotation => P3FloatBinaryTranslation<MutagenFrame, MutagenWriter>.Instance.Read(_data.Slice(0xC, 0xC));
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected LocationBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }

        public static ILocationGetter LocationFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            TypedParseParams? translationParams = null)
        {
            var ret = new LocationBinaryOverlay(
                bytes: stream.RemainingMemory.Slice(0, 0x18),
                package: package);
            int offset = stream.Position;
            stream.Position += 0x18;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static ILocationGetter LocationFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams? translationParams = null)
        {
            return LocationFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                translationParams: translationParams);
        }

        #region To String

        public void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            LocationMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not ILocationGetter rhs) return false;
            return ((LocationCommon)((ILocationGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(ILocationGetter? obj)
        {
            return ((LocationCommon)((ILocationGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((LocationCommon)((ILocationGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

