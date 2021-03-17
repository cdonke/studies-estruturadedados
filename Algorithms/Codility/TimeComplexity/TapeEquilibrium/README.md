# Exercise

A non-empty array A consisting of N integers is given. Array A represents numbers on a tape.

Any integer P, such that 0 < P < N, splits this tape into two non-empty parts: `A[0], A[1], ..., A[P − 1]` and `A[P], A[P + 1], ..., A[N − 1]`.

The difference between the two parts is the value of: `|(A[0] + A[1] + ... + A[P − 1]) − (A[P] + A[P + 1] + ... + A[N − 1])|`

In other words, it is the absolute difference between the sum of the first part and the sum of the second part.

For example, consider array A such that:
```
  A[0] = 3
  A[1] = 1
  A[2] = 2
  A[3] = 4
  A[4] = 3
```

We can split this tape in four places:

```
P = 1, difference = |3 − 10| = 7
P = 2, difference = |4 − 9| = 5
P = 3, difference = |6 − 7| = 1
P = 4, difference = |10 − 3| = 7
```

Write a function:

```
class Solution { public int solution(int[] A); }
```

that, given a non-empty array A of N integers, returns the minimal difference that can be achieved.

For example, given:
```
  A[0] = 3
  A[1] = 1
  A[2] = 2
  A[3] = 4
  A[4] = 3
```

the function should return 1, as explained above.

Write an efficient algorithm for the following assumptions:

- N is an integer within the range [2..100,000];
- each element of array A is an integer within the range [−1,000..1,000].

# Results
- [First Try](https://app.codility.com/demo/results/trainingNXSD2K-KQW/)
- [Second Try](https://app.codility.com/demo/results/trainingRRN428-VGA/)


# Benchmark

**Last update:** Wed Mar 17 12:18:22 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host] : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|               Method |        A | Mean | Error |
|--------------------- |--------- |-----:|------:|
|             FirstTry | Int32[5] |   NA |    NA |
|  FirstTry_BitwiseAbs | Int32[5] |   NA |    NA |
|            SecondTry | Int32[5] |   NA |    NA |
| SecondTry_BitwiseAbs | Int32[5] |   NA |    NA |

Benchmarks with issues:
  TapeEquilibrium.FirstTry: DefaultJob [A=Int32[5]]
  TapeEquilibrium.FirstTry_BitwiseAbs: DefaultJob [A=Int32[5]]
  TapeEquilibrium.SecondTry: DefaultJob [A=Int32[5]]
  TapeEquilibrium.SecondTry_BitwiseAbs: DefaultJob [A=Int32[5]]
