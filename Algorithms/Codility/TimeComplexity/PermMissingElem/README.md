# Exercise

An array A consisting of N different integers is given. The array contains integers in the range ```[1..(N + 1)]```, 
which means that exactly one element is missing.

Your goal is to find that missing element.

Write a function:

```
class Solution { public int solution(int[] A); }
```

that, given an array A, returns the value of the missing element.

For example, given array A such that:
```
  A[0] = 2
  A[1] = 3
  A[2] = 1
  A[3] = 5
```

the function should return 4, as it is the missing element.

Write an *efficient* algorithm for the following assumptions:

- N is an integer within the range [0..100,000];
- the elements of A are all distinct;
- each element of array A is an integer within the range [1..(N + 1)].

# Results

# Benchmark

**Last update:** Tue May 25 20:02:21 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.409
  [Host] : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|    Method | MissingValue | DataLength |         A | Mean | Error |
|---------- |------------- |----------- |---------- |-----:|------:|
|  **FirstTry** |        **10001** |     **100000** | **Object[1]** |   **NA** |    **NA** |
| SecondTry |        10001 |     100000 | Object[1] |   NA |    NA |
|  ThirdTry |        10001 |     100000 | Object[1] |   NA |    NA |
|  **FirstTry** |        **12345** |     **100000** | **Object[1]** |   **NA** |    **NA** |
| SecondTry |        12345 |     100000 | Object[1] |   NA |    NA |
|  ThirdTry |        12345 |     100000 | Object[1] |   NA |    NA |

Benchmarks with issues:
  PermMissingElem.FirstTry: DefaultJob [MissingValue=10001, DataLength=100000, A=Object[1]]
  PermMissingElem.SecondTry: DefaultJob [MissingValue=10001, DataLength=100000, A=Object[1]]
  PermMissingElem.ThirdTry: DefaultJob [MissingValue=10001, DataLength=100000, A=Object[1]]
  PermMissingElem.FirstTry: DefaultJob [MissingValue=12345, DataLength=100000, A=Object[1]]
  PermMissingElem.SecondTry: DefaultJob [MissingValue=12345, DataLength=100000, A=Object[1]]
  PermMissingElem.ThirdTry: DefaultJob [MissingValue=12345, DataLength=100000, A=Object[1]]
