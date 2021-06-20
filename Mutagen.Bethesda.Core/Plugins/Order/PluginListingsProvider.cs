﻿using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Abstractions;
using System.Linq;
using Noggog;

namespace Mutagen.Bethesda.Plugins.Order
{
    public interface IPluginListingsProvider
    {
        /// <summary>
        /// Parses a stream to retrieve all ModKeys in expected plugin file format
        /// </summary>
        /// <param name="stream">Stream to read from</param>
        /// <param name="game">Game type</param>
        /// <returns>List of ModKeys representing a load order</returns>
        /// <exception cref="ArgumentException">Line in plugin stream is unexpected</exception>
        IEnumerable<IModListingGetter> ListingsFromStream(Stream stream, GameRelease game);

        /// <summary>
        /// Parses the typical plugins file to retrieve all ModKeys in expected plugin file format,
        /// Will order mods by timestamps if applicable
        /// Will add implicit base mods if applicable
        /// </summary>
        /// <param name="game">Game type</param>
        /// <param name="dataPath">Path to game's data folder</param>
        /// <param name="throwOnMissingMods">Whether to throw and exception if mods are missing</param>
        /// <returns>Enumerable of ModKeys representing a load order</returns>
        /// <exception cref="ArgumentException">Line in plugin file is unexpected</exception>
        IEnumerable<IModListingGetter> ListingsFromPath(
            GameRelease game,
            DirectoryPath dataPath,
            bool throwOnMissingMods = true);

        /// <summary>
        /// Parses a file to retrieve all ModKeys in expected plugin file format,
        /// Will order mods by timestamps if applicable
        /// Will add implicit base mods if applicable
        /// </summary>
        /// <param name="game">Game type</param>
        /// <param name="pluginTextPath">Path of plugin list</param>
        /// <param name="dataPath">Path to game's data folder</param>
        /// <param name="throwOnMissingMods">Whether to throw and exception if mods are missing</param>
        /// <returns>Enumerable of ModKeys representing a load order</returns>
        /// <exception cref="ArgumentException">Line in plugin file is unexpected</exception>
        IEnumerable<IModListingGetter> ListingsFromPath(
            FilePath pluginTextPath,
            GameRelease game,
            DirectoryPath dataPath,
            bool throwOnMissingMods = true);

        IEnumerable<IModListingGetter> RawListingsFromPath(
            FilePath pluginTextPath,
            GameRelease game);
    }

    public class PluginListingsProvider : IPluginListingsProvider
    {
        private readonly IFileSystem _FileSystem;
        private readonly IPluginPathProvider _pluginPathProvider;
        private readonly ITimestampAligner _TimestampAligner;

        public PluginListingsProvider(
            IFileSystem fileSystem,
            IPluginPathProvider pluginPathProvider,
            ITimestampAligner timestampAligner)
        {
            _FileSystem = fileSystem;
            _pluginPathProvider = pluginPathProvider;
            _TimestampAligner = timestampAligner;
        }
        
        private string GetRelativePluginsPath(GameRelease game)
        {
            return game switch
            {
                GameRelease.Oblivion => "Oblivion/Plugins.txt",
                GameRelease.SkyrimLE => "Skyrim/Plugins.txt",
                GameRelease.SkyrimSE => "Skyrim Special Edition/Plugins.txt",
                GameRelease.SkyrimVR => "Skyrim VR/Plugins.txt",
                GameRelease.Fallout4 => "Fallout4/Plugins.txt",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc />
        public IEnumerable<IModListingGetter> ListingsFromStream(Stream stream, GameRelease game)
        {
            using var streamReader = new StreamReader(stream);
            var enabledMarkerProcessing = PluginListings.HasEnabledMarkers(game);
            while (!streamReader.EndOfStream)
            {
                var str = streamReader.ReadLine().AsSpan();
                var commentIndex = str.IndexOf('#');
                if (commentIndex != -1)
                {
                    str = str.Slice(0, commentIndex);
                }
                if (MemoryExtensions.IsWhiteSpace(str) || str.Length == 0) continue;
                yield return ModListing.FromString(str, enabledMarkerProcessing);
            }
        }

        /// <inheritdoc />
        public IEnumerable<IModListingGetter> ListingsFromPath(
            GameRelease game,
            DirectoryPath dataPath,
            bool throwOnMissingMods = true)
        {
            return ListingsFromPath(
                pluginTextPath: _pluginPathProvider.GetListingsPath(game),
                game: game,
                dataPath: dataPath,
                throwOnMissingMods: throwOnMissingMods);
        }

        /// <inheritdoc />
        public IEnumerable<IModListingGetter> ListingsFromPath(
            FilePath pluginTextPath,
            GameRelease game,
            DirectoryPath dataPath,
            bool throwOnMissingMods = true)
        {
            var mods = RawListingsFromPath(pluginTextPath, game);
            if (_TimestampAligner.NeedsTimestampAlignment(game.ToCategory()))
            {
                return _TimestampAligner.AlignToTimestamps(mods, dataPath, throwOnMissingMods: throwOnMissingMods);
            }
            else
            {
                return mods;
            }
        }

        /// <inheritdoc />
        public IEnumerable<IModListingGetter> RawListingsFromPath(
            FilePath pluginTextPath,
            GameRelease game)
        {
            if (!_FileSystem.File.Exists(pluginTextPath))
            {
                throw new FileNotFoundException("Could not locate plugins file");
            }
            using var stream = _FileSystem.FileStream.Create(pluginTextPath.Path, FileMode.Open, FileAccess.Read, FileShare.Read);
            return ListingsFromStream(stream, game).ToList();
        }
    }
}