using BenchmarkDotNet.Running;

namespace AllAlgosCombined
{
    class Program
    {
        static void Main(string[] args)
        {

            BenchmarkRunner.Run<MergeSortBenchmark>();
        }
    }
}