``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.409
  [Host] : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|   Method |                    T | expected | Mean | Error |
|--------- |--------------------- |--------- |-----:|------:|
| **FirstTry** | **Algor(...)+Tree [72]** |        **2** |   **NA** |    **NA** |
| **FirstTry** | **Algor(...)+Tree [72]** |        **4** |   **NA** |    **NA** |

Benchmarks with issues:
  NumberOfVisibleNodes.FirstTry: DefaultJob [T=Algor(...)+Tree [72], expected=2]
  NumberOfVisibleNodes.FirstTry: DefaultJob [T=Algor(...)+Tree [72], expected=4]
