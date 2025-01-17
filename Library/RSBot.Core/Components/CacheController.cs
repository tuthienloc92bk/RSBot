﻿using RSBot.Pk2;
using RSBot.Pk2.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace RSBot.Core.Components
{
    public class CacheController
    {
        /// <summary>
        /// Gets or sets a value indicating whether [use cache].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [use cache]; otherwise, <c>false</c>.
        /// </value>
        public static bool UseCache => GlobalConfig.Get<bool>("RSBot.EnableFileCache");

        /// <summary>
        /// The cache directory
        /// </summary>
        public static string CacheDirectory = Environment.CurrentDirectory + "\\Cache\\";

        /// <summary>
        /// Gets or sets the Media.pk2 reader.
        /// </summary>
        /// <value>
        /// The PK2 reader.
        /// </value>
        public PK2Archive Archive { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheController" /> class.
        /// </summary>
        /// <param name="archive">The media PK2.</param>
        public CacheController(PK2Archive archive)
        {
            Archive = archive;

            Log.Debug("[CacheController] Use filecache:" + UseCache);

            if (!Directory.Exists(CacheDirectory))
                Directory.CreateDirectory(CacheDirectory);
        }

        /// <summary>
        /// Gets the file.
        /// </summary>
        /// <param name="filename">The filename.</param>
        public CacheFile GetFile(string filename)
        {
            //Load from Pk2
            if (!UseCache)
                return new CacheFile(filename, true);

            //Load from cache
            if (UseCache && File.Exists(CacheDirectory + filename))
                return new CacheFile(CacheDirectory + filename, false);

            //Extract and load
            CacheFile(filename, out var cachedFile);

            return cachedFile;
        }

        /// <summary>
        /// Caches the file.
        /// </summary>
        /// <param name="filename">The filename.</param>
        public void CacheFile(string filename, out CacheFile cachedFile)
        {
            cachedFile = null;
            if (!FileExists(filename))
            {
                Log.Debug($"Unable to create cache for {filename}. File does not exist");
                return;
            }

            var pK2File = Archive.GetFile(filename);
            pK2File.Extract(CacheDirectory + filename);

            cachedFile = new CacheFile(CacheDirectory + filename, false);
        }

        /// <summary>
        /// Files the exists.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <returns></returns>
        public bool FileExists(string filename)
        {
            return Archive?.FileExists(filename) ?? false;
        }

        /// <summary>
        /// Loads the state.
        /// </summary>
        /// <param name="mediaPk2">The media PK2.</param>
        /// <returns></returns>
        public static CacheController Initialize(string mediaPk2)
        {
            var pk2Config = new PK2Config
            {
                Key = GlobalConfig.Get<string>("RSBot.Pk2Key", "169841"),
                Mode = PK2Mode.Index,
                BaseKey = new byte[] { 0x03, 0xF8, 0xE4, 0x44, 0x88, 0x99, 0x3F, 0x64, 0xFE, 0x35 }
            };

            return new CacheController(new PK2Archive(mediaPk2, pk2Config));
        }
    }

    /// <summary>
    ///
    /// </summary>
    public class CacheFile
    {
        /// <summary>
        /// Gets or sets a value indicating whether this instance is PK2 file.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is PK2 file; otherwise, <c>false</c>.
        /// </value>
        public bool IsPk2File { get; set; }

        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>
        /// The path.
        /// </value>
        public string Path { get; set; }


        /// <summary>
        /// Gets or sets the pk2 file.
        /// </summary>
        /// <value>
        /// The pk2 file.
        /// </value>
        private PK2File _file;

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheFile"/> class.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="isPk2File">if set to <c>true</c> [is PK2 file].</param>
        public CacheFile(string path, bool isPk2File)
        {
            Path = path;
            IsPk2File = isPk2File;

            if (isPk2File)
                _file = Game.MediaPk2.Archive.GetFile(path);
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        public byte[] GetData()
        {
            return !IsPk2File ? File.ReadAllBytes(Path) : _file.GetData();
        }

        /// <summary>
        /// Read all text.
        /// </summary>
        /// <returns></returns>
        public string ReadAllText()
        {
            return !IsPk2File ? File.ReadAllText(Path) : _file.ReadAllText();
        }

        /// <summary>
        /// Gets the stream.
        /// </summary>
        /// <returns></returns>
        public Stream GetStream()
        {
            return !IsPk2File ? File.OpenRead(Path) : _file.GetStream();
        }
    }
}