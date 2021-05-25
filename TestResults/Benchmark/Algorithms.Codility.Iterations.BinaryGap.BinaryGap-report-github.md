``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.409
  [Host] : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|    Method |    N | Mean | Error |
|---------- |----- |-----:|------:|
|  **FirstTry** |    **1** |   **NA** |    **NA** |
| SecondTry |    1 |   NA |    NA |
|  **FirstTry** |    **2** |   **NA** |    **NA** |
| SecondTry |    2 |   NA |    NA |
|  **FirstTry** |   **15** |   **NA** |    **NA** |
| SecondTry |   15 |   NA |    NA |
|  **FirstTry** |   **32** |   **NA** |    **NA** |
| SecondTry |   32 |   NA |    NA |
|  **FirstTry** |  **147** |   **NA** |    **NA** |
| SecondTry |  147 |   NA |    NA |
|  **FirstTry** |  **483** |   **NA** |    **NA** |
| SecondTry |  483 |   NA |    NA |
|  **FirstTry** |  **647** |   **NA** |    **NA** |
| SecondTry |  647 |   NA |    NA |
|  **FirstTry** | **1041** |   **NA** |    **NA** |
| SecondTry | 1041 |   NA |    NA |

Benchmarks with issues:
  BinaryGap.FirstTry: DefaultJob [N=1]
  BinaryGap.SecondTry: DefaultJob [N=1]
  BinaryGap.FirstTry: DefaultJob [N=2]
  BinaryGap.SecondTry: DefaultJob [N=2]
  BinaryGap.FirstTry: DefaultJob [N=15]
  BinaryGap.SecondTry: DefaultJob [N=15]
  BinaryGap.FirstTry: DefaultJob [N=32]
  BinaryGap.SecondTry: DefaultJob [N=32]
  BinaryGap.FirstTry: DefaultJob [N=147]
  BinaryGap.SecondTry: DefaultJob [N=147]
  BinaryGap.FirstTry: DefaultJob [N=483]
  BinaryGap.SecondTry: DefaultJob [N=483]
  BinaryGap.FirstTry: DefaultJob [N=647]
  BinaryGap.SecondTry: DefaultJob [N=647]
  BinaryGap.FirstTry: DefaultJob [N=1041]
  BinaryGap.SecondTry: DefaultJob [N=1041]
