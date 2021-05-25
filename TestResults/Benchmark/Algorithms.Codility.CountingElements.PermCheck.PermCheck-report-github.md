``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.409
  [Host] : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|    Method |        A | expected | Mean | Error |
|---------- |--------- |--------- |-----:|------:|
|  **FirstTry** | **Int32[1]** |        **0** |   **NA** |    **NA** |
|  FirstTry | Int32[1] |        0 |   NA |    NA |
| SecondTry | Int32[1] |        0 |   NA |    NA |
| SecondTry | Int32[1] |        0 |   NA |    NA |
|  **FirstTry** | **Int32[2]** |        **0** |   **NA** |    **NA** |
|  FirstTry | Int32[2] |        0 |   NA |    NA |
| SecondTry | Int32[2] |        0 |   NA |    NA |
| SecondTry | Int32[2] |        0 |   NA |    NA |
|  **FirstTry** | **Int32[2]** |        **1** |   **NA** |    **NA** |
|  FirstTry | Int32[2] |        1 |   NA |    NA |
| SecondTry | Int32[2] |        1 |   NA |    NA |
| SecondTry | Int32[2] |        1 |   NA |    NA |

Benchmarks with issues:
  PermCheck.FirstTry: DefaultJob [A=Int32[1], expected=0]
  PermCheck.FirstTry: DefaultJob [A=Int32[1], expected=0]
  PermCheck.SecondTry: DefaultJob [A=Int32[1], expected=0]
  PermCheck.SecondTry: DefaultJob [A=Int32[1], expected=0]
  PermCheck.FirstTry: DefaultJob [A=Int32[2], expected=0]
  PermCheck.FirstTry: DefaultJob [A=Int32[2], expected=0]
  PermCheck.SecondTry: DefaultJob [A=Int32[2], expected=0]
  PermCheck.SecondTry: DefaultJob [A=Int32[2], expected=0]
  PermCheck.FirstTry: DefaultJob [A=Int32[2], expected=1]
  PermCheck.FirstTry: DefaultJob [A=Int32[2], expected=1]
  PermCheck.SecondTry: DefaultJob [A=Int32[2], expected=1]
  PermCheck.SecondTry: DefaultJob [A=Int32[2], expected=1]
