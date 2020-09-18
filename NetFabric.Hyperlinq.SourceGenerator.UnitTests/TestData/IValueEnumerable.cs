﻿using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace NetFabric.Hyperlinq
{
    public interface IValueEnumerable<out T, TEnumerator>
        : IEnumerable<T>
        where TEnumerator
        : struct
        , IEnumerator<T>
    {
        [return: NotNull] new TEnumerator GetEnumerator();
    }
}
