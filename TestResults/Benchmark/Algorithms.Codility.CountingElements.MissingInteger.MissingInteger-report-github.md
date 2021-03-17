``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host] : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|    Method |             A | missingInteger | Mean | Error |
|---------- |-------------- |--------------- |-----:|------:|
|  **FirstTry** |   **Int32[1078]** |              **1** |   **NA** |    **NA** |
|  **FirstTry** |    **Int32[357]** |              **1** |   **NA** |    **NA** |
| **SecondTry** |    **Int32[441]** |              **1** |   **NA** |    **NA** |
| **SecondTry** |    **Int32[477]** |              **1** |   **NA** |    **NA** |
| **SecondTry** |    **Int32[576]** |              **1** |   **NA** |    **NA** |
| **SecondTry** |   **Int32[6387]** |              **1** |   **NA** |    **NA** |
| **SecondTry** |    **Int32[741]** |              **1** |   **NA** |    **NA** |
|  **FirstTry** |    **Int32[757]** |              **1** |   **NA** |    **NA** |
|  **FirstTry** |    **Int32[803]** |              **1** |   **NA** |    **NA** |
|  **FirstTry** | **Int32[936767]** |              **1** |   **NA** |    **NA** |
|  **FirstTry** |   **Int32[9766]** |              **1** |   **NA** |    **NA** |
| **SecondTry** | **Int32[986017]** |         **124862** |   **NA** |    **NA** |

Benchmarks with issues:
  MissingInteger.FirstTry: DefaultJob [A=Int32[1078], missingInteger=1]
  MissingInteger.FirstTry: DefaultJob [A=Int32[357], missingInteger=1]
  MissingInteger.SecondTry: DefaultJob [A=Int32[441], missingInteger=1]
  MissingInteger.SecondTry: DefaultJob [A=Int32[477], missingInteger=1]
  MissingInteger.SecondTry: DefaultJob [A=Int32[576], missingInteger=1]
  MissingInteger.SecondTry: DefaultJob [A=Int32[6387], missingInteger=1]
  MissingInteger.SecondTry: DefaultJob [A=Int32[741], missingInteger=1]
  MissingInteger.FirstTry: DefaultJob [A=Int32[757], missingInteger=1]
  MissingInteger.FirstTry: DefaultJob [A=Int32[803], missingInteger=1]
  MissingInteger.FirstTry: DefaultJob [A=Int32[936767], missingInteger=1]
  MissingInteger.FirstTry: DefaultJob [A=Int32[9766], missingInteger=1]
  MissingInteger.SecondTry: DefaultJob [A=Int32[986017], missingInteger=124862]
