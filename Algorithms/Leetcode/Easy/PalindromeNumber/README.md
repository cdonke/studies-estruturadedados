# Exercise
Given an integer x, return true if x is palindrome integer.

An integer is a palindrome when it reads the same backward as forward. For example, 121 is palindrome while 123 is not.

 

**Example 1:**
```
Input: x = 121
Output: true
```

**Example 2:**
```
Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
```

**Example 3:**
```
Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
```

**Example 4:**
```
Input: x = -101
Output: false
```

**Constraints:**
- `-231 <= x <= 231 - 1`

# Benchmark

**Last update:** Tue May 25 19:55:36 UTC 2021

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
