# Bubble Sorting
- **In-place:** uses small amount of extra memory
  - Uses only a few iterators and no more.
- **Stable**: Doesn't change the order of duplicate itens.


## Caracteristicas
- **Time complexity:** O(n^2)
- **Space efficiency:** O(1)
- Degrada rapidamente.

## Benchmark

**Last update:** Wed Mar 17 15:15:21 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host]     : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  DefaultJob : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|      Method |  valores |     Mean |    Error |   StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------ |--------- |---------:|---------:|---------:|------:|------:|------:|----------:|
| SortWithAux | Int32[9] | 46.37 ns | 0.896 ns | 0.838 ns |     - |     - |     - |         - |
| SortWithXOR | Int32[9] | 45.08 ns | 0.802 ns | 0.750 ns |     - |     - |     - |         - |
