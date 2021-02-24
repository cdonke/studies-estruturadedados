``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 18.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|    Method | MissingValue | DataLength |        A |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |------------- |----------- |--------- |----------:|----------:|----------:|------:|------:|------:|----------:|
|  **FirstTry** |        **10001** |     **100000** | **Int32[0]** | **0.8671 ns** | **0.0597 ns** | **0.0613 ns** |     **-** |     **-** |     **-** |         **-** |
| SecondTry |        10001 |     100000 | Int32[0] | 0.8672 ns | 0.0355 ns | 0.0332 ns |     - |     - |     - |         - |
|  ThirdTry |        10001 |     100000 | Int32[0] | 0.8760 ns | 0.0612 ns | 0.0601 ns |     - |     - |     - |         - |
|  **FirstTry** |        **12345** |     **100000** | **Int32[0]** | **0.8745 ns** | **0.0489 ns** | **0.0457 ns** |     **-** |     **-** |     **-** |         **-** |
| SecondTry |        12345 |     100000 | Int32[0] | 0.9161 ns | 0.0340 ns | 0.0302 ns |     - |     - |     - |         - |
|  ThirdTry |        12345 |     100000 | Int32[0] | 1.1831 ns | 0.0680 ns | 0.0636 ns |     - |     - |     - |         - |
