``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|    Method |        A | K |     Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--------- |-- |---------:|---------:|---------:|-------:|------:|------:|----------:|
|  **FirstTry** | **Int32[3]** | **1** | **23.90 ns** | **0.310 ns** | **0.275 ns** | **0.0021** |     **-** |     **-** |      **40 B** |
| SecondTry | Int32[3] | 1 | 25.58 ns | 0.629 ns | 0.818 ns | 0.0021 |     - |     - |      40 B |
|  **FirstTry** | **Int32[5]** | **3** | **34.11 ns** | **0.100 ns** | **0.093 ns** | **0.0026** |     **-** |     **-** |      **48 B** |
| SecondTry | Int32[5] | 3 | 33.60 ns | 0.319 ns | 0.299 ns | 0.0026 |     - |     - |      48 B |
|  **FirstTry** | **Int32[4]** | **4** | **29.37 ns** | **0.173 ns** | **0.145 ns** | **0.0021** |     **-** |     **-** |      **40 B** |
| SecondTry | Int32[4] | 4 | 29.00 ns | 0.145 ns | 0.136 ns | 0.0021 |     - |     - |      40 B |
