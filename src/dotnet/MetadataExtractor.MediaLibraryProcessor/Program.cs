// Copyright (c) Drew Noakes and contributors. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using MetadataExtractor.MediaLibraryProcessor;

using System;
using System.IO;
using System.Threading.Tasks;

#if NET8_0_OR_GREATER
System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
#endif

// TODO support building libraries from source too

// TODO more robust way of finding repo root path
string repoRoot = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, """..\..\..\..\..\.."""));

// Update all .NET and Java metadata files
await Console.Out.WriteLineAsync("Generating metadata files for both Java and .NET implementations...");

await Task.WhenAll(
    DotNetRunner.RunAsync(repoRoot),
    JavaRunner.RunAsync(repoRoot));

// Update comparisons between .NET and Java outputs
await Console.Out.WriteLineAsync("Generating metadata diff files...");

await DiffRunner.RunAsync(repoRoot);

await Console.Out.WriteLineAsync("Done.");
