# Exercise
Write a function:

```
class Solution { public int solution(int[] A); }
```

that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.

For example, given `A = [1, 3, 6, 4, 1, 2]`, the function should return 5.

Given `A = [1, 2, 3]`, the function should return 4.

Given `A = [−1, −3]`, the function should return 1.

Write an *efficient* algorithm for the following assumptions:

- N is an integer within the range [1..100,000];
- each element of array A is an integer within the range [−1,000,000..1,000,000].


# Results
- (First try)[https://app.codility.com/demo/results/trainingNA9QK3-5U4/]
- (First try)[https://app.codility.com/demo/results/training8J97CZ-U34/]
- (First try)[]

# Benchmark

**Last update:** Mon Mar 15 19:23:41 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host] : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


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
  MissingInteger.FirstTry: DefaultJob [A=Object[2]]
  MissingInteger.FirstTry: DefaultJob [A=Object[2]]
  MissingInteger.FirstTry: DefaultJob [A=Object[2]]
  MissingInteger.FirstTry: DefaultJob [A=Object[2]]
  MissingInteger.FirstTry: DefaultJob [A=Object[2]]
  MissingInteger.FirstTry: DefaultJob [A=Object[2]]
  MissingInteger.SecondTry: DefaultJob [A=Object[2]]
  MissingInteger.SecondTry: DefaultJob [A=Object[2]]
  MissingInteger.SecondTry: DefaultJob [A=Object[2]]
  MissingInteger.SecondTry: DefaultJob [A=Object[2]]
  MissingInteger.SecondTry: DefaultJob [A=Object[2]]
  MissingInteger.SecondTry: DefaultJob [A=Object[2]]
