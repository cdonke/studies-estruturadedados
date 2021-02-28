# Exercise

Given:
- S is a string of randomized letters
- A[] is a list of players


Every time a player join the game, he is added to a K[] list.
He is noted as the k-th player, and his index is added to A[] as he plays.

# Benchmark

```
**Last update:** Sun Feb 28 15:29:47 UTC 2021
```
``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 18.04
Intel Xeon CPU E5-2673 v3 2.40GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|                              Method |      S |        A |      Mean |    Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------ |------- |--------- |----------:|---------:|----------:|-------:|------:|------:|----------:|
|  **&#39;First try: String.Join + Replace&#39;** | **bytdag** | **Int32[6]** | **359.75 ns** | **7.284 ns** | **11.968 ns** | **0.0181** |     **-** |     **-** |     **288 B** |
|         &#39;Second try: StringBuilder&#39; | bytdag | Int32[6] |  53.17 ns | 1.142 ns |  2.624 ns | 0.0076 |     - |     - |     120 B |
|    &#39;Third try: string[] + trim(\0)&#39; | bytdag | Int32[6] |  59.52 ns | 1.282 ns |  1.755 ns | 0.0070 |     - |     - |     112 B |
| &#39;Fourth try: string.join arraycopy&#39; | bytdag | Int32[6] | 207.49 ns | 4.187 ns |  6.761 ns | 0.0131 |     - |     - |     208 B |
|  **&#39;First try: String.Join + Replace&#39;** |   **cdeo** | **Int32[4]** | **232.45 ns** | **4.691 ns** |  **5.933 ns** | **0.0122** |     **-** |     **-** |     **192 B** |
|         &#39;Second try: StringBuilder&#39; |   cdeo | Int32[4] |  60.33 ns | 1.167 ns |  1.034 ns | 0.0070 |     - |     - |     112 B |
|    &#39;Third try: string[] + trim(\0)&#39; |   cdeo | Int32[4] |  40.85 ns | 0.922 ns |  1.025 ns | 0.0041 |     - |     - |      64 B |
| &#39;Fourth try: string.join arraycopy&#39; |   cdeo | Int32[4] | 236.88 ns | 4.814 ns |  9.041 ns | 0.0138 |     - |     - |     224 B |
