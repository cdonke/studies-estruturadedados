``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 18.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|    Method |        A | K |     Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--------- |-- |---------:|---------:|---------:|-------:|------:|------:|----------:|
|  **FirstTry** | **Int32[3]** | **1** | **27.31 ns** | **0.643 ns** | **0.661 ns** | **0.0015** |     **-** |     **-** |      **40 B** |
| SecondTry | Int32[3] | 1 | 27.71 ns | 0.657 ns | 0.675 ns | 0.0015 |     - |     - |      40 B |
|  **FirstTry** | **Int32[5]** | **3** | **36.33 ns** | **0.827 ns** | **0.812 ns** | **0.0018** |     **-** |     **-** |      **48 B** |
| SecondTry | Int32[5] | 3 | 36.29 ns | 0.748 ns | 0.700 ns | 0.0018 |     - |     - |      48 B |
|  **FirstTry** | **Int32[4]** | **4** | **30.80 ns** | **0.451 ns** | **0.376 ns** | **0.0015** |     **-** |     **-** |      **40 B** |
| SecondTry | Int32[4] | 4 | 30.14 ns | 0.693 ns | 0.826 ns | 0.0015 |     - |     - |      40 B |
