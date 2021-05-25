``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.409
  [Host] : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


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
