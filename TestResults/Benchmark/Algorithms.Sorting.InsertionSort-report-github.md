``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 18.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|      Method |      vetores |     Mean |    Error |   StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------ |------------- |---------:|---------:|---------:|------:|------:|------:|----------:|
| SortWithXOR | Int32[50000] | 56.88 μs | 1.132 μs | 1.762 μs |     - |     - |     - |         - |
| SortWithAux | Int32[50000] | 58.76 μs | 1.080 μs | 1.010 μs |     - |     - |     - |         - |
