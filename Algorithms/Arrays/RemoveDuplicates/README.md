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

**Last update:** Mon Mar  8 13:09:01 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|                  Method |        A |       Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------ |--------- |-----------:|----------:|----------:|-------:|------:|------:|----------:|
| **&#39;With new Array - O(n)&#39;** | **Int32[4]** |  **18.128 ns** | **0.4521 ns** | **0.4228 ns** | **0.0021** |     **-** |     **-** |      **40 B** |
| &#39;With sorting - O(n^2)&#39; | Int32[4] |  11.397 ns | 0.1092 ns | 0.0968 ns |      - |     - |     - |         - |
|   &#39;With Hashset - O(n)&#39; | Int32[4] | 146.902 ns | 2.6761 ns | 2.5033 ns | 0.0110 |     - |     - |     208 B |
|                In-place | Int32[4] |   4.298 ns | 0.0772 ns | 0.0684 ns |      - |     - |     - |         - |
| **&#39;With new Array - O(n)&#39;** | **Int32[6]** |  **24.088 ns** | **0.5649 ns** | **0.5284 ns** | **0.0026** |     **-** |     **-** |      **48 B** |
| &#39;With sorting - O(n^2)&#39; | Int32[6] |  50.779 ns | 0.4638 ns | 0.4338 ns |      - |     - |     - |         - |
|   &#39;With Hashset - O(n)&#39; | Int32[6] | 180.527 ns | 2.1059 ns | 1.9698 ns | 0.0114 |     - |     - |     216 B |
|                In-place | Int32[6] |   9.665 ns | 0.1989 ns | 0.1860 ns |      - |     - |     - |         - |
| **&#39;With new Array - O(n)&#39;** | **Int32[7]** |  **26.164 ns** | **0.3518 ns** | **0.3291 ns** | **0.0030** |     **-** |     **-** |      **56 B** |
| &#39;With sorting - O(n^2)&#39; | Int32[7] |  58.539 ns | 0.9180 ns | 0.8587 ns |      - |     - |     - |         - |
|   &#39;With Hashset - O(n)&#39; | Int32[7] | 296.065 ns | 3.2488 ns | 3.0389 ns | 0.0205 |     - |     - |     392 B |
|                In-place | Int32[7] |   8.875 ns | 0.0726 ns | 0.0606 ns |      - |     - |     - |         - |
| **&#39;With new Array - O(n)&#39;** | **Int32[9]** |  **33.471 ns** | **0.4803 ns** | **0.4492 ns** | **0.0034** |     **-** |     **-** |      **64 B** |
| &#39;With sorting - O(n^2)&#39; | Int32[9] | 109.596 ns | 0.3551 ns | 0.3322 ns |      - |     - |     - |         - |
|   &#39;With Hashset - O(n)&#39; | Int32[9] | 327.034 ns | 2.0763 ns | 1.8406 ns | 0.0210 |     - |     - |     400 B |
|                In-place | Int32[9] |  11.415 ns | 0.2258 ns | 0.2112 ns |      - |     - |     - |         - |
