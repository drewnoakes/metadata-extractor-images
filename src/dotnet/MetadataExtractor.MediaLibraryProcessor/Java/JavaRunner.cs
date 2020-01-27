using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MetadataExtractor.MediaLibraryProcessor
{
    internal static class JavaRunner
    {
        public static async Task RunAsync(string repoRoot)
        {
            // Get onto a worker thread
            await Task.Yield();

            var mavenRepo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".m2\\repository");
            var xmpCoreLibraryPath = Path.Combine(mavenRepo, "com\\adobe\\xmp\\xmpcore\\6.0.6\\xmpcore-6.0.6.jar");

            var javaSrcRoot = Path.GetFullPath(Path.Combine(repoRoot, "..\\metadata-extractor\\Output\\maven\\classes"));

            // TODO write this somewhere sensible
            using var fileStream = File.Open("process-java.log", FileMode.Create);
            using var log = new StreamWriter(fileStream, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));

            var tcs = new TaskCompletionSource<object?>();
            try
            {
                var process = new Process
                {
                    StartInfo =
                    {
                        FileName = "java.exe",
                        Arguments = string.Join(
                            " ",
                            "-classpath", $"\"{xmpCoreLibraryPath}\";{javaSrcRoot}",
                            "com.drew.tools.ProcessAllImagesInFolderUtility",
                            "--text", $"\"{repoRoot}\""),
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,

                    },
                    EnableRaisingEvents = true
                };

                process.Exited += (s, e) => OnExit();
                process.OutputDataReceived += (s, e) => log.WriteLine(e.Data);
                process.ErrorDataReceived += (s, e) => log.WriteLine(e.Data);

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                if (process.HasExited)
                {
                    OnExit();
                }

                void OnExit()
                {
                    if (process.ExitCode == 0)
                        tcs.TrySetResult(null);
                    else
                        tcs.TrySetException(new Exception($"Java process exited with error code {process.ExitCode}"));
                }
            }
            catch (Exception e)
            {
                tcs.TrySetException(e);
            }

            await tcs.Task;
        }
    }
}