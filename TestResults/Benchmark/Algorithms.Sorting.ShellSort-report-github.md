``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host]     : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  DefaultJob : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|   Method |        A |       Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |--------- |-----------:|----------:|----------:|------:|------:|------:|----------:|
| **FirstTry** | **Int32[1]** |  **0.9514 ns** | **0.1055 ns** | **0.1408 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** | **Int32[2]** |  **2.5202 ns** | **0.0865 ns** | **0.0767 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** | **Int32[3]** |  **4.1443 ns** | **0.1675 ns** | **0.1792 ns** |     **-** |     **-** |     **-** |         **-** |
| FirstTry | Int32[3] |  3.8290 ns | 0.0826 ns | 0.0690 ns |     - |     - |     - |         - |
| **FirstTry** | **Int32[4]** |  **5.3075 ns** | **0.1729 ns** | **0.1617 ns** |     **-** |     **-** |     **-** |         **-** |
| FirstTry | Int32[4] |  5.3794 ns | 0.1938 ns | 0.2074 ns |     - |     - |     - |         - |
| FirstTry | Int32[4] |  5.2569 ns | 0.1303 ns | 0.1219 ns |     - |     - |     - |         - |
| FirstTry | Int32[4] |  5.1898 ns | 0.1895 ns | 0.1861 ns |     - |     - |     - |         - |
| **FirstTry** | **Int32[8]** | **17.3054 ns** | **0.4239 ns** | **0.3758 ns** |     **-** |     **-** |     **-** |         **-** |
