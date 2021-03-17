``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host]     : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  DefaultJob : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|    Method |        A | expected |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--------- |--------- |----------:|----------:|----------:|------:|------:|------:|----------:|
|  **FirstTry** | **Int32[1]** |        **0** |  **4.765 ns** | **0.1042 ns** | **0.0975 ns** |     **-** |     **-** |     **-** |         **-** |
|  FirstTry | Int32[1] |        0 |  4.727 ns | 0.0942 ns | 0.0787 ns |     - |     - |     - |         - |
| SecondTry | Int32[1] |        0 |  5.004 ns | 0.0854 ns | 0.0799 ns |     - |     - |     - |         - |
| SecondTry | Int32[1] |        0 |  4.914 ns | 0.1333 ns | 0.1247 ns |     - |     - |     - |         - |
|  **FirstTry** | **Int32[2]** |        **0** | **19.059 ns** | **0.3802 ns** | **0.3370 ns** |     **-** |     **-** |     **-** |         **-** |
|  FirstTry | Int32[2] |        0 | 19.358 ns | 0.4094 ns | 0.4381 ns |     - |     - |     - |         - |
| SecondTry | Int32[2] |        0 | 19.153 ns | 0.3690 ns | 0.3452 ns |     - |     - |     - |         - |
| SecondTry | Int32[2] |        0 | 20.045 ns | 0.4152 ns | 0.4615 ns |     - |     - |     - |         - |
|  **FirstTry** | **Int32[2]** |        **1** | **19.058 ns** | **0.2746 ns** | **0.2144 ns** |     **-** |     **-** |     **-** |         **-** |
|  FirstTry | Int32[2] |        1 | 19.079 ns | 0.3431 ns | 0.3041 ns |     - |     - |     - |         - |
| SecondTry | Int32[2] |        1 | 19.216 ns | 0.3859 ns | 0.3609 ns |     - |     - |     - |         - |
| SecondTry | Int32[2] |        1 | 19.486 ns | 0.3825 ns | 0.3391 ns |     - |     - |     - |         - |
