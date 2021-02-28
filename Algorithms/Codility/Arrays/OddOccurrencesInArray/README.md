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

**Last update:** Sun Feb 28 15:31:34 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 18.04
Intel Xeon CPU E5-2673 v3 2.40GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|    Method |        A |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--------- |----------:|----------:|----------:|------:|------:|------:|----------:|
|  FirstTry | Int32[7] | 51.472 ns | 0.8489 ns | 0.7941 ns |     - |     - |     - |         - |
| SecondTry | Int32[7] |  5.358 ns | 0.1451 ns | 0.1553 ns |     - |     - |     - |         - |
