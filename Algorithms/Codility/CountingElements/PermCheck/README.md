# Exercise
A non-empty array A consisting of N integers is given.

A permutation is a sequence containing each element from 1 to N once, and only once.

For example, array A such that:
```
    A[0] = 4
    A[1] = 1
    A[2] = 3
    A[3] = 2
```
is a permutation, but array A such that:
```
    A[0] = 4
    A[1] = 1
    A[2] = 3
```
is not a permutation, because value 2 is missing.

The goal is to check whether array A is a permutation.

Write a function:
```
class Solution { public int solution(int[] A); }
```
that, given an array A, returns 1 if array A is a permutation and 0 if it is not.

For example, given array A such that:
```
    A[0] = 4
    A[1] = 1
    A[2] = 3
    A[3] = 2
```
the function should return 1.

Given array A such that:
```
    A[0] = 4
    A[1] = 1
    A[2] = 3
```
the function should return 0.

Write an efficient algorithm for the following assumptions:

- N is an integer within the range [1..100,000];
- each element of array A is an integer within the range [1..1,000,000,000].


# Results
- [First try](https://app.codility.com/demo/results/trainingT7NRTA-EYV/)

# Benchmark

**Last update:** Tue May 25 20:02:21 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.409
  [Host] : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|    Method |        A | expected | Mean | Error |
|---------- |--------- |--------- |-----:|------:|
|  **FirstTry** | **Int32[1]** |        **0** |   **NA** |    **NA** |
|  FirstTry | Int32[1] |        0 |   NA |    NA |
| SecondTry | Int32[1] |        0 |   NA |    NA |
| SecondTry | Int32[1] |        0 |   NA |    NA |
|  **FirstTry** | **Int32[2]** |        **0** |   **NA** |    **NA** |
|  FirstTry | Int32[2] |        0 |   NA |    NA |
| SecondTry | Int32[2] |        0 |   NA |    NA |
| SecondTry | Int32[2] |        0 |   NA |    NA |
|  **FirstTry** | **Int32[2]** |        **1** |   **NA** |    **NA** |
|  FirstTry | Int32[2] |        1 |   NA |    NA |
| SecondTry | Int32[2] |        1 |   NA |    NA |
| SecondTry | Int32[2] |        1 |   NA |    NA |

Benchmarks with issues:
  PermCheck.FirstTry: DefaultJob [A=Int32[1], expected=0]
  PermCheck.FirstTry: DefaultJob [A=Int32[1], expected=0]
  PermCheck.SecondTry: DefaultJob [A=Int32[1], expected=0]
  PermCheck.SecondTry: DefaultJob [A=Int32[1], expected=0]
  PermCheck.FirstTry: DefaultJob [A=Int32[2], expected=0]
  PermCheck.FirstTry: DefaultJob [A=Int32[2], expected=0]
  PermCheck.SecondTry: DefaultJob [A=Int32[2], expected=0]
  PermCheck.SecondTry: DefaultJob [A=Int32[2], expected=0]
  PermCheck.FirstTry: DefaultJob [A=Int32[2], expected=1]
  PermCheck.FirstTry: DefaultJob [A=Int32[2], expected=1]
  PermCheck.SecondTry: DefaultJob [A=Int32[2], expected=1]
  PermCheck.SecondTry: DefaultJob [A=Int32[2], expected=1]
