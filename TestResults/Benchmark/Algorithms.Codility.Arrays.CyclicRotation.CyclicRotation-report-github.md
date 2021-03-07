``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|    Method |        A | K |     Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--------- |-- |---------:|---------:|---------:|-------:|------:|------:|----------:|
|  **FirstTry** | **Int32[3]** | **1** | **15.92 ns** | **0.377 ns** | **0.387 ns** | **0.0021** |     **-** |     **-** |      **40 B** |
| SecondTry | Int32[3] | 1 | 14.90 ns | 0.233 ns | 0.218 ns | 0.0021 |     - |     - |      40 B |
|  **FirstTry** | **Int32[5]** | **3** | **21.49 ns** | **0.403 ns** | **0.431 ns** | **0.0026** |     **-** |     **-** |      **48 B** |
| SecondTry | Int32[5] | 3 | 21.47 ns | 0.424 ns | 0.397 ns | 0.0026 |     - |     - |      48 B |
|  **FirstTry** | **Int32[4]** | **4** | **18.15 ns** | **0.344 ns** | **0.322 ns** | **0.0021** |     **-** |     **-** |      **40 B** |
| SecondTry | Int32[4] | 4 | 18.13 ns | 0.328 ns | 0.307 ns | 0.0021 |     - |     - |      40 B |
