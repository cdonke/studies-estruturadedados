``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host]     : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  DefaultJob : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|                         Method |           A |          Mean |        Error |       StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------- |------------ |--------------:|-------------:|-------------:|------:|------:|------:|----------:|
|         **&#39;Double-loop - O(n^2)&#39;** | **Int32[1000]** | **378,088.10 ns** | **6,020.898 ns** | **5,631.952 ns** |     **-** |     **-** |     **-** |         **-** |
| &#39;Linear - Sorted - O(n.log n)&#39; | Int32[1000] |   7,791.88 ns |   144.892 ns |   135.532 ns |     - |     - |     - |         - |
|    &#39;Linear - Traversal - O(n)&#39; | Int32[1000] |   2,752.37 ns |    52.195 ns |    53.601 ns |     - |     - |     - |         - |
|         **&#39;Double-loop - O(n^2)&#39;** |  **Int32[100]** |   **5,487.31 ns** |    **87.406 ns** |    **77.483 ns** |     **-** |     **-** |     **-** |         **-** |
| &#39;Linear - Sorted - O(n.log n)&#39; |  Int32[100] |     478.51 ns |     6.865 ns |     5.360 ns |     - |     - |     - |         - |
|    &#39;Linear - Traversal - O(n)&#39; |  Int32[100] |     264.43 ns |     4.476 ns |     4.187 ns |     - |     - |     - |         - |
|         **&#39;Double-loop - O(n^2)&#39;** |   **Int32[15]** |     **169.20 ns** |     **2.973 ns** |     **3.424 ns** |     **-** |     **-** |     **-** |         **-** |
| &#39;Linear - Sorted - O(n.log n)&#39; |   Int32[15] |      52.46 ns |     1.059 ns |     0.991 ns |     - |     - |     - |         - |
|    &#39;Linear - Traversal - O(n)&#39; |   Int32[15] |      36.94 ns |     0.657 ns |     0.615 ns |     - |     - |     - |         - |
|         **&#39;Double-loop - O(n^2)&#39;** |  **Int32[500]** | **100,065.53 ns** | **1,834.134 ns** | **1,715.650 ns** |     **-** |     **-** |     **-** |       **1 B** |
| &#39;Linear - Sorted - O(n.log n)&#39; |  Int32[500] |   3,291.59 ns |    46.488 ns |    43.485 ns |     - |     - |     - |         - |
|    &#39;Linear - Traversal - O(n)&#39; |  Int32[500] |   1,344.71 ns |    15.992 ns |    13.354 ns |     - |     - |     - |         - |
|         **&#39;Double-loop - O(n^2)&#39;** |   **Int32[50]** |   **1,707.21 ns** |    **16.359 ns** |    **14.502 ns** |     **-** |     **-** |     **-** |         **-** |
| &#39;Linear - Sorted - O(n.log n)&#39; |   Int32[50] |     207.35 ns |     3.641 ns |     3.406 ns |     - |     - |     - |         - |
|    &#39;Linear - Traversal - O(n)&#39; |   Int32[50] |     126.05 ns |     2.505 ns |     3.168 ns |     - |     - |     - |         - |
|         **&#39;Double-loop - O(n^2)&#39;** |    **Int32[5]** |      **22.40 ns** |     **0.346 ns** |     **0.323 ns** |     **-** |     **-** |     **-** |         **-** |
| &#39;Linear - Sorted - O(n.log n)&#39; |    Int32[5] |      27.09 ns |     0.243 ns |     0.215 ns |     - |     - |     - |         - |
|    &#39;Linear - Traversal - O(n)&#39; |    Int32[5] |      13.95 ns |     0.284 ns |     0.237 ns |     - |     - |     - |         - |
