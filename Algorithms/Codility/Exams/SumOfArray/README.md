# Exercise

Given:
- N is an integer between 1 and 100


Create an array of size N, where the sum of its elements is 0 and they are unique.


# Benchmark

**Last update:** Tue May 25 19:55:36 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.409
  [Host] : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|         Method |   N | Mean | Error |
|--------------- |---- |-----:|------:|
|   **&#39;With array&#39;** |   **2** |   **NA** |    **NA** |
| &#39;With HashSet&#39; |   2 |   NA |    NA |
|   **&#39;With array&#39;** |   **3** |   **NA** |    **NA** |
| &#39;With HashSet&#39; |   3 |   NA |    NA |
|   **&#39;With array&#39;** |   **4** |   **NA** |    **NA** |
| &#39;With HashSet&#39; |   4 |   NA |    NA |
|   **&#39;With array&#39;** |  **10** |   **NA** |    **NA** |
| &#39;With HashSet&#39; |  10 |   NA |    NA |
|   **&#39;With array&#39;** |  **20** |   **NA** |    **NA** |
| &#39;With HashSet&#39; |  20 |   NA |    NA |
|   **&#39;With array&#39;** |  **70** |   **NA** |    **NA** |
| &#39;With HashSet&#39; |  70 |   NA |    NA |
|   **&#39;With array&#39;** | **100** |   **NA** |    **NA** |
| &#39;With HashSet&#39; | 100 |   NA |    NA |

Benchmarks with issues:
  SumOfArray.'With array': DefaultJob [N=2]
  SumOfArray.'With HashSet': DefaultJob [N=2]
  SumOfArray.'With array': DefaultJob [N=3]
  SumOfArray.'With HashSet': DefaultJob [N=3]
  SumOfArray.'With array': DefaultJob [N=4]
  SumOfArray.'With HashSet': DefaultJob [N=4]
  SumOfArray.'With array': DefaultJob [N=10]
  SumOfArray.'With HashSet': DefaultJob [N=10]
  SumOfArray.'With array': DefaultJob [N=20]
  SumOfArray.'With HashSet': DefaultJob [N=20]
  SumOfArray.'With array': DefaultJob [N=70]
  SumOfArray.'With HashSet': DefaultJob [N=70]
  SumOfArray.'With array': DefaultJob [N=100]
  SumOfArray.'With HashSet': DefaultJob [N=100]
