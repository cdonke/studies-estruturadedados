``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 18.04
Intel Xeon CPU E5-2673 v3 2.40GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|               Method |        A |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |----------:|----------:|----------:|------:|------:|------:|----------:|
|             FirstTry | Int32[5] | 10.574 ns | 0.2457 ns | 0.2298 ns |     - |     - |     - |         - |
|  FirstTry_BitwiseAbs | Int32[5] |  9.435 ns | 0.2270 ns | 0.2871 ns |     - |     - |     - |         - |
|            SecondTry | Int32[5] | 13.114 ns | 0.3023 ns | 0.5677 ns |     - |     - |     - |         - |
| SecondTry_BitwiseAbs | Int32[5] | 10.899 ns | 0.1950 ns | 0.1729 ns |     - |     - |     - |         - |
