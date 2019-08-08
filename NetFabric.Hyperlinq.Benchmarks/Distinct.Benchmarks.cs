using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using System.Collections.Generic;

namespace NetFabric.Hyperlinq.Benchmarks
{
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
    [CategoriesColumn]
    [MemoryDiagnoser]
    [MarkdownExporterAttribute.GitHub]
    public class DistinctBenchmarks : BenchmarksBase
    {
        [BenchmarkCategory("Range")]
        [Benchmark(Baseline = true)]
        public int Linq_Range()
        {
            var count = 0;
            foreach (var item in System.Linq.Enumerable.Distinct(linqRange))
                count++;
            return count;
        }

        [BenchmarkCategory("LinkedList")]
        [Benchmark(Baseline = true)]
        public int Linq_LinkedList()
        {
            var count = 0;
            foreach (var item in System.Linq.Enumerable.Distinct(linkedList))
                count++;
            return count;
        }

        [BenchmarkCategory("Array")]
        [Benchmark(Baseline = true)]
        public int Linq_Array()
        {
            var count = 0;
            foreach (var item in System.Linq.Enumerable.Distinct(array))
                count++;
            return count;
        }

        [BenchmarkCategory("List")]
        [Benchmark(Baseline = true)]
        public int Linq_List()
        {
            var count = 0;
            foreach (var item in System.Linq.Enumerable.Distinct(list))
                count++;
            return count;
        }

        [BenchmarkCategory("Enumerable_Reference")]
        [Benchmark(Baseline = true)]
        public int Linq_Enumerable_Reference()
        {
            var count = 0;
            foreach (var item in System.Linq.Enumerable.Distinct(enumerableReference))
                count++;
            return count;
        }

        [BenchmarkCategory("Enumerable_Value")]
        [Benchmark(Baseline = true)]
        public int Linq_Enumerable_Value()
        {
            var count = 0;
            foreach (var item in System.Linq.Enumerable.Distinct(enumerableValue))
                count++;
            return count;
        }

        [BenchmarkCategory("Range")]
        [Benchmark]
        public int Hyperlinq_Range()
        {
            var count = 0;
            foreach (var item in hyperlinqRange.Distinct())
                count++;
            return count;
        }

        [BenchmarkCategory("LinkedList")]
        [Benchmark]
        public int Hyperlinq_LinkedList()
        {
            var count = 0;
            foreach (var item in linkedList.Distinct())
                count++;
            return count;
        }

        [BenchmarkCategory("Array")]
        [Benchmark]
        public int Hyperlinq_Array()
        {
            var count = 0;
            foreach (var item in array.Distinct())
                count++;
            return count;
        }

        [BenchmarkCategory("List")]
        [Benchmark]
        public int Hyperlinq_List()
        {
            var count = 0;
            foreach (var item in list.Distinct())
                count++;
            return count;
        }

        [BenchmarkCategory("Enumerable_Reference")]
        [Benchmark]
        public int Hyperlinq_Enumerable_Reference()
        {
            var count = 0;
            foreach (var item in enumerableReference.AsValueEnumerable().Distinct())
                count++;
            return count;
        }

        [BenchmarkCategory("Enumerable_Value")]
        [Benchmark]
        public int Hyperlinq_Enumerable_Value()
        {
            var count = 0;
            foreach (var item in enumerableValue.AsValueEnumerable<TestEnumerable.Enumerable, TestEnumerable.Enumerable.Enumerator, int>().Distinct())
                count++;
            return count;
        }

        public bool Equals(int x, int y)
            => x.Equals(y);

        public int GetHashCode(int obj)
            => obj.GetHashCode();
    }
}
