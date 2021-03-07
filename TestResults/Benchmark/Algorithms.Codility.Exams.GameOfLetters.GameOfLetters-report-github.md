``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|                              Method |      S |        A |      Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------ |------- |--------- |----------:|---------:|---------:|-------:|------:|------:|----------:|
|  **&#39;First try: String.Join + Replace&#39;** | **bytdag** | **Int32[6]** | **271.81 ns** | **4.057 ns** | **3.388 ns** | **0.0153** |     **-** |     **-** |     **288 B** |
|         &#39;Second try: StringBuilder&#39; | bytdag | Int32[6] |  42.60 ns | 0.836 ns | 0.741 ns | 0.0064 |     - |     - |     120 B |
|    &#39;Third try: string[] + trim(\0)&#39; | bytdag | Int32[6] |  49.22 ns | 0.708 ns | 0.662 ns | 0.0060 |     - |     - |     112 B |
| &#39;Fourth try: string.join arraycopy&#39; | bytdag | Int32[6] | 146.21 ns | 1.736 ns | 1.539 ns | 0.0110 |     - |     - |     208 B |
|  **&#39;First try: String.Join + Replace&#39;** |   **cdeo** | **Int32[4]** | **159.37 ns** | **2.955 ns** | **3.285 ns** | **0.0103** |     **-** |     **-** |     **192 B** |
|         &#39;Second try: StringBuilder&#39; |   cdeo | Int32[4] |  44.70 ns | 0.470 ns | 0.392 ns | 0.0060 |     - |     - |     112 B |
|    &#39;Third try: string[] + trim(\0)&#39; |   cdeo | Int32[4] |  31.54 ns | 0.312 ns | 0.276 ns | 0.0034 |     - |     - |      64 B |
| &#39;Fourth try: string.join arraycopy&#39; |   cdeo | Int32[4] | 168.87 ns | 3.253 ns | 3.195 ns | 0.0119 |     - |     - |     224 B |
