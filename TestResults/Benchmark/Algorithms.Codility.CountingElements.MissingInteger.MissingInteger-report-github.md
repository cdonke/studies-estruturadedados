``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.409
  [Host] : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|    Method |              A | missingInteger | Mean | Error |
|---------- |--------------- |--------------- |-----:|------:|
|  **FirstTry** |    **Int32[1187]** |              **1** |   **NA** |    **NA** |
| **SecondTry** |    **Int32[1252]** |              **1** |   **NA** |    **NA** |
| **SecondTry** |     **Int32[129]** |              **1** |   **NA** |    **NA** |
| **SecondTry** |     **Int32[142]** |              **1** |   **NA** |    **NA** |
|  **FirstTry** |     **Int32[188]** |              **1** |   **NA** |    **NA** |
|  FirstTry |     Int32[188] |              1 |   NA |    NA |
| **SecondTry** |     **Int32[430]** |              **1** |   **NA** |    **NA** |
|  **FirstTry** |  **Int32[502228]** |              **1** |   **NA** |    **NA** |
|  **FirstTry** |     **Int32[638]** |              **1** |   **NA** |    **NA** |
|  **FirstTry** |    **Int32[6865]** |              **1** |   **NA** |    **NA** |
| **SecondTry** |    **Int32[6890]** |              **1** |   **NA** |    **NA** |
| **SecondTry** | **Int32[1090240]** |         **507314** |   **NA** |    **NA** |

Benchmarks with issues:
  MissingInteger.FirstTry: DefaultJob [A=Int32[1187], missingInteger=1]
  MissingInteger.SecondTry: DefaultJob [A=Int32[1252], missingInteger=1]
  MissingInteger.SecondTry: DefaultJob [A=Int32[129], missingInteger=1]
  MissingInteger.SecondTry: DefaultJob [A=Int32[142], missingInteger=1]
  MissingInteger.FirstTry: DefaultJob [A=Int32[188], missingInteger=1]
  MissingInteger.FirstTry: DefaultJob [A=Int32[188], missingInteger=1]
  MissingInteger.SecondTry: DefaultJob [A=Int32[430], missingInteger=1]
  MissingInteger.FirstTry: DefaultJob [A=Int32[502228], missingInteger=1]
  MissingInteger.FirstTry: DefaultJob [A=Int32[638], missingInteger=1]
  MissingInteger.FirstTry: DefaultJob [A=Int32[6865], missingInteger=1]
  MissingInteger.SecondTry: DefaultJob [A=Int32[6890], missingInteger=1]
  MissingInteger.SecondTry: DefaultJob [A=Int32[1090240], missingInteger=507314]
