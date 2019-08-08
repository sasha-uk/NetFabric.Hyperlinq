using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;

namespace NetFabric.Hyperlinq.Benchmarks
{
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
    [CategoriesColumn]
    [MemoryDiagnoser]
    [MarkdownExporterAttribute.GitHub]
    public class SelectToArrayBenchmarks : BenchmarksBase
    {
        [BenchmarkCategory("Range")]
        [Benchmark(Baseline = true)]
        public int[] Linq_Range() 
            => System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select(linqRange, item => item));

        [BenchmarkCategory("LinkedList")]
        [Benchmark(Baseline = true)]
        public int[] Linq_LinkedList() 
            => System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select(linkedList, item => item));

        [BenchmarkCategory("Array")]
        [Benchmark(Baseline = true)]
        public int[] Linq_Array() 
            => System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select(array, item => item));

        [BenchmarkCategory("List")]
        [Benchmark(Baseline = true)]
        public int[] Linq_List() 
            => System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select(list, item => item));

        [BenchmarkCategory("Range")]
        [Benchmark]
        public int[] Hyperlinq_Range() 
            => hyperlinqRange.Select(item => item).ToArray();

        [BenchmarkCategory("LinkedList")]
        [Benchmark]
        public int[] Hyperlinq_LinkedList() 
            => linkedList.Select(item => item).ToArray();

        [BenchmarkCategory("Array")]
        [Benchmark]
        public int[] Hyperlinq_Array() 
            => array.Select(item => item).ToArray();

        [BenchmarkCategory("List")]
        [Benchmark]
        public int[] Hyperlinq_List() 
            => list.Select(item => item).ToArray();

        [BenchmarkCategory("Enumerable_Reference")]
        [Benchmark]
        public int[] Hyperlinq_Enumerable_Reference()
            => enumerableReference.AsValueEnumerable().Select(item => item).ToArray();

        [BenchmarkCategory("Enumerable_Value")]
        [Benchmark]
        public int[] Hyperlinq_Enumerable_Value()        
            => enumerableValue.AsValueEnumerable<TestEnumerable.Enumerable, TestEnumerable.Enumerable.Enumerator, int>().Select(item => item).ToArray();
    }
}
