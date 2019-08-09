// Copyright (c) Drew Noakes and contributors. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using JetBrains.Annotations;
using MetadataExtractor.Formats.FileSystem;

namespace MetadataExtractor.MediaLibraryProcessor
{
    // TODO port UnknownTagHandler from Java

    internal static class Program
    {
        private static void Main()
        {
            var handlers = new IFileHandler[]
            {
//                new BasicFileHandler(),
                new TextFileOutputHandler(),
                new MarkdownTableOutputHandler()
            };

            using var fileStream = File.Open("process-dotnet.log", FileMode.Create);
            using var log = new StreamWriter(fileStream, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));

            var stopwatch = Stopwatch.StartNew();

            var root = Path.GetFullPath(@"..\..\..\..\..\..\");

            ProcessDirectory(root, handlers, "", log);

            foreach (var handler in handlers)
                handler.OnScanCompleted(log);

            Console.Out.WriteLine("Completed in {0:#,##0.##} ms", stopwatch.Elapsed.TotalMilliseconds);

            log.Dispose();
        }

        private static void ProcessDirectory([NotNull] string path, [NotNull] IReadOnlyList<IFileHandler> handlers, [NotNull] string relativePath, [NotNull] TextWriter log)
        {
            var entries = System.IO.Directory.GetFileSystemEntries(path);

            // Order alphabetically so that output is stable across invocations
            Array.Sort(entries, string.CompareOrdinal);

            foreach (var entry in entries)
            {
                var file = Path.Combine(path, entry);

                if (System.IO.Directory.Exists(file))
                {
                    // this entry is a sub-directory
                    ProcessDirectory(file, handlers, relativePath.Length == 0 ? new DirectoryInfo(entry).Name : relativePath + "/" + new DirectoryInfo(entry).Name, log);
                    continue;
                }

                // this entry is a file
                var interestedHandlers = handlers.Where(h => h.ShouldProcess(file)).ToList();

                if (interestedHandlers.Count != 0)
                {
                    foreach (var handler in interestedHandlers)
                        handler.OnBeforeExtraction(file, relativePath, log);

                    // Read metadata
                    using var stream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read);

                    try
                    {
                        var directories = ImageMetadataReader.ReadMetadata(stream).ToList();

                        // ImageMetadataReader.ReadMetadata(Stream) doesn't add a FileMetadataReader directory.
                        // Add it manually
                        directories.Add(new FileMetadataReader().Read(file));

                        foreach (var handler in interestedHandlers)
                            handler.OnExtractionSuccess(file, directories, relativePath, log, stream.Position);
                    }
                    catch (Exception e)
                    {
                        foreach (var handler in interestedHandlers)
                            handler.OnExtractionError(file, e, log, stream.Position);
                    }
                }
            }
        }
    }
}