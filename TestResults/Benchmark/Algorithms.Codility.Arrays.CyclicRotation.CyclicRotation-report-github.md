``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 18.04
Intel Xeon CPU E5-2673 v3 2.40GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host] : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|    Method |        A | K | Mean | Error |
|---------- |--------- |-- |-----:|------:|
|  **FirstTry** | **Int32[3]** | **1** |   **NA** |    **NA** |
| SecondTry | Int32[3] | 1 |   NA |    NA |
|  **FirstTry** | **Int32[5]** | **3** |   **NA** |    **NA** |
| SecondTry | Int32[5] | 3 |   NA |    NA |
|  **FirstTry** | **Int32[4]** | **4** |   **NA** |    **NA** |
| SecondTry | Int32[4] | 4 |   NA |    NA |

Benchmarks with issues:
  CyclicRotation.FirstTry: DefaultJob [A=Int32[3], K=1]
  CyclicRotation.SecondTry: DefaultJob [A=Int32[3], K=1]
  CyclicRotation.FirstTry: DefaultJob [A=Int32[5], K=3]
  CyclicRotation.SecondTry: DefaultJob [A=Int32[5], K=3]
  CyclicRotation.FirstTry: DefaultJob [A=Int32[4], K=4]
  CyclicRotation.SecondTry: DefaultJob [A=Int32[4], K=4]
