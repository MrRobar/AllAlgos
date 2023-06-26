using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using NUnit.Framework;

namespace AllAlgosCombined
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class MergeSortBenchmark
    {

        private int[] valuesToCheck = new int[10_000];
        private static readonly MergeSortVariant mergeSortVariant = new MergeSortVariant();

        [SetUp]
        public void Setup()
        {
            mergeSortVariant.FillArrayRandomly(valuesToCheck);
        }

        [Benchmark]
        public void RunMergeSort()
        {
            mergeSortVariant.MergeSort(valuesToCheck, 0, valuesToCheck.Length - 1);
        }
    }
}