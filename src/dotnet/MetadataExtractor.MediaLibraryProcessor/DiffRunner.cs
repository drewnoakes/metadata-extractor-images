using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiffPlex;
using DiffPlex.Chunkers;
using DiffPlex.DiffBuilder;
using DiffPlex.DiffBuilder.Model;

namespace MetadataExtractor.MediaLibraryProcessor
{
    internal static class DiffRunner
    {
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
                    var dotNetMetadata = GetFileContent("dotnet", file);
                    var javaMetadata = GetFileContent("java", file);

                    var diff = diffBuilder.BuildDiffModel(javaMetadata, dotNetMetadata, false, false, chunker);

                    var diffOutputPath = Path.Combine(directory, "metadata", "diff");
                    if (!System.IO.Directory.Exists(diffOutputPath))
                        System.IO.Directory.CreateDirectory(diffOutputPath);
                    var diffFilePath = Path.Combine(diffOutputPath, file);

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

                string[] GetFiles(string language)
                {
                    var languageOutputDir = Path.Combine(directory, "metadata", language);
                    if (!System.IO.Directory.Exists(languageOutputDir))
                        return Array.Empty<string>();
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

            return Task.CompletedTask;
        }
    }
}