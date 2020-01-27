// Copyright (c) Drew Noakes and contributors. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.IO;
using System.Threading.Tasks;

namespace MetadataExtractor.MediaLibraryProcessor
{
    internal static class Program
    {
        private static async Task Main()
        {
            // TODO more robust way of finding repo root path
            var repoRoot = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..\\..\\..\\..\\..\\.."));

            // Update all .NET and Java metadata files
            await Task.WhenAll(
                DotNetRunner.RunAsync(repoRoot),
                JavaRunner.RunAsync(repoRoot));

            // Update comparisons between .NET and Java outputs
            await DiffRunner.RunAsync(repoRoot);
        }
    }
}
