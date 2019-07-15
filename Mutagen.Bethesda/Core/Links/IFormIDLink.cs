﻿using Loqui;
using Noggog.Notifying;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutagen.Bethesda
{
    public interface IFormIDLinkGetter<out T> : ILinkGetter<T>
       where T : IMajorRecordInternalGetter
    {
        FormKey? UnlinkedForm { get; }
    }

    public interface IFormIDLink<T> : IFormIDLinkGetter<T>, ILink<T>
       where T : IMajorRecordInternalGetter
    {
        void Set(T value);
        void SetLink(ILink<T> value);
    }

    public interface IFormIDSetLinkGetter<out T> : IFormIDLinkGetter<T>, ISetLinkGetter<T>
       where T : IMajorRecordInternalGetter
    {
    }

    public interface IFormIDSetLink<T> : IFormIDLink<T>, ISetLink<T>, IFormIDSetLinkGetter<T>
       where T : IMajorRecordInternalGetter
    {
    }
}