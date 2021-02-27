``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 18.04
Intel Xeon CPU E5-2673 v3 2.40GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|    Method |        A |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--------- |----------:|----------:|----------:|------:|------:|------:|----------:|
|  FirstTry | Int32[7] | 51.472 ns | 0.8489 ns | 0.7941 ns |     - |     - |     - |         - |
| SecondTry | Int32[7] |  5.358 ns | 0.1451 ns | 0.1553 ns |     - |     - |     - |         - |
