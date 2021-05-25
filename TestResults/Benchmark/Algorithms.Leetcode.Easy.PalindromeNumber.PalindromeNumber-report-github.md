``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.409
  [Host] : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|    Method |    x | expected | Mean | Error |
|---------- |----- |--------- |-----:|------:|
|  **FirstTry** | **-121** |    **False** |   **NA** |    **NA** |
| SecondTry | -121 |    False |   NA |    NA |
|  **FirstTry** | **-101** |    **False** |   **NA** |    **NA** |
| SecondTry | -101 |    False |   NA |    NA |
|  **FirstTry** |    **0** |     **True** |   **NA** |    **NA** |
| SecondTry |    0 |     True |   NA |    NA |
|  **FirstTry** |   **10** |    **False** |   **NA** |    **NA** |
| SecondTry |   10 |    False |   NA |    NA |
|  **FirstTry** |  **121** |     **True** |   **NA** |    **NA** |
| SecondTry |  121 |     True |   NA |    NA |
|  **FirstTry** | **1221** |     **True** |   **NA** |    **NA** |
| SecondTry | 1221 |     True |   NA |    NA |

Benchmarks with issues:
  PalindromeNumber.FirstTry: DefaultJob [x=-121, expected=False]
  PalindromeNumber.SecondTry: DefaultJob [x=-121, expected=False]
  PalindromeNumber.FirstTry: DefaultJob [x=-101, expected=False]
  PalindromeNumber.SecondTry: DefaultJob [x=-101, expected=False]
  PalindromeNumber.FirstTry: DefaultJob [x=0, expected=True]
  PalindromeNumber.SecondTry: DefaultJob [x=0, expected=True]
  PalindromeNumber.FirstTry: DefaultJob [x=10, expected=False]
  PalindromeNumber.SecondTry: DefaultJob [x=10, expected=False]
  PalindromeNumber.FirstTry: DefaultJob [x=121, expected=True]
  PalindromeNumber.SecondTry: DefaultJob [x=121, expected=True]
  PalindromeNumber.FirstTry: DefaultJob [x=1221, expected=True]
  PalindromeNumber.SecondTry: DefaultJob [x=1221, expected=True]
