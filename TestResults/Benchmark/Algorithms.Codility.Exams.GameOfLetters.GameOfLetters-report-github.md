``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host]     : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  DefaultJob : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|                              Method |      S |        A |      Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------ |------- |--------- |----------:|---------:|---------:|-------:|------:|------:|----------:|
|  **&#39;First try: String.Join + Replace&#39;** | **bytdag** | **Int32[6]** | **314.84 ns** | **6.363 ns** | **7.072 ns** | **0.0110** |     **-** |     **-** |     **288 B** |
|         &#39;Second try: StringBuilder&#39; | bytdag | Int32[6] |  46.22 ns | 0.802 ns | 0.626 ns | 0.0046 |     - |     - |     120 B |
|    &#39;Third try: string[] + trim(\0)&#39; | bytdag | Int32[6] |  52.61 ns | 1.108 ns | 1.361 ns | 0.0042 |     - |     - |     112 B |
| &#39;Fourth try: string.join arraycopy&#39; | bytdag | Int32[6] | 170.38 ns | 3.328 ns | 3.418 ns | 0.0079 |     - |     - |     208 B |
|  **&#39;First try: String.Join + Replace&#39;** |   **cdeo** | **Int32[4]** | **186.59 ns** | **3.228 ns** | **4.082 ns** | **0.0072** |     **-** |     **-** |     **192 B** |
|         &#39;Second try: StringBuilder&#39; |   cdeo | Int32[4] |  49.64 ns | 1.042 ns | 0.974 ns | 0.0042 |     - |     - |     112 B |
|    &#39;Third try: string[] + trim(\0)&#39; |   cdeo | Int32[4] |  34.22 ns | 0.632 ns | 0.560 ns | 0.0024 |     - |     - |      64 B |
| &#39;Fourth try: string.join arraycopy&#39; |   cdeo | Int32[4] | 194.55 ns | 3.807 ns | 5.083 ns | 0.0083 |     - |     - |     224 B |
