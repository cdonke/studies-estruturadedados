# Exercise
You are given N counters, initially set to 0, and you have two possible operations on them:

- _increase(X)_ − counter X is increased by 1,
- _max counter_ − all counters are set to the maximum value of any counter.

A non-empty array A of M integers is given. This array represents consecutive operations:

- if A[K] = X, such that 1 ≤ X ≤ N, then operation K is increase(X),
- if A[K] = N + 1 then operation K is max counter.

For example, given integer N = 5 and array A such that:
```
    A[0] = 3
    A[1] = 4
    A[2] = 4
    A[3] = 6
    A[4] = 1
    A[5] = 4
    A[6] = 4
```

the values of the counters after each consecutive operation will be:
```
    (0, 0, 1, 0, 0)
    (0, 0, 1, 1, 0)
    (0, 0, 1, 2, 0)
    (2, 2, 2, 2, 2)
    (3, 2, 2, 2, 2)
    (3, 2, 2, 3, 2)
    (3, 2, 2, 4, 2)
```

The goal is to calculate the value of every counter after all operations.

Write a function:

```
class Solution { public int[] solution(int N, int[] A); }
```

that, given an integer N and a non-empty array A consisting of M integers, returns a sequence of integers representing the values of the counters.

Result array should be returned as an array of integers.

For example, given:
```
    A[0] = 3
    A[1] = 4
    A[2] = 4
    A[3] = 6
    A[4] = 1
    A[5] = 4
    A[6] = 4
```

the function should return [3, 2, 2, 4, 2], as explained above.

Write an efficient algorithm for the following assumptions:

- N and M are integers within the range `[1..100,000]`;
- each element of array A is an integer within the range `[1..N + 1]`.


# Results
- [First try](https://app.codility.com/demo/results/trainingMXXMRX-K2R/)
- [Second try](https://app.codility.com/demo/results/trainingX8YE26-PC2/)
-
- [Fourth try](https://app.codility.com/demo/results/training6N86XV-7TU/)

# Benchmark

**Last update:** Mon Mar  8 13:09:01 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|    Method |     N |            A |         Mean |      Error |     StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|---------- |------ |------------- |-------------:|-----------:|-----------:|-------:|-------:|------:|----------:|
|  **FirstTry** |     **5** | **Int32[10000]** |     **52.90 μs** |   **0.860 μs** |   **0.804 μs** |      **-** |      **-** |     **-** |      **49 B** |
| SecondTry |     5 | Int32[10000] |     51.07 μs |   0.964 μs |   0.990 μs |      - |      - |     - |      48 B |
|  ThirdTry |     5 | Int32[10000] |     37.39 μs |   0.718 μs |   0.827 μs |      - |      - |     - |      48 B |
| FourthTry |     5 | Int32[10000] |     37.46 μs |   0.327 μs |   0.273 μs |      - |      - |     - |      48 B |
|  **FirstTry** | **10000** | **Int32[10000]** |     **32.02 μs** |   **0.385 μs** |   **0.360 μs** | **2.0752** | **0.2441** |     **-** |   **40024 B** |
| SecondTry | 10000 | Int32[10000] |     33.59 μs |   0.372 μs |   0.348 μs | 2.0752 | 0.2441 |     - |   40025 B |
|  ThirdTry | 10000 | Int32[10000] |     61.18 μs |   0.814 μs |   0.762 μs | 2.0752 | 0.2441 |     - |   40024 B |
| FourthTry | 10000 | Int32[10000] |     61.64 μs |   0.511 μs |   0.453 μs | 2.0752 | 0.2441 |     - |   40025 B |
|  **FirstTry** | **10000** |  **Int32[3000]** | **24,112.83 μs** | **292.423 μs** | **273.533 μs** |      **-** |      **-** |     **-** |   **40026 B** |
| SecondTry | 10000 |  Int32[3000] | 20,737.02 μs | 317.140 μs | 281.136 μs |      - |      - |     - |   40298 B |
|  ThirdTry | 10000 |  Int32[3000] |     16.38 μs |   0.325 μs |   0.423 μs | 2.1057 | 0.2441 |     - |   40024 B |
| FourthTry | 10000 |  Int32[3000] |     22.50 μs |   0.186 μs |   0.174 μs | 2.1057 | 0.2441 |     - |   40024 B |
