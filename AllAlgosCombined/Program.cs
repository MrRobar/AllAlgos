using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.InProcess.Emit;
using System;

namespace AllAlgosCombined
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<SortingBenchmarks>();
            Console.Read();
        }
    }
}