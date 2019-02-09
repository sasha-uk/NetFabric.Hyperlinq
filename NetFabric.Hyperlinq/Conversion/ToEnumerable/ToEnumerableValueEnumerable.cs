﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace NetFabric.Hyperlinq
{
    public static partial class ValueEnumerable
    {
        public static IEnumerable<TSource> ToEnumerable<TEnumerable, TEnumerator, TSource>(this TEnumerable source)
            where TEnumerable : IValueEnumerable<TSource, TEnumerator>
            where TEnumerator : struct, IValueEnumerator<TSource>
        {
            if (source == null) ThrowSourceNull();

            return new ToEnumerableEnumerable<TEnumerable, TEnumerator, TSource>(source);

            void ThrowSourceNull() => throw new ArgumentNullException(nameof(source));
        }

        class ToEnumerableEnumerable<TEnumerable, TEnumerator, TSource>
            : IEnumerable<TSource>
            where TEnumerable : IValueEnumerable<TSource, TEnumerator>
            where TEnumerator : struct, IValueEnumerator<TSource>
        {
            readonly TEnumerable source;

            internal ToEnumerableEnumerable(in TEnumerable source)
            {
                this.source = source;
            }

            public IEnumerator<TSource> GetEnumerator() => new Enumerator(this);
            IEnumerator IEnumerable.GetEnumerator() => new Enumerator(this);

            class Enumerator
                : IEnumerator<TSource>
            {
                TEnumerator enumerator;
                TSource current;

                internal Enumerator(ToEnumerableEnumerable<TEnumerable, TEnumerator, TSource> enumerable)
                {
                    enumerator = enumerable.source.GetValueEnumerator();
                }

                public TSource Current => current;
                object IEnumerator.Current => current;

                public bool MoveNext() => enumerator.TryMoveNext(out current);

                public void Reset() => throw new NotSupportedException();

                public void Dispose() => enumerator.Dispose();
            }
        }
    }
}
