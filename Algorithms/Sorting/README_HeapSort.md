﻿# Heap Sorting
O algoritmo heapsort é um algoritmo de ordenação generalista, e faz parte da família de algoritmos de ordenação por seleção. Foi desenvolvido em 1964 por Robert W. Floyd e J.W.J Williams.

![Heapsort](https://upload.wikimedia.org/wikipedia/commons/1/1b/Sorting_heapsort_anim.gif)

## Links
- https://www.youtube.com/watch?v=zSYOMJ1E52A
- https://pt.wikipedia.org/wiki/Heapsort

## Caracteristicas
- Comparações no pior caso: 2n log2n + O(n) é o mesmo que 2n log n + O(n)
- Trocas no pior caso: n log2n + O(n) é o mesmo que n log n + O(n)
- Melhor e pior caso: O(n log2n) é o mesmo que O(n log n)

## Benchmark

**Last update:** Tue May 25 20:02:21 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.409
  [Host] : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
| Method |              A | Mean | Error |
|------- |--------------- |-----:|------:|
|   **Sort** | **Int32[1000000]** |   **NA** |    **NA** |
|   **Sort** |  **Int32[100000]** |   **NA** |    **NA** |
|   **Sort** |   **Int32[10000]** |   **NA** |    **NA** |
|   **Sort** |      **Int32[10]** |   **NA** |    **NA** |
|   **Sort** |      **Int32[50]** |   **NA** |    **NA** |

Benchmarks with issues:
  HeapSort.Sort: DefaultJob [A=Int32[1000000]]
  HeapSort.Sort: DefaultJob [A=Int32[100000]]
  HeapSort.Sort: DefaultJob [A=Int32[10000]]
  HeapSort.Sort: DefaultJob [A=Int32[10]]
  HeapSort.Sort: DefaultJob [A=Int32[50]]
