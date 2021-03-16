# Exercise

Given:
- N is an integer between 1 and 100


Create an array of size N, where the sum of its elements is 0 and they are unique.


# Benchmark

**Last update:** Tue Mar 16 12:06:48 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host] : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|                  Method |  N | Mean | Error |
|------------------------ |--- |-----:|------:|
| **&#39;Sum of Array equals 0&#39;** |  **2** |   **NA** |    **NA** |
| **&#39;Sum of Array equals 0&#39;** |  **3** |   **NA** |    **NA** |
| **&#39;Sum of Array equals 0&#39;** |  **4** |   **NA** |    **NA** |
| **&#39;Sum of Array equals 0&#39;** | **10** |   **NA** |    **NA** |
| **&#39;Sum of Array equals 0&#39;** | **20** |   **NA** |    **NA** |
| **&#39;Sum of Array equals 0&#39;** | **70** |   **NA** |    **NA** |

Benchmarks with issues:
  SumOfArray.'Sum of Array equals 0': DefaultJob [N=2]
  SumOfArray.'Sum of Array equals 0': DefaultJob [N=3]
  SumOfArray.'Sum of Array equals 0': DefaultJob [N=4]
  SumOfArray.'Sum of Array equals 0': DefaultJob [N=10]
  SumOfArray.'Sum of Array equals 0': DefaultJob [N=20]
  SumOfArray.'Sum of Array equals 0': DefaultJob [N=70]
