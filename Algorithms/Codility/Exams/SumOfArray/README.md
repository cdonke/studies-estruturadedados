# Exercise

Given:
- N is an integer between 1 and 100


Create an array of size N, where the sum of its elements is 0 and they are unique.


# Benchmark

**Last update:** Mon Mar  8 13:09:01 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|                  Method |  N |     Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------ |--- |---------:|----------:|----------:|-------:|------:|------:|----------:|
| **&#39;Sum of Array equals 0&#39;** |  **2** | **2.444 μs** | **0.0241 μs** | **0.0226 μs** | **0.0153** |     **-** |     **-** |     **312 B** |
| **&#39;Sum of Array equals 0&#39;** |  **3** | **2.470 μs** | **0.0304 μs** | **0.0270 μs** | **0.0153** |     **-** |     **-** |     **320 B** |
| **&#39;Sum of Array equals 0&#39;** |  **4** | **2.548 μs** | **0.0134 μs** | **0.0126 μs** | **0.0153** |     **-** |     **-** |     **320 B** |
| **&#39;Sum of Array equals 0&#39;** | **10** | **2.833 μs** | **0.0160 μs** | **0.0150 μs** | **0.0153** |     **-** |     **-** |     **344 B** |
| **&#39;Sum of Array equals 0&#39;** | **20** | **3.402 μs** | **0.0263 μs** | **0.0246 μs** | **0.0191** |     **-** |     **-** |     **384 B** |
| **&#39;Sum of Array equals 0&#39;** | **70** | **9.455 μs** | **0.0983 μs** | **0.0920 μs** | **0.0305** |     **-** |     **-** |     **584 B** |
