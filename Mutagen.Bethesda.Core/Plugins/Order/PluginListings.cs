using DynamicData;
using Noggog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reactive;
using System.Reactive.Linq;

namespace Mutagen.Bethesda.Plugins.Order
{
    public static class PluginListings
    {
        private readonly static PluginPathProvider PathProvider = new(IFileSystemExt.DefaultFilesystem);
        private readonly static PluginListingsProvider Retriever = new(
            IFileSystemExt.DefaultFilesystem,
            PathProvider,
            new TimestampAligner(IFileSystemExt.DefaultFilesystem));
        
        /// <inheritdoc cref="IPluginListingsProvider"/>
        public static string GetListingsPath(GameRelease game)
        {
            return PathProvider.GetListingsPath(game);
        }

        /// <inheritdoc cref="IPluginListingsProvider"/>
        public static bool TryGetListingsFile(GameRelease game, out FilePath path)
        {
            return PathProvider.TryLocateListingsPath(game, out path);
        }

        /// <inheritdoc cref="IPluginListingsProvider"/>
        public static FilePath GetListingsFile(GameRelease game)
        {
            return PathProvider.LocateListingsPath(game);
        }

        /// <inheritdoc cref="IPluginListingsProvider"/>
        public static IEnumerable<IModListingGetter> ListingsFromStream(Stream stream, GameRelease game)
        {
            return Retriever.ListingsFromStream(stream, game);
        }

        /// <inheritdoc cref="IPluginListingsProvider"/>
        public static IEnumerable<IModListingGetter> ListingsFromPath(
            GameRelease game,
            DirectoryPath dataPath,
            bool throwOnMissingMods = true)
        {
            return Retriever.ListingsFromPath(game, dataPath, throwOnMissingMods: throwOnMissingMods);
        }

        /// <inheritdoc cref="IPluginListingsProvider"/>
        public static IEnumerable<IModListingGetter> ListingsFromPath(
            FilePath pluginTextPath,
            GameRelease game,
            DirectoryPath dataPath,
            bool throwOnMissingMods = true)
        {
            return Retriever.ListingsFromPath(pluginTextPath, game, dataPath, throwOnMissingMods: throwOnMissingMods);
        }

        /// <inheritdoc cref="IPluginListingsProvider"/>
        public static IEnumerable<IModListingGetter> RawListingsFromPath(
            FilePath pluginTextPath,
            GameRelease game)
        {
            return Retriever.RawListingsFromPath(pluginTextPath, game);
        }

        public static IObservable<IChangeSet<IModListingGetter>> GetLiveLoadOrder(
            GameRelease game,
            FilePath loadOrderFilePath,
            DirectoryPath dataFolderPath,
            out IObservable<ErrorResponse> state,
            bool throwOnMissingMods = true,
            bool orderListings = true)
        {
            var results = ObservableExt.WatchFile(loadOrderFilePath.Path)
                .StartWith(Unit.Default)
                .Select(_ =>
                {
                    try
                    {
                        var lo = ListingsFromPath(loadOrderFilePath, game, dataFolderPath, throwOnMissingMods: throwOnMissingMods);
                        if (orderListings)
                        {
                            lo = lo.OrderListings();
                        }
                        return GetResponse<IObservable<IChangeSet<IModListingGetter>>>.Succeed(lo.AsObservableChangeSet());
                    }
                    catch (Exception ex)
                    {
                        return GetResponse<IObservable<IChangeSet<IModListingGetter>>>.Fail(ex);
                    }
                })
                .Replay(1)
                .RefCount();
            state = results
                .Select(r => (ErrorResponse)r);
            return results
                .Select(r =>
                {
                    return r.Value ?? Observable.Empty<IChangeSet<IModListingGetter>>();
                })
                .Switch();
        }

        public static IObservable<Unit> GetLoadOrderChanged(FilePath loadOrderFilePath)
        {
            return ObservableExt.WatchFile(loadOrderFilePath.Path);
        }

        public static IObservable<Unit> GetLoadOrderChanged(GameRelease game) => GetLoadOrderChanged(GetListingsPath(game));

        public static bool HasEnabledMarkers(GameRelease game)
        {
            return game switch
            {
                GameRelease.Fallout4 => true,
                GameRelease.SkyrimSE => true,
                GameRelease.EnderalSE => true,
                GameRelease.SkyrimVR => true,
                GameRelease.SkyrimLE => false,
                GameRelease.EnderalLE => false,
                GameRelease.Oblivion => false,
                _ => throw new NotImplementedException(),
            };
        }
    }
}
