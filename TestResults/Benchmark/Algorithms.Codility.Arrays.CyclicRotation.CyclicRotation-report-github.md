``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host] : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


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
