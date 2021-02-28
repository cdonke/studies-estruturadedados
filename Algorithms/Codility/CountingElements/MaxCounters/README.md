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

**Last update:** Sun Feb 28 15:31:34 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 18.04
Intel Xeon CPU E5-2673 v3 2.40GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|    Method |     N |            A |         Mean |      Error |     StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|---------- |------ |------------- |-------------:|-----------:|-----------:|-------:|-------:|------:|----------:|
|  **FirstTry** |     **5** | **Int32[10000]** |     **44.00 μs** |   **0.769 μs** |   **0.755 μs** |      **-** |      **-** |     **-** |      **48 B** |
| SecondTry |     5 | Int32[10000] |     43.28 μs |   0.620 μs |   0.580 μs |      - |      - |     - |      48 B |
|  ThirdTry |     5 | Int32[10000] |     31.55 μs |   0.579 μs |   0.541 μs |      - |      - |     - |      49 B |
| FourthTry |     5 | Int32[10000] |     31.67 μs |   0.594 μs |   0.636 μs |      - |      - |     - |      48 B |
|  **FirstTry** | **10000** | **Int32[10000]** |     **22.56 μs** |   **0.432 μs** |   **0.424 μs** | **2.5330** | **0.3052** |     **-** |   **40024 B** |
| SecondTry | 10000 | Int32[10000] |     25.68 μs |   0.512 μs |   0.479 μs | 2.5330 | 0.3052 |     - |   40024 B |
|  ThirdTry | 10000 | Int32[10000] |     47.07 μs |   0.916 μs |   1.454 μs | 2.5024 | 0.3052 |     - |   40024 B |
| FourthTry | 10000 | Int32[10000] |     47.52 μs |   0.946 μs |   1.327 μs | 2.5024 | 0.3052 |     - |   40024 B |
|  **FirstTry** | **10000** |  **Int32[3000]** | **21,913.30 μs** | **363.777 μs** | **340.278 μs** |      **-** |      **-** |     **-** |   **40330 B** |
| SecondTry | 10000 |  Int32[3000] | 21,944.09 μs | 427.355 μs | 399.748 μs |      - |      - |     - |   40044 B |
|  ThirdTry | 10000 |  Int32[3000] |     12.03 μs |   0.239 μs |   0.294 μs | 2.5330 | 0.3052 |     - |   40024 B |
| FourthTry | 10000 |  Int32[3000] |     11.95 μs |   0.236 μs |   0.299 μs | 2.5330 | 0.3052 |     - |   40024 B |
