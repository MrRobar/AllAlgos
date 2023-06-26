using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace AllAlgosCombined
{

    //[Config(typeof(AntiVirusFriendlyConfig))]
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class HeapVariantBenchmarks
    {

        private int[] valuesToCheck = new int[10_000];
        private static readonly HeapVariant heapVariant = new HeapVariant();
        private MinHeap _heap = new MinHeap(10);

        [GlobalSetup]
        public void Setup()
        {
            heapVariant.FillArrayRandomly(valuesToCheck);
        }

        [Benchmark]
        public void HeapBasedSearch()
        {
            heapVariant.InitialHeapFill(_heap, valuesToCheck);
            heapVariant.IterateThrowRemains(_heap, valuesToCheck);
            heapVariant.WriteTopValues(_heap, valuesToCheck);
        }
    }
}
