``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.409
  [Host] : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|   Method |        A | Mean | Error |
|--------- |--------- |-----:|------:|
| **FirstTry** | **Int32[1]** |   **NA** |    **NA** |
| **FirstTry** | **Int32[2]** |   **NA** |    **NA** |
| **FirstTry** | **Int32[3]** |   **NA** |    **NA** |
| FirstTry | Int32[3] |   NA |    NA |
| **FirstTry** | **Int32[4]** |   **NA** |    **NA** |
| FirstTry | Int32[4] |   NA |    NA |
| FirstTry | Int32[4] |   NA |    NA |
| FirstTry | Int32[4] |   NA |    NA |
| **FirstTry** | **Int32[8]** |   **NA** |    **NA** |

Benchmarks with issues:
  ShellSort.FirstTry: DefaultJob [A=Int32[1]]
  ShellSort.FirstTry: DefaultJob [A=Int32[2]]
  ShellSort.FirstTry: DefaultJob [A=Int32[3]]
  ShellSort.FirstTry: DefaultJob [A=Int32[3]]
  ShellSort.FirstTry: DefaultJob [A=Int32[4]]
  ShellSort.FirstTry: DefaultJob [A=Int32[4]]
  ShellSort.FirstTry: DefaultJob [A=Int32[4]]
  ShellSort.FirstTry: DefaultJob [A=Int32[4]]
  ShellSort.FirstTry: DefaultJob [A=Int32[8]]
