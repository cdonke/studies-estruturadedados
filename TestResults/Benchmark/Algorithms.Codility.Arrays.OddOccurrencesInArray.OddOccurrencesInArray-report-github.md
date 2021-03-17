``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host]     : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  DefaultJob : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|    Method |        A |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--------- |----------:|----------:|----------:|------:|------:|------:|----------:|
|  FirstTry | Int32[7] | 46.843 ns | 0.6882 ns | 0.6101 ns |     - |     - |     - |         - |
| SecondTry | Int32[7] |  4.634 ns | 0.0645 ns | 0.0572 ns |     - |     - |     - |         - |
