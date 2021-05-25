``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.409
  [Host] : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|    Method |           x | expected | Mean | Error |
|---------- |------------ |--------- |-----:|------:|
|  **FirstTry** | **-2147483648** |        **0** |   **NA** |    **NA** |
| SecondTry | -2147483648 |        0 |   NA |    NA |
|  ThirdTry | -2147483648 |        0 |   NA |    NA |
|  **FirstTry** |        **-123** |     **-321** |   **NA** |    **NA** |
| SecondTry |        -123 |     -321 |   NA |    NA |
|  ThirdTry |        -123 |     -321 |   NA |    NA |
|  **FirstTry** |           **0** |        **0** |   **NA** |    **NA** |
| SecondTry |           0 |        0 |   NA |    NA |
|  ThirdTry |           0 |        0 |   NA |    NA |
|  **FirstTry** |         **120** |       **21** |   **NA** |    **NA** |
| SecondTry |         120 |       21 |   NA |    NA |
|  ThirdTry |         120 |       21 |   NA |    NA |
|  **FirstTry** |         **123** |      **321** |   **NA** |    **NA** |
| SecondTry |         123 |      321 |   NA |    NA |
|  ThirdTry |         123 |      321 |   NA |    NA |
|  **FirstTry** |  **1534236469** |        **0** |   **NA** |    **NA** |
| SecondTry |  1534236469 |        0 |   NA |    NA |
|  ThirdTry |  1534236469 |        0 |   NA |    NA |

Benchmarks with issues:
  ReverseInteger.FirstTry: DefaultJob [x=-2147483648, expected=0]
  ReverseInteger.SecondTry: DefaultJob [x=-2147483648, expected=0]
  ReverseInteger.ThirdTry: DefaultJob [x=-2147483648, expected=0]
  ReverseInteger.FirstTry: DefaultJob [x=-123, expected=-321]
  ReverseInteger.SecondTry: DefaultJob [x=-123, expected=-321]
  ReverseInteger.ThirdTry: DefaultJob [x=-123, expected=-321]
  ReverseInteger.FirstTry: DefaultJob [x=0, expected=0]
  ReverseInteger.SecondTry: DefaultJob [x=0, expected=0]
  ReverseInteger.ThirdTry: DefaultJob [x=0, expected=0]
  ReverseInteger.FirstTry: DefaultJob [x=120, expected=21]
  ReverseInteger.SecondTry: DefaultJob [x=120, expected=21]
  ReverseInteger.ThirdTry: DefaultJob [x=120, expected=21]
  ReverseInteger.FirstTry: DefaultJob [x=123, expected=321]
  ReverseInteger.SecondTry: DefaultJob [x=123, expected=321]
  ReverseInteger.ThirdTry: DefaultJob [x=123, expected=321]
  ReverseInteger.FirstTry: DefaultJob [x=1534236469, expected=0]
  ReverseInteger.SecondTry: DefaultJob [x=1534236469, expected=0]
  ReverseInteger.ThirdTry: DefaultJob [x=1534236469, expected=0]
