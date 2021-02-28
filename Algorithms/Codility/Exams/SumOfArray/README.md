# Exercise

Given:
- N is an integer between 1 and 100


Create an array of size N, where the sum of its elements is 0 and they are unique.


# Benchmark

**Last update:** Sun Feb 28 15:31:34 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 18.04
Intel Xeon CPU E5-2673 v3 2.40GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|                  Method |  N |     Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------ |--- |---------:|----------:|----------:|-------:|------:|------:|----------:|
| **&#39;Sum of Array equals 0&#39;** |  **2** | **2.317 μs** | **0.0339 μs** | **0.0317 μs** | **0.0191** |     **-** |     **-** |     **312 B** |
| **&#39;Sum of Array equals 0&#39;** |  **3** | **2.358 μs** | **0.0269 μs** | **0.0239 μs** | **0.0191** |     **-** |     **-** |     **320 B** |
| **&#39;Sum of Array equals 0&#39;** |  **4** | **2.393 μs** | **0.0259 μs** | **0.0230 μs** | **0.0191** |     **-** |     **-** |     **320 B** |
| **&#39;Sum of Array equals 0&#39;** | **10** | **2.626 μs** | **0.0462 μs** | **0.0433 μs** | **0.0191** |     **-** |     **-** |     **344 B** |
| **&#39;Sum of Array equals 0&#39;** | **20** | **3.114 μs** | **0.0429 μs** | **0.0401 μs** | **0.0229** |     **-** |     **-** |     **384 B** |
| **&#39;Sum of Array equals 0&#39;** | **70** | **7.506 μs** | **0.1119 μs** | **0.0992 μs** | **0.0305** |     **-** |     **-** |     **584 B** |
