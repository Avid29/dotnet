// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

#pragma warning disable CS8777

namespace CommunityToolkit.Diagnostics;

/// <inheritdoc/>
partial class Guard
{
    /// <summary>
    /// Asserts that the input <see cref="string"/> instance must be <see langword="null"/> or empty.
    /// </summary>
    /// <param name="text">The input <see cref="string"/> instance to test.</param>
    /// <param name="name">The name of the input parameter being tested.</param>
    /// <exception cref="ArgumentException">Thrown if <paramref name="text"/> is neither <see langword="null"/> nor empty.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void IsNullOrEmpty(string? text, [CallerArgumentExpression("text")] string name = "")
    {
        if (Check.IsNullOrEmpty(text))
        {
            return;
        }

        ThrowHelper.ThrowArgumentExceptionForIsNullOrEmpty(text, name);
    }

    /// <summary>
    /// Asserts that the input <see cref="string"/> instance must not be <see langword="null"/> or empty.
    /// </summary>
    /// <param name="text">The input <see cref="string"/> instance to test.</param>
    /// <param name="name">The name of the input parameter being tested.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="text"/> is <see langword="null"/>.</exception>
    /// <exception cref="ArgumentException">Thrown if <paramref name="text"/> is empty.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void IsNotNullOrEmpty([NotNull] string? text, [CallerArgumentExpression("text")] string name = "")
    {
        if (Check.IsNotNullOrEmpty(text))
        {
            return;
        }

        ThrowHelper.ThrowArgumentExceptionForIsNotNullOrEmpty(text, name);
    }

    /// <summary>
    /// Asserts that the input <see cref="string"/> instance must be <see langword="null"/> or whitespace.
    /// </summary>
    /// <param name="text">The input <see cref="string"/> instance to test.</param>
    /// <param name="name">The name of the input parameter being tested.</param>
    /// <exception cref="ArgumentException">Thrown if <paramref name="text"/> is neither <see langword="null"/> nor whitespace.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void IsNullOrWhiteSpace(string? text, [CallerArgumentExpression("text")] string name = "")
    {
        if (Check.IsNullOrWhiteSpace(text))
        {
            return;
        }

        ThrowHelper.ThrowArgumentExceptionForIsNullOrWhiteSpace(text, name);
    }

    /// <summary>
    /// Asserts that the input <see cref="string"/> instance must be <see langword="null"/> or whitespace.
    /// </summary>
    /// <param name="text">The input <see cref="string"/> instance to test.</param>
    /// <param name="name">The name of the input parameter being tested.</param>
    /// <exception cref="ArgumentException">Thrown if <paramref name="text"/> is neither <see langword="null"/> nor whitespace.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Obsolete("Use " + nameof(IsNullOrWhiteSpace))]
    public static void IsNullOrWhitespace(string? text, [CallerArgumentExpression("text")] string name = "")
    {
        if (Check.IsNullOrWhiteSpace(text))
        {
            return;
        }

        ThrowHelper.ThrowArgumentExceptionForIsNullOrWhiteSpace(text, name);
    }

    /// <summary>
    /// Asserts that the input <see cref="string"/> instance must not be <see langword="null"/> or whitespace.
    /// </summary>
    /// <param name="text">The input <see cref="string"/> instance to test.</param>
    /// <param name="name">The name of the input parameter being tested.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="text"/> is <see langword="null"/>.</exception>
    /// <exception cref="ArgumentException">Thrown if <paramref name="text"/> is whitespace.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void IsNotNullOrWhiteSpace([NotNull] string? text, [CallerArgumentExpression("text")] string name = "")
    {
        if (Check.IsNotNullOrWhiteSpace(text))
        {
            return;
        }

        ThrowHelper.ThrowArgumentExceptionForIsNotNullOrWhiteSpace(text, name);
    }

    /// <summary>
    /// Asserts that the input <see cref="string"/> instance must not be <see langword="null"/> or whitespace.
    /// </summary>
    /// <param name="text">The input <see cref="string"/> instance to test.</param>
    /// <param name="name">The name of the input parameter being tested.</param>
    /// <exception cref="ArgumentException">Thrown if <paramref name="text"/> is <see langword="null"/> or whitespace.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Obsolete("Use " + nameof(IsNotNullOrWhiteSpace))]
    public static void IsNotNullOrWhitespace([NotNull] string? text, [CallerArgumentExpression("text")] string name = "")
    {
        if (Check.IsNotNullOrWhiteSpace(text))
        {
            return;
        }

        ThrowHelper.ThrowArgumentExceptionForIsNotNullOrWhiteSpace(text, name);
    }

    /// <summary>
    /// Asserts that the input <see cref="string"/> instance must be empty.
    /// </summary>
    /// <param name="text">The input <see cref="string"/> instance to test.</param>
    /// <param name="name">The name of the input parameter being tested.</param>
    /// <exception cref="ArgumentException">Thrown if <paramref name="text"/> is empty.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void IsEmpty(string text, [CallerArgumentExpression("text")] string name = "")
    {
        if (Check.IsEmpty(text))
        {
            return;
        }

        ThrowHelper.ThrowArgumentExceptionForIsEmpty(text, name);
    }

    /// <summary>
    /// Asserts that the input <see cref="string"/> instance must not be empty.
    /// </summary>
    /// <param name="text">The input <see cref="string"/> instance to test.</param>
    /// <param name="name">The name of the input parameter being tested.</param>
    /// <exception cref="ArgumentException">Thrown if <paramref name="text"/> is empty.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void IsNotEmpty(string text, [CallerArgumentExpression("text")] string name = "")
    {
        if (Check.IsNotEmpty(text))
        {
            return;
        }

        ThrowHelper.ThrowArgumentExceptionForIsNotEmpty(text, name);
    }

    /// <summary>
    /// Asserts that the input <see cref="string"/> instance must be whitespace.
    /// </summary>
    /// <param name="text">The input <see cref="string"/> instance to test.</param>
    /// <param name="name">The name of the input parameter being tested.</param>
    /// <exception cref="ArgumentException">Thrown if <paramref name="text"/> is neither <see langword="null"/> nor whitespace.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void IsWhiteSpace(string text, [CallerArgumentExpression("text")] string name = "")
    {
        if (Check.IsWhiteSpace(text))
        {
            return;
        }

        ThrowHelper.ThrowArgumentExceptionForIsWhiteSpace(text, name);
    }

    /// <summary>
    /// Asserts that the input <see cref="string"/> instance must be whitespace.
    /// </summary>
    /// <param name="text">The input <see cref="string"/> instance to test.</param>
    /// <param name="name">The name of the input parameter being tested.</param>
    /// <exception cref="ArgumentException">Thrown if <paramref name="text"/> is neither <see langword="null"/> nor whitespace.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Obsolete("Use " + nameof(IsWhiteSpace))]
    public static void IsWhitespace(string text, [CallerArgumentExpression("text")] string name = "")
    {
        if (Check.IsWhiteSpace(text))
        {
            return;
        }

        ThrowHelper.ThrowArgumentExceptionForIsWhiteSpace(text, name);
    }

    /// <summary>
    /// Asserts that the input <see cref="string"/> instance must not be <see langword="null"/> or whitespace.
    /// </summary>
    /// <param name="text">The input <see cref="string"/> instance to test.</param>
    /// <param name="name">The name of the input parameter being tested.</param>
    /// <exception cref="ArgumentException">Thrown if <paramref name="text"/> is <see langword="null"/> or whitespace.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void IsNotWhiteSpace(string text, [CallerArgumentExpression("text")] string name = "")
    {
        if (Check.IsNotWhiteSpace(text))
        {
            return;
        }

        ThrowHelper.ThrowArgumentExceptionForIsNotWhiteSpace(text, name);
    }

    /// <summary>
    /// Asserts that the input <see cref="string"/> instance must not be <see langword="null"/> or whitespace.
    /// </summary>
    /// <param name="text">The input <see cref="string"/> instance to test.</param>
    /// <param name="name">The name of the input parameter being tested.</param>
    /// <exception cref="ArgumentException">Thrown if <paramref name="text"/> is <see langword="null"/> or whitespace.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Obsolete("Use " + nameof(IsNotWhiteSpace))]
    public static void IsNotWhitespace(string text, [CallerArgumentExpression("text")] string name = "")
    {
        if (Check.IsNotWhiteSpace(text))
        {
            return;
        }

        ThrowHelper.ThrowArgumentExceptionForIsNotWhiteSpace(text, name);
    }

    /// <summary>
    /// Asserts that the input <see cref="string"/> instance must have a size of a specified value.
    /// </summary>
    /// <param name="text">The input <see cref="string"/> instance to check the size for.</param>
    /// <param name="size">The target size to test.</param>
    /// <param name="name">The name of the input parameter being tested.</param>
    /// <exception cref="ArgumentException">Thrown if the size of <paramref name="text"/> is != <paramref name="size"/>.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void HasSizeEqualTo(string text, int size, [CallerArgumentExpression("text")] string name = "")
    {
        if (Check.HasSizeEqualTo(text, size))
        {
            return;
        }

        ThrowHelper.ThrowArgumentExceptionForHasSizeEqualTo(text, size, name);
    }

    /// <summary>
    /// Asserts that the input <see cref="string"/> instance must have a size not equal to a specified value.
    /// </summary>
    /// <param name="text">The input <see cref="string"/> instance to check the size for.</param>
    /// <param name="size">The target size to test.</param>
    /// <param name="name">The name of the input parameter being tested.</param>
    /// <exception cref="ArgumentException">Thrown if the size of <paramref name="text"/> is == <paramref name="size"/>.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void HasSizeNotEqualTo(string text, int size, [CallerArgumentExpression("text")] string name = "")
    {
        if (Check.HasSizeNotEqualTo(text, size))
        {
            return;
        }

        ThrowHelper.ThrowArgumentExceptionForHasSizeNotEqualTo(text, size, name);
    }

    /// <summary>
    /// Asserts that the input <see cref="string"/> instance must have a size over a specified value.
    /// </summary>
    /// <param name="text">The input <see cref="string"/> instance to check the size for.</param>
    /// <param name="size">The target size to test.</param>
    /// <param name="name">The name of the input parameter being tested.</param>
    /// <exception cref="ArgumentException">Thrown if the size of <paramref name="text"/> is &lt;= <paramref name="size"/>.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void HasSizeGreaterThan(string text, int size, [CallerArgumentExpression("text")] string name = "")
    {
        if (Check.HasSizeGreaterThan(text, size))
        {
            return;
        }

        ThrowHelper.ThrowArgumentExceptionForHasSizeGreaterThan(text, size, name);
    }

    /// <summary>
    /// Asserts that the input <see cref="string"/> instance must have a size of at least specified value.
    /// </summary>
    /// <param name="text">The input <see cref="string"/> instance to check the size for.</param>
    /// <param name="size">The target size to test.</param>
    /// <param name="name">The name of the input parameter being tested.</param>
    /// <exception cref="ArgumentException">Thrown if the size of <paramref name="text"/> is &lt; <paramref name="size"/>.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void HasSizeGreaterThanOrEqualTo(string text, int size, [CallerArgumentExpression("text")] string name = "")
    {
        if (Check.HasSizeGreaterThanOrEqualTo(text, size))
        {
            return;
        }

        ThrowHelper.ThrowArgumentExceptionForHasSizeGreaterThanOrEqualTo(text, size, name);
    }

    /// <summary>
    /// Asserts that the input <see cref="string"/> instance must have a size of less than a specified value.
    /// </summary>
    /// <param name="text">The input <see cref="string"/> instance to check the size for.</param>
    /// <param name="size">The target size to test.</param>
    /// <param name="name">The name of the input parameter being tested.</param>
    /// <exception cref="ArgumentException">Thrown if the size of <paramref name="text"/> is >= <paramref name="size"/>.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void HasSizeLessThan(string text, int size, [CallerArgumentExpression("text")] string name = "")
    {
        if (Check.HasSizeLessThan(text, size))
        {
            return;
        }

        ThrowHelper.ThrowArgumentExceptionForHasSizeLessThan(text, size, name);
    }

    /// <summary>
    /// Asserts that the input <see cref="string"/> instance must have a size of less than or equal to a specified value.
    /// </summary>
    /// <param name="text">The input <see cref="string"/> instance to check the size for.</param>
    /// <param name="size">The target size to test.</param>
    /// <param name="name">The name of the input parameter being tested.</param>
    /// <exception cref="ArgumentException">Thrown if the size of <paramref name="text"/> is > <paramref name="size"/>.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void HasSizeLessThanOrEqualTo(string text, int size, [CallerArgumentExpression("text")] string name = "")
    {
        if (Check.HasSizeLessThanOrEqualTo(text, size))
        {
            return;
        }

        ThrowHelper.ThrowArgumentExceptionForHasSizeLessThanOrEqualTo(text, size, name);
    }

    /// <summary>
    /// Asserts that the source <see cref="string"/> instance must have the same size of a destination <see cref="string"/> instance.
    /// </summary>
    /// <param name="text">The source <see cref="string"/> instance to check the size for.</param>
    /// <param name="destination">The destination <see cref="string"/> instance to check the size for.</param>
    /// <param name="name">The name of the input parameter being tested.</param>
    /// <exception cref="ArgumentException">Thrown if the size of <paramref name="text"/> is != the one of <paramref name="destination"/>.</exception>
    /// <remarks>The <see cref="string"/> type is immutable, but the name of this API is kept for consistency with the other overloads.</remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void HasSizeEqualTo(string text, string destination, [CallerArgumentExpression("text")] string name = "")
    {
        if (Check.HasSizeEqualTo(text, destination))
        {
            return;
        }

        ThrowHelper.ThrowArgumentExceptionForHasSizeEqualTo(text, destination, name);
    }

    /// <summary>
    /// Asserts that the source <see cref="string"/> instance must have a size of less than or equal to that of a destination <see cref="string"/> instance.
    /// </summary>
    /// <param name="text">The source <see cref="string"/> instance to check the size for.</param>
    /// <param name="destination">The destination <see cref="string"/> instance to check the size for.</param>
    /// <param name="name">The name of the input parameter being tested.</param>
    /// <exception cref="ArgumentException">Thrown if the size of <paramref name="text"/> is > the one of <paramref name="destination"/>.</exception>
    /// <remarks>The <see cref="string"/> type is immutable, but the name of this API is kept for consistency with the other overloads.</remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void HasSizeLessThanOrEqualTo(string text, string destination, [CallerArgumentExpression("text")] string name = "")
    {
        if (Check.HasSizeLessThanOrEqualTo(text, destination))
        {
            return;
        }

        ThrowHelper.ThrowArgumentExceptionForHasSizeLessThanOrEqualTo(text, destination, name);
    }

    /// <summary>
    /// Asserts that the input index is valid for a given <see cref="string"/> instance.
    /// </summary>
    /// <param name="index">The input index to be used to access <paramref name="text"/>.</param>
    /// <param name="text">The input <see cref="string"/> instance to use to validate <paramref name="index"/>.</param>
    /// <param name="name">The name of the input parameter being tested.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="index"/> is not valid to access <paramref name="text"/>.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void IsInRangeFor(int index, string text, [CallerArgumentExpression("index")] string name = "")
    {
        if (Check.IsInRangeFor(index, text))
        {
            return;
        }

        ThrowHelper.ThrowArgumentOutOfRangeExceptionForIsInRangeFor(index, text, name);
    }

    /// <summary>
    /// Asserts that the input index is not valid for a given <see cref="string"/> instance.
    /// </summary>
    /// <param name="index">The input index to be used to access <paramref name="text"/>.</param>
    /// <param name="text">The input <see cref="string"/> instance to use to validate <paramref name="index"/>.</param>
    /// <param name="name">The name of the input parameter being tested.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="index"/> is valid to access <paramref name="text"/>.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void IsNotInRangeFor(int index, string text, [CallerArgumentExpression("index")] string name = "")
    {
        if (Check.IsNotInRangeFor(index, text))
        {
            return;
        }

        ThrowHelper.ThrowArgumentOutOfRangeExceptionForIsNotInRangeFor(index, text, name);
    }
}