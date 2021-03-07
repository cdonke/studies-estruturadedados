``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|    Method | MissingValue | DataLength |        A |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |------------- |----------- |--------- |----------:|----------:|----------:|------:|------:|------:|----------:|
|  **FirstTry** |        **10001** |     **100000** | **Int32[0]** | **0.5732 ns** | **0.0177 ns** | **0.0165 ns** |     **-** |     **-** |     **-** |         **-** |
| SecondTry |        10001 |     100000 | Int32[0] | 1.2735 ns | 0.0255 ns | 0.0226 ns |     - |     - |     - |         - |
|  ThirdTry |        10001 |     100000 | Int32[0] | 0.7541 ns | 0.0487 ns | 0.0814 ns |     - |     - |     - |         - |
|  **FirstTry** |        **12345** |     **100000** | **Int32[0]** | **0.4513 ns** | **0.0209 ns** | **0.0195 ns** |     **-** |     **-** |     **-** |         **-** |
| SecondTry |        12345 |     100000 | Int32[0] | 0.5804 ns | 0.0156 ns | 0.0138 ns |     - |     - |     - |         - |
|  ThirdTry |        12345 |     100000 | Int32[0] | 0.6004 ns | 0.0226 ns | 0.0200 ns |     - |     - |     - |         - |
