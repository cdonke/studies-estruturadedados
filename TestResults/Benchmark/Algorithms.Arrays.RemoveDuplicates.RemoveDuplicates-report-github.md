``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|                  Method |        A |       Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------ |--------- |-----------:|----------:|----------:|-------:|------:|------:|----------:|
| **&#39;With new Array - O(n)&#39;** | **Int32[4]** |  **10.744 ns** | **0.1645 ns** | **0.1458 ns** | **0.0021** |     **-** |     **-** |      **40 B** |
| &#39;With sorting - O(n^2)&#39; | Int32[4] |   8.402 ns | 0.1864 ns | 0.1744 ns |      - |     - |     - |         - |
|   &#39;With Hashset - O(n)&#39; | Int32[4] |  95.272 ns | 0.9017 ns | 0.8434 ns | 0.0111 |     - |     - |     208 B |
|                In-place | Int32[4] |   3.725 ns | 0.0964 ns | 0.0854 ns |      - |     - |     - |         - |
| **&#39;With new Array - O(n)&#39;** | **Int32[6]** |  **13.427 ns** | **0.1967 ns** | **0.1840 ns** | **0.0026** |     **-** |     **-** |      **48 B** |
| &#39;With sorting - O(n^2)&#39; | Int32[6] |  37.165 ns | 0.5546 ns | 0.4917 ns |      - |     - |     - |         - |
|   &#39;With Hashset - O(n)&#39; | Int32[6] | 117.973 ns | 1.5105 ns | 1.3390 ns | 0.0114 |     - |     - |     216 B |
|                In-place | Int32[6] |   7.588 ns | 0.1776 ns | 0.1662 ns |      - |     - |     - |         - |
| **&#39;With new Array - O(n)&#39;** | **Int32[7]** |  **17.057 ns** | **0.2828 ns** | **0.2507 ns** | **0.0030** |     **-** |     **-** |      **56 B** |
| &#39;With sorting - O(n^2)&#39; | Int32[7] |  43.952 ns | 0.5661 ns | 0.5295 ns |      - |     - |     - |         - |
|   &#39;With Hashset - O(n)&#39; | Int32[7] | 189.542 ns | 3.7399 ns | 3.6730 ns | 0.0207 |     - |     - |     392 B |
|                In-place | Int32[7] |   6.800 ns | 0.2001 ns | 0.1871 ns |      - |     - |     - |         - |
| **&#39;With new Array - O(n)&#39;** | **Int32[9]** |  **20.314 ns** | **0.2702 ns** | **0.2256 ns** | **0.0034** |     **-** |     **-** |      **64 B** |
| &#39;With sorting - O(n^2)&#39; | Int32[9] |  81.281 ns | 1.3151 ns | 1.2301 ns |      - |     - |     - |         - |
|   &#39;With Hashset - O(n)&#39; | Int32[9] | 211.584 ns | 2.1604 ns | 2.0209 ns | 0.0212 |     - |     - |     400 B |
|                In-place | Int32[9] |   8.794 ns | 0.1449 ns | 0.1284 ns |      - |     - |     - |         - |
