# Exercise

Given:
- S is a string of randomized letters
- A[] is a list of players


Every time a player join the game, he is added to a K[] list.
He is noted as the k-th player, and his index is added to A[] as he plays.

# Benchmark

**Last update:** Mon Mar  8 13:09:01 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|                              Method |      S |        A |      Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------ |------- |--------- |----------:|---------:|---------:|-------:|------:|------:|----------:|
|  **&#39;First try: String.Join + Replace&#39;** | **bytdag** | **Int32[6]** | **396.58 ns** | **1.181 ns** | **0.986 ns** | **0.0153** |     **-** |     **-** |     **288 B** |
|         &#39;Second try: StringBuilder&#39; | bytdag | Int32[6] |  70.86 ns | 1.500 ns | 1.667 ns | 0.0063 |     - |     - |     120 B |
|    &#39;Third try: string[] + trim(\0)&#39; | bytdag | Int32[6] |  79.43 ns | 0.712 ns | 0.631 ns | 0.0060 |     - |     - |     112 B |
| &#39;Fourth try: string.join arraycopy&#39; | bytdag | Int32[6] | 223.81 ns | 4.414 ns | 4.129 ns | 0.0110 |     - |     - |     208 B |
|  **&#39;First try: String.Join + Replace&#39;** |   **cdeo** | **Int32[4]** | **236.17 ns** | **1.158 ns** | **1.026 ns** | **0.0100** |     **-** |     **-** |     **192 B** |
|         &#39;Second try: StringBuilder&#39; |   cdeo | Int32[4] |  71.53 ns | 0.619 ns | 0.579 ns | 0.0060 |     - |     - |     112 B |
|    &#39;Third try: string[] + trim(\0)&#39; |   cdeo | Int32[4] |  49.56 ns | 0.452 ns | 0.423 ns | 0.0034 |     - |     - |      64 B |
| &#39;Fourth try: string.join arraycopy&#39; |   cdeo | Int32[4] | 250.27 ns | 2.088 ns | 1.954 ns | 0.0119 |     - |     - |     224 B |
