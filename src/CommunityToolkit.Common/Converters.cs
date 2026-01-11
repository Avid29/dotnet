// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace CommunityToolkit.Common;

/// <summary>
/// Set of helpers to convert between data types and notations.
/// </summary>
public static class Converters
{
    /// <summary>
    /// Translate numeric file size in bytes to a human-readable shorter string format.
    /// </summary>
    /// <param name="size">File size in bytes.</param>
    /// <returns>Returns file size short string.</returns>
    public static string ToFileSizeString(long size)
    {
        const long KB = 1L << 10;
        const long MB = 1L << 20;
        const long GB = 1L << 30;
        const long TB = 1L << 40;
        const long PB = 1L << 50;
        const long EB = 1L << 60;

        return size switch
        {
            < KB => $"{size:F0} bytes",
            < MB => $"{size / (float)KB:F1} KB",
            < GB => $"{size / (float)MB:F1} MB",
            < TB => $"{size / (float)GB:F1} GB",
            < PB => $"{size / (float)TB:F1} TB",
            < EB => $"{size / (float)PB:F1} PB",
            _ => $"{size / (float)EB:F1} EB"
        };
    }
}
