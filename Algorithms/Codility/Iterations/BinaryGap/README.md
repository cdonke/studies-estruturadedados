# Exercise


A _binary gap_ within a positive integer N is any maximal sequence of consecutive zeros that is surrounded by ones at both ends in the binary representation of N.

For example, number 9 has binary representation 1001 and contains a binary gap of length 2. The number 529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3. The number 20 has binary representation 10100 and contains one binary gap of length 1. The number 15 has binary representation 1111 and has no binary gaps. The number 32 has binary representation 100000 and has no binary gaps.

Write a function:

```
class Solution { public int solution(int N); }
```

that, given a positive integer N, returns the length of its longest binary gap. The function should return 0 if N doesn't contain a binary gap.

For example, given N = 1041 the function should return 5, because N has binary representation 10000010001 and so its longest binary gap is of length 5. Given N = 32 the function should return 0, because N has binary representation '100000' and thus no binary gaps.

Write an efficient algorithm for the following assumptions:

- N is an integer within the range [1..2,147,483,647].

# Results
https://app.codility.com/demo/results/trainingDVVF6N-MKK/

# Benchmark

**Last update:** Mon Mar 15 19:23:41 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host] : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|    Method |    N | Mean | Error |
|---------- |----- |-----:|------:|
|  **FirstTry** |    **1** |   **NA** |    **NA** |
| SecondTry |    1 |   NA |    NA |
|  **FirstTry** |    **2** |   **NA** |    **NA** |
| SecondTry |    2 |   NA |    NA |
|  **FirstTry** |   **15** |   **NA** |    **NA** |
| SecondTry |   15 |   NA |    NA |
|  **FirstTry** |   **32** |   **NA** |    **NA** |
| SecondTry |   32 |   NA |    NA |
|  **FirstTry** |  **147** |   **NA** |    **NA** |
| SecondTry |  147 |   NA |    NA |
|  **FirstTry** |  **483** |   **NA** |    **NA** |
| SecondTry |  483 |   NA |    NA |
|  **FirstTry** |  **647** |   **NA** |    **NA** |
| SecondTry |  647 |   NA |    NA |
|  **FirstTry** | **1041** |   **NA** |    **NA** |
| SecondTry | 1041 |   NA |    NA |

Benchmarks with issues:
  BinaryGap.FirstTry: DefaultJob [N=1]
  BinaryGap.SecondTry: DefaultJob [N=1]
  BinaryGap.FirstTry: DefaultJob [N=2]
  BinaryGap.SecondTry: DefaultJob [N=2]
  BinaryGap.FirstTry: DefaultJob [N=15]
  BinaryGap.SecondTry: DefaultJob [N=15]
  BinaryGap.FirstTry: DefaultJob [N=32]
  BinaryGap.SecondTry: DefaultJob [N=32]
  BinaryGap.FirstTry: DefaultJob [N=147]
  BinaryGap.SecondTry: DefaultJob [N=147]
  BinaryGap.FirstTry: DefaultJob [N=483]
  BinaryGap.SecondTry: DefaultJob [N=483]
  BinaryGap.FirstTry: DefaultJob [N=647]
  BinaryGap.SecondTry: DefaultJob [N=647]
  BinaryGap.FirstTry: DefaultJob [N=1041]
  BinaryGap.SecondTry: DefaultJob [N=1041]
