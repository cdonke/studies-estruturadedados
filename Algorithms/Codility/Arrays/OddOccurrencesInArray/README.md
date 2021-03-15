# Exercise

A non-empty array A consisting of N integers is given. The array contains an odd number of elements, and each element of the array can be paired with another element that has the same value, except for one element that is left unpaired.

For example, in array A such that:
```
  A[0] = 9  A[1] = 3  A[2] = 9
  A[3] = 3  A[4] = 9  A[5] = 7
  A[6] = 9
```
- the elements at indexes 0 and 2 have value 9,
- the elements at indexes 1 and 3 have value 3,
- the elements at indexes 4 and 6 have value 9,
- the element at index 5 has value 7 and is unpaired.
Write a function:

```
class Solution { public int solution(int[] A); }
```

that, given an array A consisting of N integers fulfilling the above conditions, returns the value of the unpaired element.

For example, given array A such that:
```
  A[0] = 9  A[1] = 3  A[2] = 9
  A[3] = 3  A[4] = 9  A[5] = 7
  A[6] = 9
```

the function should return 7, as explained in the example above.

Write an *efficient* algorithm for the following assumptions:

- N is an odd integer within the range `[1..1,000,000]`;
- each element of array A is an integer within the range `[1..1,000,000,000]`;
- all but one of the values in A occur an even number of times.


# Results

[First Try](https://app.codility.com/demo/results/trainingE3Z4QK-AZR/)

[Second Try](https://app.codility.com/demo/results/training52RJXP-AB2/)

# Benchmark

**Last update:** Mon Mar 15 19:23:41 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host] : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|    Method |        A | Mean | Error |
|---------- |--------- |-----:|------:|
|  FirstTry | Int32[7] |   NA |    NA |
| SecondTry | Int32[7] |   NA |    NA |

Benchmarks with issues:
  OddOccurrencesInArray.FirstTry: DefaultJob [A=Int32[7]]
  OddOccurrencesInArray.SecondTry: DefaultJob [A=Int32[7]]
