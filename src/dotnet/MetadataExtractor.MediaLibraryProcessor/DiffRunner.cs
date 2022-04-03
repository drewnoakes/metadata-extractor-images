// Copyright (c) Drew Noakes and contributors. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiffPlex;
using DiffPlex.Chunkers;
using DiffPlex.DiffBuilder;
using DiffPlex.DiffBuilder.Model;

namespace MetadataExtractor.MediaLibraryProcessor;

/// <summary>
/// Produces diff files, comparing output from different versions of the library with the goal
/// of aligning for parity across them.
/// </summary>
internal static class DiffRunner
{
    private static readonly Task CompletedTask = Task.FromResult<object?>(null);
    private static readonly string[] EmptyStringArray = new string[0];

    public static Task RunAsync(string path)
    {
        var diffBuilder = new InlineDiffBuilder(new Differ());
        var chunker = new LineChunker();

        // Top level folders are file types (except "src" folder)
        foreach (var directory in System.IO.Directory.GetDirectories(path, "*", SearchOption.AllDirectories))
        {
            // TODO more robust filtering
            if (directory.Contains(".git") || directory.Contains("src"))
                continue;

            var dotNetFiles = GetFiles("dotnet");
            var javaFiles = GetFiles("java");

            var allFiles = dotNetFiles.Union(javaFiles).ToList();

            if (allFiles.Count == 0)
                continue;

            foreach (var file in allFiles)
            {
                if (file is null)
                    continue;

                var dotNetMetadata = GetFileContent("dotnet", file);
                var javaMetadata = GetFileContent("java", file);

                var diff = diffBuilder.BuildDiffModel(javaMetadata, dotNetMetadata, false, false, chunker);

                var diffOutputPath = Path.Combine(directory, "metadata", "diff");
                var diffFilePath = Path.Combine(diffOutputPath, file);

                System.IO.Directory.CreateDirectory(diffOutputPath);

                if (diff.Lines.All(line => line.Type == ChangeType.Unchanged))
                {
                    // No difference
                    if (File.Exists(diffFilePath))
                        File.Delete(diffFilePath);
                    continue;
                }

                // A difference exists
                using var fileStream = File.Open(diffFilePath, FileMode.Create);
                using var log = new StreamWriter(fileStream, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));

                foreach (var line in diff.Lines)
                {
                    log.Write(line.Type switch
                    {
                        ChangeType.Inserted => "DOTNET ",
                        ChangeType.Deleted => "JAVA   ",
                        _ => "       "
                    });
                    log.WriteLine(line.Text);
                }
            }

            string?[] GetFiles(string language)
            {
                var languageOutputDir = Path.Combine(directory, "metadata", language);
                if (!System.IO.Directory.Exists(languageOutputDir))
                    return EmptyStringArray;
                return System.IO.Directory.GetFiles(languageOutputDir, "*.txt").Select(Path.GetFileName).ToArray();
            }

            string GetFileContent(string language, string fileName)
            {
                var path = Path.Combine(directory, "metadata", language, fileName);

                if (File.Exists(path))
                    return File.ReadAllText(path);
                return "";
            }
        }

        return CompletedTask;
    }
}