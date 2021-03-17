``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host]     : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  DefaultJob : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|                  Method |        A |       Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------ |--------- |-----------:|----------:|----------:|-------:|------:|------:|----------:|
| **&#39;With new Array - O(n)&#39;** | **Int32[4]** |  **12.585 ns** | **0.2958 ns** | **0.3288 ns** | **0.0015** |     **-** |     **-** |      **40 B** |
| &#39;With sorting - O(n^2)&#39; | Int32[4] |  11.138 ns | 0.2334 ns | 0.2069 ns |      - |     - |     - |         - |
|   &#39;With Hashset - O(n)&#39; | Int32[4] | 107.930 ns | 2.1283 ns | 2.1856 ns | 0.0079 |     - |     - |     208 B |
|                In-place | Int32[4] |   3.993 ns | 0.1075 ns | 0.0953 ns |      - |     - |     - |         - |
| **&#39;With new Array - O(n)&#39;** | **Int32[6]** |  **14.289 ns** | **0.3426 ns** | **0.3666 ns** | **0.0018** |     **-** |     **-** |      **48 B** |
| &#39;With sorting - O(n^2)&#39; | Int32[6] |  38.723 ns | 0.6542 ns | 0.6119 ns |      - |     - |     - |         - |
|   &#39;With Hashset - O(n)&#39; | Int32[6] | 137.844 ns | 2.4126 ns | 2.2568 ns | 0.0081 |     - |     - |     216 B |
|                In-place | Int32[6] |   7.233 ns | 0.1268 ns | 0.1124 ns |      - |     - |     - |         - |
| **&#39;With new Array - O(n)&#39;** | **Int32[7]** |  **16.562 ns** | **0.3955 ns** | **0.4396 ns** | **0.0021** |     **-** |     **-** |      **56 B** |
| &#39;With sorting - O(n^2)&#39; | Int32[7] |  46.813 ns | 0.9475 ns | 0.8863 ns |      - |     - |     - |         - |
|   &#39;With Hashset - O(n)&#39; | Int32[7] | 215.051 ns | 4.2116 ns | 4.3250 ns | 0.0148 |     - |     - |     392 B |
|                In-place | Int32[7] |   8.152 ns | 0.1563 ns | 0.1462 ns |      - |     - |     - |         - |
| **&#39;With new Array - O(n)&#39;** | **Int32[9]** |  **19.912 ns** | **0.4581 ns** | **0.4061 ns** | **0.0024** |     **-** |     **-** |      **64 B** |
| &#39;With sorting - O(n^2)&#39; | Int32[9] |  82.130 ns | 1.4905 ns | 1.2446 ns |      - |     - |     - |         - |
|   &#39;With Hashset - O(n)&#39; | Int32[9] | 254.275 ns | 5.1229 ns | 6.2913 ns | 0.0153 |     - |     - |     400 B |
|                In-place | Int32[9] |  10.819 ns | 0.2806 ns | 0.2625 ns |      - |     - |     - |         - |
