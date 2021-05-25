# Exercise

Write a function that, given an integer N, returns the smallest integer greater than N, 
the sum of whose digits is twice as big as the sum of digits on N.

Examples:
1) Given N=14, the function should return 19. The sum of digits of 19 (1+9=10) is twice as big as sum of digits of 14 (1+4=5)
1) Given N=10, the function should return 11.
1) Given N=99,the function should return 9999.

Assume that:
- N is an integer within the range [1..500]
     
In your solution, focus on correctness. The performance of your solution will no be the focus of the assessment.

# Benchmark

**Last update:** Tue May 25 20:02:21 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.409
  [Host] : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|   Method |  N | Mean | Error |
|--------- |--- |-----:|------:|
| **FirstTry** | **10** |   **NA** |    **NA** |
| **FirstTry** | **14** |   **NA** |    **NA** |
| **FirstTry** | **99** |   **NA** |    **NA** |

Benchmarks with issues:
  SumOfDigits.FirstTry: DefaultJob [N=10]
  SumOfDigits.FirstTry: DefaultJob [N=14]
  SumOfDigits.FirstTry: DefaultJob [N=99]
