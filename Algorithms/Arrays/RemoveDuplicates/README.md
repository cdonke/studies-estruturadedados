# Exercise

Given a sorted array:
```
[ 1, 2, 2, 6, 6, 8, 9, 10, 10 ]
```

Remove the duplicates, without changing the array length:

```
[ 1, 2, 6, 8, 9, 10, 0, 0, 0 ]
```

# Benchmark

**Last update:** Tue Mar 16 12:06:48 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host] : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|                  Method |        A | Mean | Error |
|------------------------ |--------- |-----:|------:|
| **&#39;With new Array - O(n)&#39;** | **Int32[4]** |   **NA** |    **NA** |
| &#39;With sorting - O(n^2)&#39; | Int32[4] |   NA |    NA |
|   &#39;With Hashset - O(n)&#39; | Int32[4] |   NA |    NA |
|                In-place | Int32[4] |   NA |    NA |
| **&#39;With new Array - O(n)&#39;** | **Int32[6]** |   **NA** |    **NA** |
| &#39;With sorting - O(n^2)&#39; | Int32[6] |   NA |    NA |
|   &#39;With Hashset - O(n)&#39; | Int32[6] |   NA |    NA |
|                In-place | Int32[6] |   NA |    NA |
| **&#39;With new Array - O(n)&#39;** | **Int32[7]** |   **NA** |    **NA** |
| &#39;With sorting - O(n^2)&#39; | Int32[7] |   NA |    NA |
|   &#39;With Hashset - O(n)&#39; | Int32[7] |   NA |    NA |
|                In-place | Int32[7] |   NA |    NA |
| **&#39;With new Array - O(n)&#39;** | **Int32[9]** |   **NA** |    **NA** |
| &#39;With sorting - O(n^2)&#39; | Int32[9] |   NA |    NA |
|   &#39;With Hashset - O(n)&#39; | Int32[9] |   NA |    NA |
|                In-place | Int32[9] |   NA |    NA |

Benchmarks with issues:
  RemoveDuplicates.'With new Array - O(n)': DefaultJob [A=Int32[4]]
  RemoveDuplicates.'With sorting - O(n^2)': DefaultJob [A=Int32[4]]
  RemoveDuplicates.'With Hashset - O(n)': DefaultJob [A=Int32[4]]
  RemoveDuplicates.In-place: DefaultJob [A=Int32[4]]
  RemoveDuplicates.'With new Array - O(n)': DefaultJob [A=Int32[6]]
  RemoveDuplicates.'With sorting - O(n^2)': DefaultJob [A=Int32[6]]
  RemoveDuplicates.'With Hashset - O(n)': DefaultJob [A=Int32[6]]
  RemoveDuplicates.In-place: DefaultJob [A=Int32[6]]
  RemoveDuplicates.'With new Array - O(n)': DefaultJob [A=Int32[7]]
  RemoveDuplicates.'With sorting - O(n^2)': DefaultJob [A=Int32[7]]
  RemoveDuplicates.'With Hashset - O(n)': DefaultJob [A=Int32[7]]
  RemoveDuplicates.In-place: DefaultJob [A=Int32[7]]
  RemoveDuplicates.'With new Array - O(n)': DefaultJob [A=Int32[9]]
  RemoveDuplicates.'With sorting - O(n^2)': DefaultJob [A=Int32[9]]
  RemoveDuplicates.'With Hashset - O(n)': DefaultJob [A=Int32[9]]
  RemoveDuplicates.In-place: DefaultJob [A=Int32[9]]
