``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|               Method |        A |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |----------:|----------:|----------:|------:|------:|------:|----------:|
|             FirstTry | Int32[5] |  9.158 ns | 0.0755 ns | 0.0706 ns |     - |     - |     - |         - |
|  FirstTry_BitwiseAbs | Int32[5] | 13.806 ns | 0.1026 ns | 0.0960 ns |     - |     - |     - |         - |
|            SecondTry | Int32[5] | 11.005 ns | 0.1341 ns | 0.1120 ns |     - |     - |     - |         - |
| SecondTry_BitwiseAbs | Int32[5] | 13.989 ns | 0.1300 ns | 0.1216 ns |     - |     - |     - |         - |
