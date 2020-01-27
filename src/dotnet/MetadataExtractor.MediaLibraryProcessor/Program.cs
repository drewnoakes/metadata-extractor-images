// Copyright (c) Drew Noakes and contributors. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System.Threading.Tasks;

namespace MetadataExtractor.MediaLibraryProcessor
{
    internal static class Program
    {
        private static async Task Main()
        {
            await Task.WhenAll(
                DotNetRunner.RunAsync(),
                JavaRunner.RunAsync());
        }
    }
}