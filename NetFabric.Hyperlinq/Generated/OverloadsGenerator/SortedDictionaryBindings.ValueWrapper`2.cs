using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace NetFabric.Hyperlinq
{
    public static partial class SortedDictionaryBindings
    {
        public readonly partial struct ValueWrapper<TKey,TValue>
        {
            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly bool All(System.Predicate<TSource> predicate)
            => NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.All<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource>(this,predicate);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly bool All(TPredicate predicate = default)
            => NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.All<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource,TPredicate>(this,predicate);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly bool All(NetFabric.Hyperlinq.PredicateAt<TSource> predicate)
            => NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.All<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource>(this,predicate);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly bool AllAt(TPredicate predicate = default)
            => NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.AllAt<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource,TPredicate>(this,predicate);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.Option<TSource> First()
            => NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.First<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource>(this);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.Option<TResult?> First(NetFabric.Hyperlinq.NullableSelector<TSource, TResult> selector)
            => NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.First<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource,TResult>(this,selector);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.Option<TResult?> First(NetFabric.Hyperlinq.NullableSelectorAt<TSource, TResult> selector)
            => NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.First<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource,TResult>(this,selector);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.SkipTakeEnumerable<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource> Skip(int count)
            => NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.Skip<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource>(this,count);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.Option<TSource> Single()
            => NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.Single<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource>(this);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.Option<TResult> Single(NetFabric.Hyperlinq.NullableSelector<TSource, TResult> selector)
            => NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.Single<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource,TResult>(this,selector);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.Option<TResult> Single(NetFabric.Hyperlinq.NullableSelectorAt<TSource, TResult> selector)
            => NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.Single<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource,TResult>(this,selector);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly bool Contains(TSource value)
            => NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.Contains<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource>(this,value);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly bool Contains(TSource value,System.Collections.Generic.IEqualityComparer<TSource>? comparer = default)
            => NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.Contains<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource>(this,value,comparer);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.SelectAtEnumerable<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource,TResult> Select(NetFabric.Hyperlinq.NullableSelectorAt<TSource, TResult> selector)
            => NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.Select<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource,TResult>(this,selector);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly System.Collections.Generic.Dictionary<TKey, TSource> ToDictionary(NetFabric.Hyperlinq.Selector<TSource, TKey> keySelector,System.Collections.Generic.IEqualityComparer<TKey>? comparer = default)
            => NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.ToDictionary<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource,TKey>(this,keySelector,comparer);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly System.Collections.Generic.Dictionary<TKey, TElement> ToDictionary(NetFabric.Hyperlinq.Selector<TSource, TKey> keySelector,NetFabric.Hyperlinq.NullableSelector<TSource, TElement> elementSelector,System.Collections.Generic.IEqualityComparer<TKey>? comparer = default)
            => NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.ToDictionary<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource,TKey,TElement>(this,keySelector,elementSelector,comparer);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.Option<TSource> ElementAt(int index)
            => NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.ElementAt<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource>(this,index);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.Option<TResult?> ElementAt(int index,NetFabric.Hyperlinq.NullableSelectorAt<TSource, TResult> selector)
            => NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.ElementAt<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource,TResult>(this,index,selector);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.SelectEnumerable<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource,TResult> Select(NetFabric.Hyperlinq.NullableSelector<TSource, TResult> selector)
            => NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.Select<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource,TResult>(this,selector);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly bool Any()
            => NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.Any<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource>(this);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly TSource[] ToArray()
            => NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.ToArray<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource>(this);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly System.Buffers.IMemoryOwner<TSource> ToArray(System.Buffers.MemoryPool<TSource> pool)
            => NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.ToArray<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource>(this,pool);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly System.Collections.Generic.List<TSource> ToList()
            => NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.ToList<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource>(this);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly System.Collections.Generic.List<TResult> ToList(NetFabric.Hyperlinq.NullableSelector<TSource, TResult> selector)
            => NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.ToList<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource,TResult>(this,selector);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly System.Collections.Generic.List<TResult> ToList(NetFabric.Hyperlinq.NullableSelectorAt<TSource, TResult> selector)
            => NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.ToList<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource,TResult>(this,selector);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.SkipTakeEnumerable<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource> Take(int count)
            => NetFabric.Hyperlinq.ValueReadOnlyCollectionExtensions.Take<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource>(this,count);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.ReadOnlyCollectionExtensions.ValueEnumerableWrapper<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource> AsValueEnumerable(System.Func<TEnumerable, TEnumerator> getEnumerator)
            => NetFabric.Hyperlinq.ReadOnlyCollectionExtensions.AsValueEnumerable<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource>(this,getEnumerator);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.ValueEnumerableExtensions.WhereEnumerable<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource,NetFabric.Hyperlinq.ValuePredicate<TSource>> Where(System.Predicate<TSource> predicate)
            => NetFabric.Hyperlinq.ValueEnumerableExtensions.Where<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource>(this,predicate);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.ValueEnumerableExtensions.WhereEnumerable<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource,TPredicate> Where(TPredicate predicate = default)
            => NetFabric.Hyperlinq.ValueEnumerableExtensions.Where<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource,TPredicate>(this,predicate);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.ValueEnumerableExtensions.AsyncValueEnumerableWrapper<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource> AsAsyncValueEnumerable()
            => NetFabric.Hyperlinq.ValueEnumerableExtensions.AsAsyncValueEnumerable<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource>(this);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.ValueEnumerableExtensions.SelectManyEnumerable<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource,TSubEnumerable,TSubEnumerator,TResult> SelectMany(NetFabric.Hyperlinq.Selector<TSource, TSubEnumerable> selector)
            => NetFabric.Hyperlinq.ValueEnumerableExtensions.SelectMany<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource,TSubEnumerable,TSubEnumerator,TResult>(this,selector);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly bool AnyAt(TPredicate predicate)
            => NetFabric.Hyperlinq.ValueEnumerableExtensions.AnyAt<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource,TPredicate>(this,predicate);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue> AsEnumerable()
            => NetFabric.Hyperlinq.ValueEnumerableExtensions.AsEnumerable<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource>(this);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.ValueEnumerableExtensions.WhereAtEnumerable<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource,NetFabric.Hyperlinq.ValuePredicateAt<TSource>> Where(NetFabric.Hyperlinq.PredicateAt<TSource> predicate)
            => NetFabric.Hyperlinq.ValueEnumerableExtensions.Where<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource>(this,predicate);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.ValueEnumerableExtensions.WhereAtEnumerable<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource,TPredicate> WhereAt(TPredicate predicate = default)
            => NetFabric.Hyperlinq.ValueEnumerableExtensions.WhereAt<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource,TPredicate>(this,predicate);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.ValueEnumerableExtensions.DistinctEnumerable<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource> Distinct(System.Collections.Generic.IEqualityComparer<TSource>? comparer = default)
            => NetFabric.Hyperlinq.ValueEnumerableExtensions.Distinct<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource>(this,comparer);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue> AsValueEnumerable()
            => NetFabric.Hyperlinq.ValueEnumerableExtensions.AsValueEnumerable<NetFabric.Hyperlinq.SortedDictionaryBindings.ValueWrapper<TKey, TValue>,System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator,TSource>(this);

        }

    }
}
