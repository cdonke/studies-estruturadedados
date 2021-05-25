``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.409
  [Host] : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|   Method |       S | Mean | Error |
|--------- |-------- |-----:|------:|
| **FirstTry** |    **aaaa** |   **NA** |    **NA** |
| **FirstTry** | **acbcbba** |   **NA** |    **NA** |
| **FirstTry** |  **axxaxa** |   **NA** |    **NA** |

Benchmarks with issues:
  EvenWords.FirstTry: DefaultJob [S=aaaa]
  EvenWords.FirstTry: DefaultJob [S=acbcbba]
  EvenWords.FirstTry: DefaultJob [S=axxaxa]
