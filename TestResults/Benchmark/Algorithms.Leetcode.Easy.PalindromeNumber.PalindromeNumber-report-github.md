``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host]     : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  DefaultJob : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|    Method |    x | expected |       Mean |     Error |    StdDev |     Median | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |----- |--------- |-----------:|----------:|----------:|-----------:|------:|------:|------:|----------:|
|  **FirstTry** | **-121** |    **False** |  **0.6923 ns** | **0.0541 ns** | **0.0506 ns** |  **0.6702 ns** |     **-** |     **-** |     **-** |         **-** |
| SecondTry | -121 |    False |  0.3466 ns | 0.0405 ns | 0.0379 ns |  0.3491 ns |     - |     - |     - |         - |
|  **FirstTry** | **-101** |    **False** |  **1.0021 ns** | **0.0581 ns** | **0.0543 ns** |  **0.9812 ns** |     **-** |     **-** |     **-** |         **-** |
| SecondTry | -101 |    False |  0.3638 ns | 0.0467 ns | 0.0459 ns |  0.3690 ns |     - |     - |     - |         - |
|  **FirstTry** |    **0** |     **True** |  **0.0253 ns** | **0.0343 ns** | **0.0321 ns** |  **0.0074 ns** |     **-** |     **-** |     **-** |         **-** |
| SecondTry |    0 |     True |  1.6789 ns | 0.0723 ns | 0.0832 ns |  1.6510 ns |     - |     - |     - |         - |
|  **FirstTry** |   **10** |    **False** |  **1.3363 ns** | **0.0668 ns** | **0.0686 ns** |  **1.3228 ns** |     **-** |     **-** |     **-** |         **-** |
| SecondTry |   10 |    False |  0.9754 ns | 0.0558 ns | 0.0522 ns |  0.9642 ns |     - |     - |     - |         - |
|  **FirstTry** |  **121** |     **True** | **10.5698 ns** | **0.2448 ns** | **0.2170 ns** | **10.5423 ns** |     **-** |     **-** |     **-** |         **-** |
| SecondTry |  121 |     True |  4.9235 ns | 0.0963 ns | 0.0900 ns |  4.9069 ns |     - |     - |     - |         - |
|  **FirstTry** | **1221** |     **True** | **13.5286 ns** | **0.2817 ns** | **0.2635 ns** | **13.5234 ns** |     **-** |     **-** |     **-** |         **-** |
| SecondTry | 1221 |     True |  4.2248 ns | 0.0983 ns | 0.0872 ns |  4.2407 ns |     - |     - |     - |         - |
