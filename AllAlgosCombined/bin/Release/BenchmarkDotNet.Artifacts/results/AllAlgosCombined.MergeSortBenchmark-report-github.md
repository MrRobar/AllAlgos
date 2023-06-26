``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1848/22H2/2022Update/SunValley2)
11th Gen Intel Core i5-11400H 2.70GHz, 1 CPU, 12 logical and 6 physical cores
  [Host] : .NET Framework 4.8.1 (4.8.9166.0), X86 LegacyJIT

Job=MediumRun  Toolchain=InProcessNoEmitToolchain  IterationCount=15  
LaunchCount=2  WarmupCount=10  

```
|          Method |      Mean |     Error |    StdDev | Rank |     Gen0 | Allocated |
|---------------- |----------:|----------:|----------:|-----:|---------:|----------:|
| RunStandardSort |  74.30 μs |  1.287 μs |  1.926 μs |    1 |        - |         - |
|    RunMergeSort | 440.37 μs | 12.697 μs | 19.005 μs |    2 | 124.5117 |  655331 B |
