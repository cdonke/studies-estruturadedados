``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 18.04
Intel Xeon CPU E5-2673 v3 2.40GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host] : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


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
