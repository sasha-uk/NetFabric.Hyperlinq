using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace NetFabric.Hyperlinq
{
    public static partial class ArrayExtensions
    {
        public static bool Contains<TList, TSource>(this ReadOnlySpan<TSource> source, [AllowNull] TSource value)
            where TSource : struct
        {
            for (var index = 0; index < source.Length; index++)
            {
                if (EqualityComparer<TSource>.Default.Equals(source[index], value!))
                    return true;
            }
            return false;
        }

        public static bool Contains<TSource>(this ReadOnlySpan<TSource> source, [AllowNull] TSource value, IEqualityComparer<TSource>? comparer = null)
        {
            if (source.Length == 0)
                return false;

            if (Utils.UseDefault(comparer))
                return DefaultContains(source, value!);

            comparer ??= EqualityComparer<TSource>.Default;
            return ComparerContains(source, value, comparer);

            static bool DefaultContains(ReadOnlySpan<TSource> source, [AllowNull] TSource value)
            {
                for (var index = 0; index < source.Length; index++)
                {
                    if (EqualityComparer<TSource>.Default.Equals(source[index], value!))
                        return true;
                }
                return false;
            }

            static bool ComparerContains(ReadOnlySpan<TSource> source, [AllowNull] TSource value, IEqualityComparer<TSource> comparer)
            {
                for (var index = 0; index < source.Length; index++)
                {
                    if (comparer.Equals(source[index], value!))
                        return true;
                }
                return false;
            }
        }


        static bool Contains<TSource, TResult>(this ReadOnlySpan<TSource> source, [AllowNull] TResult value, NullableSelector<TSource, TResult> selector)
        {
            return source.Length switch
            {
                0 => false,
                _ => Utils.IsValueType<TResult>()
                    ? ValueContains(source, value, selector)
                    : ReferenceContains(source, value, selector)
            };

            static bool ValueContains(ReadOnlySpan<TSource> source, [AllowNull] TResult value, NullableSelector<TSource, TResult> selector)
            {
                for (var index = 0; index < source.Length; index++)
                {
                    if (EqualityComparer<TResult>.Default.Equals(selector(source[index])!, value!))
                        return true;
                }
                return false;
            }

            static bool ReferenceContains(ReadOnlySpan<TSource> source, [AllowNull] TResult value, NullableSelector<TSource, TResult> selector)
            {
                var defaultComparer = EqualityComparer<TResult>.Default;

                for (var index = 0; index < source.Length; index++)
                {
                    if (defaultComparer.Equals(selector(source[index])!, value!))
                        return true;
                }
                return false;
            }
        }


        static bool Contains<TSource, TResult>(this ReadOnlySpan<TSource> source, [AllowNull] TResult value, NullableSelectorAt<TSource, TResult> selector)
        {
            return source.Length switch
            {
                0 => false,
                _ => Utils.IsValueType<TResult>()
                    ? ValueContains(source, value, selector)
                    : ReferenceContains(source, value, selector),
            };

            static bool ValueContains(ReadOnlySpan<TSource> source, [AllowNull] TResult value, NullableSelectorAt<TSource, TResult> selector)
            {
                for (var index = 0; index < source.Length; index++)
                {
                    if (EqualityComparer<TResult>.Default.Equals(selector(source[index], index)!, value!))
                        return true;
                }
                return false;
            }

            static bool ReferenceContains(ReadOnlySpan<TSource> source, [AllowNull] TResult value, NullableSelectorAt<TSource, TResult> selector)
            {
                var defaultComparer = EqualityComparer<TResult>.Default;

                for (var index = 0; index < source.Length; index++)
                {
                    if (defaultComparer.Equals(selector(source[index], index)!, value!))
                        return true;
                }
                return false;
            }
        }
    }
}

