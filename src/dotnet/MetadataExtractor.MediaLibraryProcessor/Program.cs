// Copyright (c) Drew Noakes and contributors. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using MetadataExtractor.MediaLibraryProcessor;

using System;
using System.Globalization;
using System.IO;
using System.Threading;

// TODO support building libraries from source too

// TODO more robust way of finding repo root path
string repoRoot = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, """..\..\..\..\..\.."""));

var culture = CultureInfo.GetCultureInfo("en-US");
Thread.CurrentThread.CurrentCulture = culture;
Thread.CurrentThread.CurrentUICulture = culture;

// Update .NET and Java metadata files
await Console.Out.WriteLineAsync("Updating metadata files...");

//await Task.WhenAll(
//    DotNetRunner.RunAsync(repoRoot),
//    JavaRunner.RunAsync(repoRoot));

await DotNetRunner.RunAsync(repoRoot);
await JavaRunner.RunAsync(repoRoot);

// Update comparisons between .NET and Java outputs
await Console.Out.WriteLineAsync("Updating diff files...");

await DiffRunner.RunAsync(repoRoot);

await Console.Out.WriteLineAsync("Done.");

