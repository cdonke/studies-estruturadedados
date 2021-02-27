``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 18.04
Intel Xeon CPU E5-2673 v3 2.40GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|    Method |        A | K |     Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--------- |-- |---------:|---------:|---------:|-------:|------:|------:|----------:|
|  **FirstTry** | **Int32[3]** | **1** | **21.60 ns** | **0.495 ns** | **0.570 ns** | **0.0025** |     **-** |     **-** |      **40 B** |
| SecondTry | Int32[3] | 1 | 21.12 ns | 0.481 ns | 0.573 ns | 0.0025 |     - |     - |      40 B |
|  **FirstTry** | **Int32[5]** | **3** | **29.47 ns** | **0.687 ns** | **0.869 ns** | **0.0030** |     **-** |     **-** |      **48 B** |
| SecondTry | Int32[5] | 3 | 29.46 ns | 0.634 ns | 0.930 ns | 0.0030 |     - |     - |      48 B |
|  **FirstTry** | **Int32[4]** | **4** | **25.10 ns** | **0.508 ns** | **0.475 ns** | **0.0025** |     **-** |     **-** |      **40 B** |
| SecondTry | Int32[4] | 4 | 25.14 ns | 0.607 ns | 0.890 ns | 0.0025 |     - |     - |      40 B |
