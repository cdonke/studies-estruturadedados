``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 18.04
Intel Xeon CPU E5-2673 v3 2.40GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|    Method | MissingValue | DataLength |        A |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |------------- |----------- |--------- |----------:|----------:|----------:|------:|------:|------:|----------:|
|  **FirstTry** |        **10001** |     **100000** | **Int32[0]** | **0.6221 ns** | **0.0564 ns** | **0.0527 ns** |     **-** |     **-** |     **-** |         **-** |
| SecondTry |        10001 |     100000 | Int32[0] | 0.8971 ns | 0.0587 ns | 0.0576 ns |     - |     - |     - |         - |
|  ThirdTry |        10001 |     100000 | Int32[0] | 1.0570 ns | 0.0503 ns | 0.0494 ns |     - |     - |     - |         - |
|  **FirstTry** |        **12345** |     **100000** | **Int32[0]** | **0.8305 ns** | **0.0578 ns** | **0.0752 ns** |     **-** |     **-** |     **-** |         **-** |
| SecondTry |        12345 |     100000 | Int32[0] | 0.9075 ns | 0.0614 ns | 0.0682 ns |     - |     - |     - |         - |
|  ThirdTry |        12345 |     100000 | Int32[0] | 1.0568 ns | 0.0593 ns | 0.0554 ns |     - |     - |     - |         - |
