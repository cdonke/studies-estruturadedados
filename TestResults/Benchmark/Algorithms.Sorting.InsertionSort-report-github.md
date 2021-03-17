``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host]     : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  DefaultJob : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|      Method |      vetores |     Mean |    Error |    StdDev |   Median | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------ |------------- |---------:|---------:|----------:|---------:|------:|------:|------:|----------:|
| SortWithXOR | Int32[50000] | 45.31 μs | 1.087 μs |  2.786 μs | 44.80 μs |     - |     - |     - |         - |
| SortWithAux | Int32[50000] | 52.88 μs | 3.276 μs |  9.451 μs | 47.70 μs |     - |     - |     - |         - |
|    ThirdTry | Int32[50000] | 68.56 μs | 4.542 μs | 12.958 μs | 65.10 μs |     - |     - |     - |         - |
