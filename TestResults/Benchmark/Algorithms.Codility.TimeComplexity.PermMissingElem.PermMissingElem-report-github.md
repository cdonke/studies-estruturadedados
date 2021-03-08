``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|    Method | MissingValue | DataLength |        A |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |------------- |----------- |--------- |----------:|----------:|----------:|------:|------:|------:|----------:|
|  **FirstTry** |        **10001** |     **100000** | **Int32[0]** | **0.7139 ns** | **0.0305 ns** | **0.0286 ns** |     **-** |     **-** |     **-** |         **-** |
| SecondTry |        10001 |     100000 | Int32[0] | 0.7675 ns | 0.0182 ns | 0.0161 ns |     - |     - |     - |         - |
|  ThirdTry |        10001 |     100000 | Int32[0] | 1.6339 ns | 0.0263 ns | 0.0246 ns |     - |     - |     - |         - |
|  **FirstTry** |        **12345** |     **100000** | **Int32[0]** | **0.7355 ns** | **0.0108 ns** | **0.0101 ns** |     **-** |     **-** |     **-** |         **-** |
| SecondTry |        12345 |     100000 | Int32[0] | 1.7365 ns | 0.0417 ns | 0.0390 ns |     - |     - |     - |         - |
|  ThirdTry |        12345 |     100000 | Int32[0] | 0.7863 ns | 0.0218 ns | 0.0204 ns |     - |     - |     - |         - |
