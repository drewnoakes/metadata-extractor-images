// Copyright (c) Drew Noakes and contributors. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MetadataExtractor.MediaLibraryProcessor;

internal abstract class FileHandlerBase : IFileHandler
{
    private static readonly HashSet<string> _supportedExtensions = new(StringComparer.OrdinalIgnoreCase)
    {
        ".3fr",
        ".3g2",
        ".3gp",
        ".ai",
        ".arw",
        ".avi",
        ".avif",
        ".bmp",
        ".cam",
        ".cr2",
        ".cr3",
        ".crw",
        ".dcr",
        ".dng",
        ".eps",
        ".fuzzed",
        ".gif",
        ".gpr",
        ".heic",
        ".heif",
        ".ico",
        ".j2c",
        ".jp2",
        ".jpeg",
        ".jpf",
        ".jpg",
        ".jpm",
        ".jxr",
        ".kdc",
        ".m2ts",
        ".m2v",
        ".m4a",
        ".m4v",
        ".mj2",
        ".mov",
        ".mp3",
        ".mp4",
        ".mpg",
        ".mts",
        ".nef",
        ".orf",
        ".pbm",
        ".pcx",
        ".pef",
        ".pgm",
        ".png",
        ".pnm",
        ".ppm",
        ".psd",
        ".raf",
        ".rw2",
        ".rwl",
        ".srw",
        ".tif",
        ".tiff",
        ".wav",
        ".webp",
        ".x3f"
    };

    private int _processedFileCount;
    private int _exceptionCount;
    private int _errorCount;
    private long _totalFileByteCount;
    private long _totalReadByteCount;

    public virtual void OnStartingDirectory(string directoryPath)
    {}

    public bool ShouldProcess(string filePath)
    {
        var extension = Path.GetExtension(filePath);
        return extension.Length > 1 && _supportedExtensions.Contains(extension);
    }

    public virtual void OnBeforeExtraction(string filePath, string relativePath, TextWriter log)
    {
        _processedFileCount++;
        _totalFileByteCount += new FileInfo(filePath).Length;
    }

    public virtual void OnExtractionError(string filePath, Exception exception, TextWriter log, long streamPosition)
    {
        _exceptionCount++;
        _totalReadByteCount += streamPosition;
        log.Write($"\t[{exception.GetType().Name}] {filePath}\n");
    }

    public virtual void OnExtractionSuccess(string filePath, IList<Directory> directories, string relativePath, TextWriter log, long streamPosition)
    {
        _totalReadByteCount += streamPosition;

        if (!directories.Any(d => d.HasError))
            return;

        // write out any errors
        log.WriteLine(filePath);
        foreach (var directory in directories)
        {
            if (!directory.HasError)
                continue;
            foreach (var error in directory.Errors)
            {
                log.Write($"\t[{directory.Name}] {error}\n");
                _errorCount++;
            }
        }
    }

    public virtual void OnScanCompleted(TextWriter log)
    {
        if (_processedFileCount <= 0)
            return;

        log.WriteLine(
            $"Processed {_processedFileCount:#,##0} files (read {_totalReadByteCount:#,##0} of {_totalFileByteCount:#,##0} bytes) with {_exceptionCount:#,##0} exceptions and {_errorCount:#,##0} file errors\n");
    }
}