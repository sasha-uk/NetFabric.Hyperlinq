﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace NetFabric.Hyperlinq
{
    public static partial class Enumerable
    {
        public static RangeEnumerable Range(long start, long count)
        {
            if (count < 0) ThrowHelper.ThrowArgumentOutOfRangeException(nameof(count));

            var end = 0L;
            try
            {
                end = checked(start + count);
            }
            catch(OverflowException)
            {
                ThrowHelper.ThrowArgumentOutOfRangeException(nameof(count));
            }   

            return new RangeEnumerable(start, count, end);
        }

        public readonly struct RangeEnumerable
            : IValueReadOnlyList<long, RangeEnumerable.Enumerator>
        {
            readonly long start;
            readonly long count;
            readonly long end;

            internal RangeEnumerable(long start, long count, long end)
            {
                this.start = start;
                this.count = count;
                this.end = end;
            }

            public Enumerator GetEnumerator() => new Enumerator(in this);

            public long Count => count;

            public long this[long index]
            {
                get
                {
                    if (index < 0 || index >= count) ThrowHelper.ThrowIndexOutOfRangeException();

                    return index + start;
                }
            }

            public struct Enumerator
                : IValueEnumerator<long>
            {
                readonly long end;
                long current;

                internal Enumerator(in RangeEnumerable enumerable)
                {
                    current = enumerable.start - 1;
                    end = enumerable.end;
                }

                public long Current
                    => current;

                public bool MoveNext()
                    => ++this.current < end;

                public void Dispose() { }
            }

            public RangeEnumerable Skip(long count)
            {
                (var skipCount, var takeCount) = Utils.Skip(this.count, count);
                return Range(start + skipCount, takeCount);
            }

            public RangeEnumerable Take(long count)
                => Range(start, Utils.Take(this.count, count));

            public bool All(Func<long, long, bool> predicate)
                => ValueEnumerable.All<RangeEnumerable, Enumerator, long>(this, predicate);

            public bool Any()
                => count != 0;

            public bool Any(Func<long, long, bool> predicate)
                => ValueEnumerable.Any<RangeEnumerable, Enumerator, long>(this, predicate);

            public bool Contains(long value)
                => value >= start && value < start + count;

            public bool Contains(long value, IEqualityComparer<long> comparer)
                => ValueEnumerable.Contains<RangeEnumerable, Enumerator, long>(this, value, comparer);

            public ValueReadOnlyList.SelectEnumerable<RangeEnumerable, Enumerator, long, TResult> Select<TResult>(Func<long, long, TResult> selector) 
                => ValueReadOnlyList.Select<RangeEnumerable, Enumerator, long, TResult>(this, selector);

            public ValueReadOnlyList.SelectManyEnumerable<RangeEnumerable, Enumerator, long, TSubEnumerable, TSubEnumerator, TResult> SelectMany<TSubEnumerable, TSubEnumerator, TResult>(Func<long, TSubEnumerable> selector) 
                where TSubEnumerable : IValueEnumerable<TResult, TSubEnumerator>
                where TSubEnumerator : struct, IValueEnumerator<TResult>
                => ValueReadOnlyList.SelectMany<RangeEnumerable, Enumerator, long, TSubEnumerable, TSubEnumerator, TResult>(this, selector);

            public ValueReadOnlyList.WhereEnumerable<RangeEnumerable, Enumerator, long> Where(Func<long, long, bool> predicate) 
                => ValueReadOnlyList.Where<RangeEnumerable, Enumerator, long>(this, predicate);

            public long First() 
                => (count > 0) ? start : ThrowHelper.ThrowEmptySequence<int>();
            public long First(Func<long, long, bool> predicate) 
                => ValueReadOnlyList.First<RangeEnumerable, Enumerator, long>(this, predicate);

            public long FirstOrDefault()
                => (count > 0) ? start : default;
            public long FirstOrDefault(Func<long, long, bool> predicate) 
                => ValueReadOnlyList.FirstOrDefault<RangeEnumerable, Enumerator, long>(this, predicate);

            public long? FirstOrNull()
                => (count > 0) ? start : (long?)null;
            public long? FirstOrNull(Func<long, long, bool> predicate)
                => ValueReadOnlyList.FirstOrNull<RangeEnumerable, Enumerator, long>(this, predicate);

            public long Single()
                => (count == 0) ? ThrowHelper.ThrowEmptySequence<long>() : ((count == 1) ? start : ThrowHelper.ThrowNotSingleSequence<long>());
            public long Single(Func<long, long, bool> predicate) 
                => ValueReadOnlyList.Single<RangeEnumerable, Enumerator, long>(this, predicate);

            public long SingleOrDefault()
                => (count == 0) ? default : ((count == 1) ? start : ThrowHelper.ThrowNotSingleSequence<long>());
            public long SingleOrDefault(Func<long, long, bool> predicate) 
                => ValueReadOnlyList.SingleOrDefault<RangeEnumerable, Enumerator, long>(this, predicate);

            public long? SingleOrNull()
                => (count == 0) ? null : ((count == 1) ? start : ThrowHelper.ThrowNotSingleSequence<long?>());
            public long? SingleOrNull(Func<long, long, bool> predicate)
                => ValueReadOnlyList.SingleOrNull<RangeEnumerable, Enumerator, long>(this, predicate);

            public IReadOnlyList<long> AsEnumerable()
                => ValueReadOnlyList.AsEnumerable<RangeEnumerable, Enumerator, long>(this);

            public RangeEnumerable AsValueEnumerable()
                => this;
                
            public long[] ToArray()
            {
                var array = new long[count];
                for(long index = 0L, value = start; index < count; index++, value++)
                    array[index] = start + index;
                return array;
            }

            public List<long> ToList()
                => new List<long>(new ToListCollection(this));

            class ToListCollection
                : ICollection<long>
            {
                readonly long start;
                readonly long count;

                public ToListCollection(in RangeEnumerable source)
                {
                    this.start = source.start;
                    this.count = source.count;
                }

                public int Count => (int)count;

                public bool IsReadOnly => true;

                public void CopyTo(long[] array, int _)
                {
                    for(int index = 0; index < count; index++)
                        array[index] = start + index;
                }

                IEnumerator IEnumerable.GetEnumerator() => throw new NotSupportedException();
                IEnumerator<long> IEnumerable<long>.GetEnumerator() => throw new NotSupportedException();
                void ICollection<long>.Add(long item) => throw new NotSupportedException();
                bool ICollection<long>.Remove(long item) => throw new NotSupportedException();
                void ICollection<long>.Clear() => throw new NotSupportedException();
                bool ICollection<long>.Contains(long item) => throw new NotSupportedException();
            }
        }

        public static long Count(this RangeEnumerable source)
            => source.Count;

        public static long Count(this RangeEnumerable source, Func<long, long, bool> predicate)
            => ValueReadOnlyList.Count<RangeEnumerable, RangeEnumerable.Enumerator, long>(source, predicate);

        public static long? FirstOrNull(this RangeEnumerable source)
            => ValueReadOnlyList.FirstOrNull<RangeEnumerable, RangeEnumerable.Enumerator, long>(source);

        public static long? FirstOrNull(this RangeEnumerable source, Func<long, long, bool> predicate)
            => ValueReadOnlyList.FirstOrNull<RangeEnumerable, RangeEnumerable.Enumerator, long>(source, predicate);
        public static long? SingleOrNull(this RangeEnumerable source)
            => ValueReadOnlyList.SingleOrNull<RangeEnumerable, RangeEnumerable.Enumerator, long>(source);

        public static long? SingleOrNull(this RangeEnumerable source, Func<long, long, bool> predicate)
            => ValueReadOnlyList.SingleOrNull<RangeEnumerable, RangeEnumerable.Enumerator, long>(source, predicate);
    }
}

