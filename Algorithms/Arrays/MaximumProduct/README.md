# Exercise
Given an integer array, find the maximum product of two integers in it.

For example, consider array `{-10, -3, 5, 6, -2}`. 
The maximum product is the `(-10, -3)` or `(5, 6)` pair.

# Benchmark

**Last update:** Tue Mar 16 12:06:48 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host] : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|                         Method |           A | Mean | Error |
|------------------------------- |------------ |-----:|------:|
|         **&#39;Double-loop - O(n^2)&#39;** | **Int32[1000]** |   **NA** |    **NA** |
| &#39;Linear - Sorted - O(n.log n)&#39; | Int32[1000] |   NA |    NA |
|    &#39;Linear - Traversal - O(n)&#39; | Int32[1000] |   NA |    NA |
|         **&#39;Double-loop - O(n^2)&#39;** |  **Int32[100]** |   **NA** |    **NA** |
| &#39;Linear - Sorted - O(n.log n)&#39; |  Int32[100] |   NA |    NA |
|    &#39;Linear - Traversal - O(n)&#39; |  Int32[100] |   NA |    NA |
|         **&#39;Double-loop - O(n^2)&#39;** |   **Int32[15]** |   **NA** |    **NA** |
| &#39;Linear - Sorted - O(n.log n)&#39; |   Int32[15] |   NA |    NA |
|    &#39;Linear - Traversal - O(n)&#39; |   Int32[15] |   NA |    NA |
|         **&#39;Double-loop - O(n^2)&#39;** |  **Int32[500]** |   **NA** |    **NA** |
| &#39;Linear - Sorted - O(n.log n)&#39; |  Int32[500] |   NA |    NA |
|    &#39;Linear - Traversal - O(n)&#39; |  Int32[500] |   NA |    NA |
|         **&#39;Double-loop - O(n^2)&#39;** |   **Int32[50]** |   **NA** |    **NA** |
| &#39;Linear - Sorted - O(n.log n)&#39; |   Int32[50] |   NA |    NA |
|    &#39;Linear - Traversal - O(n)&#39; |   Int32[50] |   NA |    NA |
|         **&#39;Double-loop - O(n^2)&#39;** |    **Int32[5]** |   **NA** |    **NA** |
| &#39;Linear - Sorted - O(n.log n)&#39; |    Int32[5] |   NA |    NA |
|    &#39;Linear - Traversal - O(n)&#39; |    Int32[5] |   NA |    NA |

Benchmarks with issues:
  MaximumProduct.'Double-loop - O(n^2)': DefaultJob [A=Int32[1000]]
  MaximumProduct.'Linear - Sorted - O(n.log n)': DefaultJob [A=Int32[1000]]
  MaximumProduct.'Linear - Traversal - O(n)': DefaultJob [A=Int32[1000]]
  MaximumProduct.'Double-loop - O(n^2)': DefaultJob [A=Int32[100]]
  MaximumProduct.'Linear - Sorted - O(n.log n)': DefaultJob [A=Int32[100]]
  MaximumProduct.'Linear - Traversal - O(n)': DefaultJob [A=Int32[100]]
  MaximumProduct.'Double-loop - O(n^2)': DefaultJob [A=Int32[15]]
  MaximumProduct.'Linear - Sorted - O(n.log n)': DefaultJob [A=Int32[15]]
  MaximumProduct.'Linear - Traversal - O(n)': DefaultJob [A=Int32[15]]
  MaximumProduct.'Double-loop - O(n^2)': DefaultJob [A=Int32[500]]
  MaximumProduct.'Linear - Sorted - O(n.log n)': DefaultJob [A=Int32[500]]
  MaximumProduct.'Linear - Traversal - O(n)': DefaultJob [A=Int32[500]]
  MaximumProduct.'Double-loop - O(n^2)': DefaultJob [A=Int32[50]]
  MaximumProduct.'Linear - Sorted - O(n.log n)': DefaultJob [A=Int32[50]]
  MaximumProduct.'Linear - Traversal - O(n)': DefaultJob [A=Int32[50]]
  MaximumProduct.'Double-loop - O(n^2)': DefaultJob [A=Int32[5]]
  MaximumProduct.'Linear - Sorted - O(n.log n)': DefaultJob [A=Int32[5]]
  MaximumProduct.'Linear - Traversal - O(n)': DefaultJob [A=Int32[5]]
