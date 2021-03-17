``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host]     : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  DefaultJob : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|               Method |        A |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |----------:|----------:|----------:|------:|------:|------:|----------:|
|             FirstTry | Int32[5] |  8.541 ns | 0.1607 ns | 0.1503 ns |     - |     - |     - |         - |
|  FirstTry_BitwiseAbs | Int32[5] |  8.738 ns | 0.2034 ns | 0.1902 ns |     - |     - |     - |         - |
|            SecondTry | Int32[5] | 10.964 ns | 0.2430 ns | 0.2273 ns |     - |     - |     - |         - |
| SecondTry_BitwiseAbs | Int32[5] | 10.376 ns | 0.2426 ns | 0.2383 ns |     - |     - |     - |         - |
