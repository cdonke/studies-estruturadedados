# Insertion Sorting
- **In-place:** uses small amount of extra memory
  - Uses only a few iterators and no more.
- **Stable**: Doesn't change the order of duplicate itens.

Simillar of sorting cards in your hand.
A wall is used again, this time, set to 1.

What is to the left of the wall, is considered sorted.

Save the current unsorted element, because it will be insert at the right place.
Enter the inner loop, setting the iterator to partIndex.



## Caracteristicas
- **Time complexity:** O(n^2)
- **Space efficiency:** O(1)

## Benchmark

**Last update:** Tue Mar 16 12:06:48 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host] : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|      Method |      vetores | Mean | Error |
|------------ |------------- |-----:|------:|
| SortWithXOR | Int32[50000] |   NA |    NA |
| SortWithAux | Int32[50000] |   NA |    NA |
|    ThirdTry | Int32[50000] |   NA |    NA |

Benchmarks with issues:
  InsertionSort.SortWithXOR: DefaultJob [vetores=Int32[50000]]
  InsertionSort.SortWithAux: DefaultJob [vetores=Int32[50000]]
  InsertionSort.ThirdTry: DefaultJob [vetores=Int32[50000]]
