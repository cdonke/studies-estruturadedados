``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host]     : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  DefaultJob : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|    Method |        A | sum |      Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--------- |---- |----------:|----------:|----------:|-------:|------:|------:|----------:|
|  FirstTry | Int32[6] |  10 |  3.308 ns | 0.0842 ns | 0.0787 ns |      - |     - |     - |         - |
| SecondTry | Int32[6] |  10 | 31.906 ns | 0.6308 ns | 0.5591 ns |      - |     - |     - |         - |
|  ThirdTry | Int32[6] |  10 | 84.101 ns | 1.6588 ns | 1.9103 ns | 0.0070 |     - |     - |     184 B |
