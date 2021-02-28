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
``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 18.04
Intel Xeon CPU E5-2673 v3 2.40GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host] : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|    Method |         A | Mean | Error |
|---------- |---------- |-----:|------:|
|  FirstTry | Object[2] |   NA |    NA |
|  FirstTry | Object[2] |   NA |    NA |
|  FirstTry | Object[2] |   NA |    NA |
|  FirstTry | Object[2] |   NA |    NA |
|  FirstTry | Object[2] |   NA |    NA |
|  FirstTry | Object[2] |   NA |    NA |
| SecondTry | Object[2] |   NA |    NA |
| SecondTry | Object[2] |   NA |    NA |
| SecondTry | Object[2] |   NA |    NA |
| SecondTry | Object[2] |   NA |    NA |
| SecondTry | Object[2] |   NA |    NA |
| SecondTry | Object[2] |   NA |    NA |

Benchmarks with issues:
  PermCheck.FirstTry: DefaultJob [A=Object[2]]
  PermCheck.FirstTry: DefaultJob [A=Object[2]]
  PermCheck.FirstTry: DefaultJob [A=Object[2]]
  PermCheck.FirstTry: DefaultJob [A=Object[2]]
  PermCheck.FirstTry: DefaultJob [A=Object[2]]
  PermCheck.FirstTry: DefaultJob [A=Object[2]]
  PermCheck.SecondTry: DefaultJob [A=Object[2]]
  PermCheck.SecondTry: DefaultJob [A=Object[2]]
  PermCheck.SecondTry: DefaultJob [A=Object[2]]
  PermCheck.SecondTry: DefaultJob [A=Object[2]]
  PermCheck.SecondTry: DefaultJob [A=Object[2]]
  PermCheck.SecondTry: DefaultJob [A=Object[2]]
