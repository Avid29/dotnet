// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace CommunityToolkit.HighPerformance.RefTuple;

#if NET9_0_OR_GREATER

/// <summary>
/// A two value pair represented as a <see langword="ref struct"/>.
/// </summary>
/// <typeparam name="T1">The type of the first value.</typeparam>
/// <typeparam name="T2">The type of the second value.</typeparam>
public ref struct RefTuple<T1,T2>
    where T1 : allows ref struct
    where T2 : allows ref struct
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RefTuple{T1, T2}"/> struct.
    /// </summary>
    public RefTuple(T1 t1, T2 t2)
    {
        Item1 = t1;
        Item2 = t2;
    }

    /// <summary>
    /// The first item in the ref tuple.
    /// </summary>
    public T1 Item1 { get; set; }

    /// <summary>
    /// The second item in the ref tuple.
    /// </summary>
    public T2 Item2 { get; set; }

    /// <inheritdoc/>
    public readonly void Deconstruct(out T1 item1, out T2 item2)
    {
        item1 = Item1;
        item2 = Item2;
    }
}

#endif