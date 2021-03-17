``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host]     : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  DefaultJob : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|    Method |        A | K |     Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--------- |-- |---------:|---------:|---------:|-------:|------:|------:|----------:|
|  **FirstTry** | **Int32[3]** | **1** | **18.11 ns** | **0.372 ns** | **0.330 ns** | **0.0015** |     **-** |     **-** |      **40 B** |
| SecondTry | Int32[3] | 1 | 18.08 ns | 0.362 ns | 0.283 ns | 0.0015 |     - |     - |      40 B |
|  **FirstTry** | **Int32[5]** | **3** | **24.53 ns** | **0.508 ns** | **0.451 ns** | **0.0018** |     **-** |     **-** |      **48 B** |
| SecondTry | Int32[5] | 3 | 24.19 ns | 0.508 ns | 0.475 ns | 0.0018 |     - |     - |      48 B |
|  **FirstTry** | **Int32[4]** | **4** | **20.62 ns** | **0.489 ns** | **0.669 ns** | **0.0015** |     **-** |     **-** |      **40 B** |
| SecondTry | Int32[4] | 4 | 20.67 ns | 0.486 ns | 0.520 ns | 0.0015 |     - |     - |      40 B |
