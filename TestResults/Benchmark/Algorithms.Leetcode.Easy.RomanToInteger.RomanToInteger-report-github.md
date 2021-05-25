``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.409
  [Host] : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|   Method |       s | expected | Mean | Error |
|--------- |-------- |--------- |-----:|------:|
| **FirstTry** |       **I** |        **1** |   **NA** |    **NA** |
| **FirstTry** |     **III** |        **3** |   **NA** |    **NA** |
| **FirstTry** |      **IV** |        **4** |   **NA** |    **NA** |
| **FirstTry** |      **IX** |        **9** |   **NA** |    **NA** |
| **FirstTry** |   **LVIII** |       **58** |   **NA** |    **NA** |
| **FirstTry** | **MCMXCIV** |     **1994** |   **NA** |    **NA** |
| **FirstTry** |       **V** |        **5** |   **NA** |    **NA** |
| **FirstTry** |       **X** |       **10** |   **NA** |    **NA** |

Benchmarks with issues:
  RomanToInteger.FirstTry: DefaultJob [s=I, expected=1]
  RomanToInteger.FirstTry: DefaultJob [s=III, expected=3]
  RomanToInteger.FirstTry: DefaultJob [s=IV, expected=4]
  RomanToInteger.FirstTry: DefaultJob [s=IX, expected=9]
  RomanToInteger.FirstTry: DefaultJob [s=LVIII, expected=58]
  RomanToInteger.FirstTry: DefaultJob [s=MCMXCIV, expected=1994]
  RomanToInteger.FirstTry: DefaultJob [s=V, expected=5]
  RomanToInteger.FirstTry: DefaultJob [s=X, expected=10]
