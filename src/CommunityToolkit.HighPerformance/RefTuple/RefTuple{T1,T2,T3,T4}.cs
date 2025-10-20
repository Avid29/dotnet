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
/// <typeparam name="T3">The type of the third value.</typeparam>
/// <typeparam name="T4">The type of the fourth value.</typeparam>
public ref struct RefTuple<T1,T2,T3,T4>
    where T1 : allows ref struct
    where T2 : allows ref struct
    where T3 : allows ref struct
    where T4 : allows ref struct
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RefTuple{T1, T2, T3}"/> struct.
    /// </summary>
    public RefTuple(T1 t1, T2 t2, T3 t3, T4 t4)
    {
        Item1 = t1;
        Item2 = t2;
        Item3 = t3;
        Item4 = t4;
    }

    /// <summary>
    /// The first item in the ref tuple.
    /// </summary>
    public T1 Item1 { get; set; }

    /// <summary>
    /// The second item in the ref tuple.
    /// </summary>
    public T2 Item2 { get; set; }

    /// <summary>
    /// The third item in the ref tuple.
    /// </summary>
    public T3 Item3 { get; set; }

    /// <summary>
    /// The fourth item in the ref tuple.
    /// </summary>
    public T4 Item4 { get; set; }

    /// <inheritdoc/>
    public readonly void Deconstruct(out T1 item1, out T2 item2, out T3 item3, out T4 item4)
    {
        item1 = Item1;
        item2 = Item2;
        item3 = Item3;
        item4 = Item4;
    }
}

#endif
