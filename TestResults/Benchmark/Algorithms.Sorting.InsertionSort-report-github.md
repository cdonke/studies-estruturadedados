``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 18.04
Intel Xeon CPU E5-2673 v3 2.40GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host] : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|      Method |      vetores | Mean | Error |
|------------ |------------- |-----:|------:|
| SortWithXOR | Int32[50000] |   NA |    NA |
| SortWithAux | Int32[50000] |   NA |    NA |

Benchmarks with issues:
  InsertionSort.SortWithXOR: DefaultJob [vetores=Int32[50000]]
  InsertionSort.SortWithAux: DefaultJob [vetores=Int32[50000]]
