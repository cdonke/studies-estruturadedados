``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 18.04
Intel Xeon CPU E5-2673 v3 2.40GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host] : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


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