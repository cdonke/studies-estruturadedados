``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|               Method |        A |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |----------:|----------:|----------:|------:|------:|------:|----------:|
|             FirstTry | Int32[5] |  7.194 ns | 0.1328 ns | 0.1242 ns |     - |     - |     - |         - |
|  FirstTry_BitwiseAbs | Int32[5] | 10.258 ns | 0.0917 ns | 0.0858 ns |     - |     - |     - |         - |
|            SecondTry | Int32[5] |  9.630 ns | 0.0976 ns | 0.0815 ns |     - |     - |     - |         - |
| SecondTry_BitwiseAbs | Int32[5] | 10.539 ns | 0.1289 ns | 0.1206 ns |     - |     - |     - |         - |
