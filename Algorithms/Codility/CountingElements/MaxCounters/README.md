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

**Last update:** Tue May 25 19:55:36 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.409
  [Host] : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|    Method |     N |            A | Mean | Error |
|---------- |------ |------------- |-----:|------:|
|  **FirstTry** |     **5** | **Int32[10000]** |   **NA** |    **NA** |
| SecondTry |     5 | Int32[10000] |   NA |    NA |
|  ThirdTry |     5 | Int32[10000] |   NA |    NA |
| FourthTry |     5 | Int32[10000] |   NA |    NA |
|  **FirstTry** | **10000** | **Int32[10000]** |   **NA** |    **NA** |
| SecondTry | 10000 | Int32[10000] |   NA |    NA |
|  ThirdTry | 10000 | Int32[10000] |   NA |    NA |
| FourthTry | 10000 | Int32[10000] |   NA |    NA |
|  **FirstTry** | **10000** |  **Int32[3000]** |   **NA** |    **NA** |
| SecondTry | 10000 |  Int32[3000] |   NA |    NA |
|  ThirdTry | 10000 |  Int32[3000] |   NA |    NA |
| FourthTry | 10000 |  Int32[3000] |   NA |    NA |

Benchmarks with issues:
  MaxCounters.FirstTry: DefaultJob [N=5, A=Int32[10000]]
  MaxCounters.SecondTry: DefaultJob [N=5, A=Int32[10000]]
  MaxCounters.ThirdTry: DefaultJob [N=5, A=Int32[10000]]
  MaxCounters.FourthTry: DefaultJob [N=5, A=Int32[10000]]
  MaxCounters.FirstTry: DefaultJob [N=10000, A=Int32[10000]]
  MaxCounters.SecondTry: DefaultJob [N=10000, A=Int32[10000]]
  MaxCounters.ThirdTry: DefaultJob [N=10000, A=Int32[10000]]
  MaxCounters.FourthTry: DefaultJob [N=10000, A=Int32[10000]]
  MaxCounters.FirstTry: DefaultJob [N=10000, A=Int32[3000]]
  MaxCounters.SecondTry: DefaultJob [N=10000, A=Int32[3000]]
  MaxCounters.ThirdTry: DefaultJob [N=10000, A=Int32[3000]]
  MaxCounters.FourthTry: DefaultJob [N=10000, A=Int32[3000]]
