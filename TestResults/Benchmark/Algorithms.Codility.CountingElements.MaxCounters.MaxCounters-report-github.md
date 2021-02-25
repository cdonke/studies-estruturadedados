``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 18.04
Intel Xeon CPU E5-2673 v3 2.40GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host] : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|    Method |     N |            A | Mean | Error |
|---------- |------ |------------- |-----:|------:|
|  **FirstTry** |     **5** | **Int32[10000]** |   **NA** |    **NA** |
| SecondTry |     5 | Int32[10000] |   NA |    NA |
|  ThirdTry |     5 | Int32[10000] |   NA |    NA |
| FourthTry |     5 | Int32[10000] |   NA |    NA |
|  **FirstTry** | **10000** | **Int32[10000]** |   **NA** |    **NA** |
| SecondTry | 10000 | Int32[10000] |   NA |    NA |
|  ThirdTry | 10000 | Int32[10000] |   NA |    NA |
| FourthTry | 10000 | Int32[10000] |   NA |    NA |
|  **FirstTry** | **10000** |  **Int32[3000]** |   **NA** |    **NA** |
| SecondTry | 10000 |  Int32[3000] |   NA |    NA |
|  ThirdTry | 10000 |  Int32[3000] |   NA |    NA |
| FourthTry | 10000 |  Int32[3000] |   NA |    NA |

Benchmarks with issues:
  MaxCounters.FirstTry: DefaultJob [N=5, A=Int32[10000]]
  MaxCounters.SecondTry: DefaultJob [N=5, A=Int32[10000]]
  MaxCounters.ThirdTry: DefaultJob [N=5, A=Int32[10000]]
  MaxCounters.FourthTry: DefaultJob [N=5, A=Int32[10000]]
  MaxCounters.FirstTry: DefaultJob [N=10000, A=Int32[10000]]
  MaxCounters.SecondTry: DefaultJob [N=10000, A=Int32[10000]]
  MaxCounters.ThirdTry: DefaultJob [N=10000, A=Int32[10000]]
  MaxCounters.FourthTry: DefaultJob [N=10000, A=Int32[10000]]
  MaxCounters.FirstTry: DefaultJob [N=10000, A=Int32[3000]]
  MaxCounters.SecondTry: DefaultJob [N=10000, A=Int32[3000]]
  MaxCounters.ThirdTry: DefaultJob [N=10000, A=Int32[3000]]
  MaxCounters.FourthTry: DefaultJob [N=10000, A=Int32[3000]]
