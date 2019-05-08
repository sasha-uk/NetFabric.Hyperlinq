﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace NetFabric.Hyperlinq
{
    public static partial class ReadOnlyList
    {
        public static WhereEnumerable<TEnumerable, TSource> Where<TEnumerable, TSource>(this TEnumerable source, Func<TSource, long, bool> predicate) 
            where TEnumerable : IReadOnlyList<TSource>
        {
            if (predicate is null) ThrowHelper.ThrowArgumentNullException(nameof(predicate));

            return new WhereEnumerable<TEnumerable, TSource>(in source, predicate);
        }

        public readonly struct WhereEnumerable<TEnumerable, TSource>
            : IValueEnumerable<TSource, WhereEnumerable<TEnumerable, TSource>.Enumerator>
            where TEnumerable : IReadOnlyList<TSource>
        {
            internal readonly TEnumerable source;
            internal readonly Func<TSource, long, bool> predicate;

            internal WhereEnumerable(in TEnumerable source, Func<TSource, long, bool> predicate)
            {
                this.source = source;
                this.predicate = predicate;
            }

            public Enumerator GetEnumerator() => new Enumerator(in this);

            public struct Enumerator
                : IValueEnumerator<TSource>
            {
                readonly TEnumerable source;
                readonly Func<TSource, long, bool> predicate;
                readonly int count;
                int index;

                internal Enumerator(in WhereEnumerable<TEnumerable, TSource> enumerable)
                {
                    source = enumerable.source;
                    predicate = enumerable.predicate;
                    count = enumerable.source.Count;
                    index = -1;
                }

                public TSource Current
                    => source[index];

                public bool MoveNext()
                {
                    while (++index < count)
                    {
                        if (predicate(source[index], index))
                            return true;
                    }
                    return false;
                }

                public void Dispose() { }
            }

            public long Count()
                => ReadOnlyList.Count<TEnumerable, TSource>(source, predicate);

            public long Count(Func<TSource, long, bool> predicate)
                => ValueEnumerable.Count<WhereEnumerable<TEnumerable, TSource>, Enumerator, TSource>(this, predicate);

            public ValueEnumerable.SkipEnumerable<WhereEnumerable<TEnumerable, TSource>, Enumerator, TSource> Skip(int count)
                => ValueEnumerable.Skip<WhereEnumerable<TEnumerable, TSource>, Enumerator, TSource>(this, count);

            public ValueEnumerable.TakeEnumerable<WhereEnumerable<TEnumerable, TSource>, Enumerator, TSource> Take(int count)
                => ValueEnumerable.Take<WhereEnumerable<TEnumerable,  TSource>, Enumerator, TSource>(this, count);

            public bool All(Func<TSource, long, bool> predicate)
                => ValueEnumerable.All<WhereEnumerable<TEnumerable, TSource>, Enumerator, TSource>(this, predicate);

            public bool Any()
                => ReadOnlyList.Any<TEnumerable, TSource>(source, predicate);

            public bool Any(Func<TSource, long, bool> predicate)
                => ValueEnumerable.Any<WhereEnumerable<TEnumerable, TSource>, Enumerator, TSource>(this, predicate);

            public bool Contains(TSource value)
                => ValueEnumerable.Contains<WhereEnumerable<TEnumerable, TSource>, Enumerator, TSource>(this, value);

            public bool Contains(TSource value, IEqualityComparer<TSource> comparer)
                => ValueEnumerable.Contains<WhereEnumerable<TEnumerable, TSource>, Enumerator, TSource>(this, value, comparer);

            public ReadOnlyList.WhereSelectEnumerable<TEnumerable, TSource, TResult> Select<TResult>(Func<TSource, long, TResult> selector)
                => ReadOnlyList.WhereSelect<TEnumerable, TSource, TResult>(source, predicate, selector);

            public ValueEnumerable.SelectManyEnumerable<WhereEnumerable<TEnumerable, TSource>, Enumerator, TSource, TSubEnumerable, TSubEnumerator, TResult> SelectMany<TSubEnumerable, TSubEnumerator, TResult>(Func<TSource, TSubEnumerable> selector) 
                where TSubEnumerable : IValueEnumerable<TResult, TSubEnumerator>
                where TSubEnumerator : struct, IValueEnumerator<TResult>
                => ValueEnumerable.SelectMany<WhereEnumerable<TEnumerable, TSource>, Enumerator, TSource, TSubEnumerable, TSubEnumerator, TResult>(this, selector);

            public ReadOnlyList.WhereEnumerable<TEnumerable, TSource> Where(Func<TSource, long, bool> predicate)
            {
                var currentPredicate = this.predicate;
                return ReadOnlyList.Where<TEnumerable, TSource>(source, CombinedPredicates);

                bool CombinedPredicates(TSource item, long index) 
                    => currentPredicate(item, index) && predicate(item, index);
            }

            public TSource First()
                => ReadOnlyList.First<TEnumerable, TSource>(source, predicate);
            public TSource First(Func<TSource, long, bool> predicate)
                => ValueEnumerable.First<WhereEnumerable<TEnumerable, TSource>, Enumerator, TSource>(this, predicate);

            public TSource FirstOrDefault()
                => ReadOnlyList.FirstOrDefault<TEnumerable, TSource>(source, predicate);
            public TSource FirstOrDefault(Func<TSource, long, bool> predicate)
                => ValueEnumerable.FirstOrDefault<WhereEnumerable<TEnumerable, TSource>, Enumerator, TSource>(this, predicate);

            public TSource Single()
                => ReadOnlyList.Single<TEnumerable, TSource>(source, predicate);
            public TSource Single(Func<TSource, long, bool> predicate)
                => ValueEnumerable.Single<WhereEnumerable<TEnumerable, TSource>, Enumerator, TSource>(this, predicate);

            public TSource SingleOrDefault()
                => ReadOnlyList.SingleOrDefault<TEnumerable, TSource>(source, predicate);
            public TSource SingleOrDefault(Func<TSource, long, bool> predicate)
                => ValueEnumerable.SingleOrDefault<WhereEnumerable<TEnumerable, TSource>, Enumerator, TSource>(this, predicate);

            public IEnumerable<TSource> AsEnumerable()
                => ValueEnumerable.AsEnumerable<WhereEnumerable<TEnumerable, TSource>, Enumerator, TSource>(this);

            public WhereEnumerable<TEnumerable, TSource> AsValueEnumerable()
                => this;

            public TSource[] ToArray()
                => ValueEnumerable.ToArray<WhereEnumerable<TEnumerable, TSource>, Enumerator, TSource>(this);

            public List<TSource> ToList()
                => ValueEnumerable.ToList<WhereEnumerable<TEnumerable, TSource>, Enumerator, TSource>(this);
        }

        public static TSource? FirstOrNull<TEnumerable, TSource>(this WhereEnumerable<TEnumerable, TSource> source)
            where TEnumerable : IReadOnlyList<TSource>
            where TSource : struct
            => ReadOnlyList.FirstOrNull<TEnumerable, TSource>(source.source, source.predicate);

        public static TSource? FirstOrNull<TEnumerable, TSource>(this WhereEnumerable<TEnumerable, TSource> source, Func<TSource, long, bool> predicate)
            where TEnumerable : IReadOnlyList<TSource>
            where TSource : struct
            => ValueEnumerable.FirstOrNull<WhereEnumerable<TEnumerable, TSource>, WhereEnumerable<TEnumerable, TSource>.Enumerator, TSource>(source, predicate);

        public static TSource? SingleOrNull<TEnumerable, TSource>(this WhereEnumerable<TEnumerable,TSource> source)
            where TEnumerable : IReadOnlyList<TSource>
            where TSource : struct
            => ReadOnlyList.SingleOrNull<TEnumerable, TSource>(source.source, source.predicate);

        public static TSource? SingleOrNull<TEnumerable, TSource>(this WhereEnumerable<TEnumerable, TSource> source, Func<TSource, long, bool> predicate)
            where TEnumerable : IReadOnlyList<TSource>
            where TSource : struct
            => ValueEnumerable.SingleOrNull<WhereEnumerable<TEnumerable, TSource>, WhereEnumerable<TEnumerable, TSource>.Enumerator, TSource>(source, predicate);
    }
}

