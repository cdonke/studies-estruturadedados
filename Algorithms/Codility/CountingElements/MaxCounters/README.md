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

**Last update:** Wed Mar 17 15:15:21 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host]     : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  DefaultJob : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|    Method |     N |            A |         Mean |      Error |     StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|---------- |------ |------------- |-------------:|-----------:|-----------:|-------:|-------:|------:|----------:|
|  **FirstTry** |     **5** | **Int32[10000]** |     **38.51 μs** |   **0.736 μs** |   **0.904 μs** |      **-** |      **-** |     **-** |      **48 B** |
| SecondTry |     5 | Int32[10000] |     38.54 μs |   0.735 μs |   0.755 μs |      - |      - |     - |      48 B |
|  ThirdTry |     5 | Int32[10000] |     27.76 μs |   0.536 μs |   0.550 μs |      - |      - |     - |      48 B |
| FourthTry |     5 | Int32[10000] |     27.95 μs |   0.367 μs |   0.343 μs |      - |      - |     - |      48 B |
|  **FirstTry** | **10000** | **Int32[10000]** |     **19.26 μs** |   **0.378 μs** |   **0.505 μs** | **1.5259** | **0.1831** |     **-** |   **40024 B** |
| SecondTry | 10000 | Int32[10000] |     22.62 μs |   0.385 μs |   0.501 μs | 1.5259 | 0.1831 |     - |   40024 B |
|  ThirdTry | 10000 | Int32[10000] |     40.88 μs |   0.752 μs |   0.704 μs | 1.5259 | 0.1831 |     - |   40024 B |
| FourthTry | 10000 | Int32[10000] |     41.15 μs |   0.818 μs |   1.147 μs | 1.5259 | 0.1831 |     - |   40024 B |
|  **FirstTry** | **10000** |  **Int32[3000]** | **15,169.61 μs** | **166.986 μs** | **148.029 μs** |      **-** |      **-** |     **-** |   **40025 B** |
| SecondTry | 10000 |  Int32[3000] | 15,237.20 μs | 221.597 μs | 207.282 μs |      - |      - |     - |   40175 B |
|  ThirdTry | 10000 |  Int32[3000] |     10.86 μs |   0.216 μs |   0.222 μs | 1.5259 | 0.1831 |     - |   40024 B |
| FourthTry | 10000 |  Int32[3000] |     10.85 μs |   0.136 μs |   0.127 μs | 1.5259 | 0.1831 |     - |   40024 B |
