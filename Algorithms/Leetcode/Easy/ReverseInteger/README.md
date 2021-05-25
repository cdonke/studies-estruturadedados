# Exercise
Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

Assume the environment does not allow you to store 64-bit integers (signed or unsigned).

 

**Example 1:**
```
Input: x = 123
Output: 321
```

**Example 2:**
```
Input: x = -123
Output: -321
```

**Example 3:**
```
Input: x = 120
Output: 21
```

**Example 4:**
```
Input: x = 0
Output: 0
```

**Constraints:**
- `-231 <= x <= 231 - 1`

# Benchmark

**Last update:** Tue May 25 20:02:21 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
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
