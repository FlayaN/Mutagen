using System;
using System.Collections.Generic;
using System.Text;

namespace Mutagen.Bethesda.Skyrim
{
    public static partial class WarmupSkyrim
    {
        static partial void InitCustom()
        {
            lock (OverrideMixIns.AddAsOverrideMasks)
            {
                OverrideMixIns.AddAsOverrideMasks[typeof(ICell)] = ModContextExt.CellCopyMask;
                OverrideMixIns.AddAsOverrideMasks[typeof(ICellGetter)] = ModContextExt.CellCopyMask;
                OverrideMixIns.AddAsOverrideMasks[typeof(Cell)] = ModContextExt.CellCopyMask;
                OverrideMixIns.AddAsOverrideMasks[typeof(IWorldspace)] = ModContextExt.WorldspaceCopyMask;
                OverrideMixIns.AddAsOverrideMasks[typeof(IWorldspaceGetter)] = ModContextExt.WorldspaceCopyMask;
                OverrideMixIns.AddAsOverrideMasks[typeof(Worldspace)] = ModContextExt.WorldspaceCopyMask;
                OverrideMixIns.AddAsOverrideMasks[typeof(IDialogTopic)] = ModContextExt.DialogTopicCopyMask;
                OverrideMixIns.AddAsOverrideMasks[typeof(IDialogTopicGetter)] = ModContextExt.DialogTopicCopyMask;
                OverrideMixIns.AddAsOverrideMasks[typeof(DialogTopic)] = ModContextExt.DialogTopicCopyMask;
            }
        }
    }
}
