using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace NetFabric.Hyperlinq
{
    public static partial class AsyncValueEnumerableExtensions
    {
        public readonly partial struct WhereSelectEnumerable<TEnumerable,TEnumerator,TSource,TResult,TPredicate> where TEnumerable : notnull,NetFabric.Hyperlinq.IAsyncValueEnumerable<TSource, TEnumerator> where TEnumerator : struct,System.Collections.Generic.IAsyncEnumerator<TSource> where TPredicate : struct,NetFabric.Hyperlinq.IAsyncPredicate<TSource>
        {
            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.SkipEnumerable<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource> Skip(int count)
            => NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.Skip<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource>(this,count);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly System.Threading.Tasks.ValueTask<bool> ContainsAsync(TSource value,System.Threading.CancellationToken cancellationToken = default)
            => NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.ContainsAsync<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource>(this,value,cancellationToken);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly System.Threading.Tasks.ValueTask<bool> ContainsAsync(TSource value,System.Collections.Generic.IEqualityComparer<TSource>? comparer = default,System.Threading.CancellationToken cancellationToken = default)
            => NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.ContainsAsync<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource>(this,value,comparer,cancellationToken);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly System.Threading.Tasks.ValueTask<System.Buffers.IMemoryOwner<TSource>> ToArrayAsync(System.Buffers.MemoryPool<TSource> pool,System.Threading.CancellationToken cancellationToken = default)
            => NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.ToArrayAsync<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource>(this,pool,cancellationToken);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly System.Threading.Tasks.ValueTask<bool> AllAsync(NetFabric.Hyperlinq.AsyncPredicate<TSource> predicate,System.Threading.CancellationToken cancellationToken = default)
            => NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.AllAsync<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource>(this,predicate,cancellationToken);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly System.Threading.Tasks.ValueTask<bool> AllAsync(TPredicate predicate = default,System.Threading.CancellationToken cancellationToken = default)
            => NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.AllAsync<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource,TPredicate>(this,predicate,cancellationToken);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly System.Threading.Tasks.ValueTask<bool> AllAsync(NetFabric.Hyperlinq.AsyncPredicateAt<TSource> predicate,System.Threading.CancellationToken cancellationToken = default)
            => NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.AllAsync<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource>(this,predicate,cancellationToken);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly System.Threading.Tasks.ValueTask<bool> AllAtAsync(TPredicate predicate = default,System.Threading.CancellationToken cancellationToken = default)
            => NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.AllAtAsync<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource,TPredicate>(this,predicate,cancellationToken);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.SelectAtEnumerable<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource,TResult> Select(NetFabric.Hyperlinq.AsyncSelectorAt<TSource, TResult> selector)
            => NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.Select<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource,TResult>(this,selector);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereEnumerable<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource,NetFabric.Hyperlinq.AsyncValuePredicate<TSource>> Where(NetFabric.Hyperlinq.AsyncPredicate<TSource> predicate)
            => NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.Where<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource>(this,predicate);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereEnumerable<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource,TPredicate> Where(TPredicate predicate = default)
            => NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.Where<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource,TPredicate>(this,predicate);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate> AsAsyncValueEnumerable()
            => NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.AsAsyncValueEnumerable<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource>(this);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereAtEnumerable<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource,NetFabric.Hyperlinq.AsyncValuePredicateAt<TSource>> Where(NetFabric.Hyperlinq.AsyncPredicateAt<TSource> predicate)
            => NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.Where<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource>(this,predicate);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereAtEnumerable<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource,TPredicate> WhereAt(TPredicate predicate = default)
            => NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereAt<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource,TPredicate>(this,predicate);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly System.Threading.Tasks.ValueTask<TSource[]> ToArrayBuilderAsync(System.Threading.CancellationToken cancellationToken = default)
            => NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.ToArrayBuilderAsync<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource>(this,cancellationToken);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly System.Threading.Tasks.ValueTask<System.Buffers.IMemoryOwner<TSource>> ToArrayBuilderAsync(System.Buffers.MemoryPool<TSource> pool,System.Threading.CancellationToken cancellationToken = default)
            => NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.ToArrayBuilderAsync<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource>(this,pool,cancellationToken);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.TakeEnumerable<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource> Take(int count)
            => NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.Take<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource>(this,count);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly System.Threading.Tasks.ValueTask<NetFabric.Hyperlinq.Option<TResult>> FirstAsync(NetFabric.Hyperlinq.AsyncSelector<TSource, TResult> selector,System.Threading.CancellationToken cancellationToken)
            => NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.FirstAsync<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource,TResult>(this,selector,cancellationToken);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly System.Threading.Tasks.ValueTask<NetFabric.Hyperlinq.Option<TResult>> FirstAsync(NetFabric.Hyperlinq.AsyncSelectorAt<TSource, TResult> selector,System.Threading.CancellationToken cancellationToken)
            => NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.FirstAsync<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource,TResult>(this,selector,cancellationToken);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.DistinctEnumerable<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource> Distinct(System.Collections.Generic.IEqualityComparer<TSource>? comparer = default)
            => NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.Distinct<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource>(this,comparer);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.SelectEnumerable<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource,TResult> Select(NetFabric.Hyperlinq.AsyncSelector<TSource, TResult> selector)
            => NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.Select<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource,TResult>(this,selector);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly System.Threading.Tasks.ValueTask<System.Collections.Generic.Dictionary<TKey, TSource>> ToDictionaryAsync(NetFabric.Hyperlinq.AsyncSelector<TSource, TKey> keySelector,System.Threading.CancellationToken cancellationToken = default)
            => NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.ToDictionaryAsync<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource,TKey>(this,keySelector,cancellationToken);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly System.Threading.Tasks.ValueTask<System.Collections.Generic.Dictionary<TKey, TSource>> ToDictionaryAsync(NetFabric.Hyperlinq.AsyncSelector<TSource, TKey> keySelector,System.Collections.Generic.IEqualityComparer<TKey>? comparer,System.Threading.CancellationToken cancellationToken = default)
            => NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.ToDictionaryAsync<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource,TKey>(this,keySelector,comparer,cancellationToken);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly System.Threading.Tasks.ValueTask<System.Collections.Generic.Dictionary<TKey, TElement>> ToDictionaryAsync(NetFabric.Hyperlinq.AsyncSelector<TSource, TKey> keySelector,NetFabric.Hyperlinq.AsyncSelector<TSource, TElement> elementSelector,System.Threading.CancellationToken cancellationToken = default)
            => NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.ToDictionaryAsync<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource,TKey,TElement>(this,keySelector,elementSelector,cancellationToken);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly System.Threading.Tasks.ValueTask<System.Collections.Generic.Dictionary<TKey, TElement>> ToDictionaryAsync(NetFabric.Hyperlinq.AsyncSelector<TSource, TKey> keySelector,NetFabric.Hyperlinq.AsyncSelector<TSource, TElement> elementSelector,System.Collections.Generic.IEqualityComparer<TKey>? comparer,System.Threading.CancellationToken cancellationToken = default)
            => NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.ToDictionaryAsync<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource,TKey,TElement>(this,keySelector,elementSelector,comparer,cancellationToken);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate> AsAsyncEnumerable()
            => NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.AsAsyncEnumerable<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource>(this);

            [GeneratedCode("NetFabric.Hyperlinq.SourceGenerator", "1.0.0")]
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly NetFabric.Hyperlinq.AsyncEnumerableExtensions.AsyncValueEnumerableWrapper<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource> AsAsyncValueEnumerable(System.Func<TEnumerable, System.Threading.CancellationToken, TEnumerator> getAsyncEnumerator)
            => NetFabric.Hyperlinq.AsyncEnumerableExtensions.AsAsyncValueEnumerable<NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>,NetFabric.Hyperlinq.AsyncValueEnumerableExtensions.WhereSelectEnumerable<TEnumerable, TEnumerator, TSource, TResult, TPredicate>.Enumerator,TSource>(this,getAsyncEnumerator);

        }

    }
}
