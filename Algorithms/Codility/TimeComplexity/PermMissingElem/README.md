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

**Last update:** Mon Mar  8 13:09:01 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|    Method | MissingValue | DataLength |        A |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |------------- |----------- |--------- |----------:|----------:|----------:|------:|------:|------:|----------:|
|  **FirstTry** |        **10001** |     **100000** | **Int32[0]** | **0.7139 ns** | **0.0305 ns** | **0.0286 ns** |     **-** |     **-** |     **-** |         **-** |
| SecondTry |        10001 |     100000 | Int32[0] | 0.7675 ns | 0.0182 ns | 0.0161 ns |     - |     - |     - |         - |
|  ThirdTry |        10001 |     100000 | Int32[0] | 1.6339 ns | 0.0263 ns | 0.0246 ns |     - |     - |     - |         - |
|  **FirstTry** |        **12345** |     **100000** | **Int32[0]** | **0.7355 ns** | **0.0108 ns** | **0.0101 ns** |     **-** |     **-** |     **-** |         **-** |
| SecondTry |        12345 |     100000 | Int32[0] | 1.7365 ns | 0.0417 ns | 0.0390 ns |     - |     - |     - |         - |
|  ThirdTry |        12345 |     100000 | Int32[0] | 0.7863 ns | 0.0218 ns | 0.0204 ns |     - |     - |     - |         - |
