# Exercise

Given:
- S is a string of randomized letters
- A[] is a list of players


Every time a player join the game, he is added to a K[] list.
He is noted as the k-th player, and his index is added to A[] as he plays.

# Benchmark

**Last update:** Tue Mar 16 12:06:48 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host] : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|                              Method |      S |        A | Mean | Error |
|------------------------------------ |------- |--------- |-----:|------:|
|  **&#39;First try: String.Join + Replace&#39;** | **bytdag** | **Int32[6]** |   **NA** |    **NA** |
|         &#39;Second try: StringBuilder&#39; | bytdag | Int32[6] |   NA |    NA |
|    &#39;Third try: string[] + trim(\0)&#39; | bytdag | Int32[6] |   NA |    NA |
| &#39;Fourth try: string.join arraycopy&#39; | bytdag | Int32[6] |   NA |    NA |
|  **&#39;First try: String.Join + Replace&#39;** |   **cdeo** | **Int32[4]** |   **NA** |    **NA** |
|         &#39;Second try: StringBuilder&#39; |   cdeo | Int32[4] |   NA |    NA |
|    &#39;Third try: string[] + trim(\0)&#39; |   cdeo | Int32[4] |   NA |    NA |
| &#39;Fourth try: string.join arraycopy&#39; |   cdeo | Int32[4] |   NA |    NA |

Benchmarks with issues:
  GameOfLetters.'First try: String.Join + Replace': DefaultJob [S=bytdag, A=Int32[6]]
  GameOfLetters.'Second try: StringBuilder': DefaultJob [S=bytdag, A=Int32[6]]
  GameOfLetters.'Third try: string[] + trim(\0)': DefaultJob [S=bytdag, A=Int32[6]]
  GameOfLetters.'Fourth try: string.join arraycopy': DefaultJob [S=bytdag, A=Int32[6]]
  GameOfLetters.'First try: String.Join + Replace': DefaultJob [S=cdeo, A=Int32[4]]
  GameOfLetters.'Second try: StringBuilder': DefaultJob [S=cdeo, A=Int32[4]]
  GameOfLetters.'Third try: string[] + trim(\0)': DefaultJob [S=cdeo, A=Int32[4]]
  GameOfLetters.'Fourth try: string.join arraycopy': DefaultJob [S=cdeo, A=Int32[4]]
