``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 18.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|                              Method |      S |        A |      Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------ |------- |--------- |----------:|---------:|---------:|-------:|------:|------:|----------:|
|  **&#39;First try: String.Join + Replace&#39;** | **bytdag** | **Int32[6]** | **420.83 ns** | **5.274 ns** | **4.675 ns** | **0.0110** |     **-** |     **-** |     **288 B** |
|         &#39;Second try: StringBuilder&#39; | bytdag | Int32[6] |  70.46 ns | 1.507 ns | 3.669 ns | 0.0045 |     - |     - |     120 B |
|    &#39;Third try: string[] + trim(\0)&#39; | bytdag | Int32[6] |  80.73 ns | 1.711 ns | 2.285 ns | 0.0042 |     - |     - |     112 B |
| &#39;Fourth try: string.join arraycopy&#39; | bytdag | Int32[6] | 240.16 ns | 3.773 ns | 3.529 ns | 0.0079 |     - |     - |     208 B |
|  **&#39;First try: String.Join + Replace&#39;** |   **cdeo** | **Int32[4]** | **250.76 ns** | **3.128 ns** | **2.926 ns** | **0.0072** |     **-** |     **-** |     **192 B** |
|         &#39;Second try: StringBuilder&#39; |   cdeo | Int32[4] |  76.12 ns | 1.580 ns | 1.881 ns | 0.0042 |     - |     - |     112 B |
|    &#39;Third try: string[] + trim(\0)&#39; |   cdeo | Int32[4] |  50.47 ns | 1.082 ns | 1.062 ns | 0.0024 |     - |     - |      64 B |
| &#39;Fourth try: string.join arraycopy&#39; |   cdeo | Int32[4] | 275.48 ns | 5.161 ns | 4.828 ns | 0.0081 |     - |     - |     224 B |
