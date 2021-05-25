``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.409
  [Host] : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|   Method |  N | Mean | Error |
|--------- |--- |-----:|------:|
| **FirstTry** | **10** |   **NA** |    **NA** |
| **FirstTry** | **14** |   **NA** |    **NA** |
| **FirstTry** | **99** |   **NA** |    **NA** |

Benchmarks with issues:
  SumOfDigits.FirstTry: DefaultJob [N=10]
  SumOfDigits.FirstTry: DefaultJob [N=14]
  SumOfDigits.FirstTry: DefaultJob [N=99]
