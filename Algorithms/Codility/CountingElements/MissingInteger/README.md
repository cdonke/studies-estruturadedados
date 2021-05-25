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

**Last update:** Tue May 25 20:02:21 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.409
  [Host] : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|    Method |              A | missingInteger | Mean | Error |
|---------- |--------------- |--------------- |-----:|------:|
|  **FirstTry** |    **Int32[1187]** |              **1** |   **NA** |    **NA** |
| **SecondTry** |    **Int32[1252]** |              **1** |   **NA** |    **NA** |
| **SecondTry** |     **Int32[129]** |              **1** |   **NA** |    **NA** |
| **SecondTry** |     **Int32[142]** |              **1** |   **NA** |    **NA** |
|  **FirstTry** |     **Int32[188]** |              **1** |   **NA** |    **NA** |
|  FirstTry |     Int32[188] |              1 |   NA |    NA |
| **SecondTry** |     **Int32[430]** |              **1** |   **NA** |    **NA** |
|  **FirstTry** |  **Int32[502228]** |              **1** |   **NA** |    **NA** |
|  **FirstTry** |     **Int32[638]** |              **1** |   **NA** |    **NA** |
|  **FirstTry** |    **Int32[6865]** |              **1** |   **NA** |    **NA** |
| **SecondTry** |    **Int32[6890]** |              **1** |   **NA** |    **NA** |
| **SecondTry** | **Int32[1090240]** |         **507314** |   **NA** |    **NA** |

Benchmarks with issues:
  MissingInteger.FirstTry: DefaultJob [A=Int32[1187], missingInteger=1]
  MissingInteger.SecondTry: DefaultJob [A=Int32[1252], missingInteger=1]
  MissingInteger.SecondTry: DefaultJob [A=Int32[129], missingInteger=1]
  MissingInteger.SecondTry: DefaultJob [A=Int32[142], missingInteger=1]
  MissingInteger.FirstTry: DefaultJob [A=Int32[188], missingInteger=1]
  MissingInteger.FirstTry: DefaultJob [A=Int32[188], missingInteger=1]
  MissingInteger.SecondTry: DefaultJob [A=Int32[430], missingInteger=1]
  MissingInteger.FirstTry: DefaultJob [A=Int32[502228], missingInteger=1]
  MissingInteger.FirstTry: DefaultJob [A=Int32[638], missingInteger=1]
  MissingInteger.FirstTry: DefaultJob [A=Int32[6865], missingInteger=1]
  MissingInteger.SecondTry: DefaultJob [A=Int32[6890], missingInteger=1]
  MissingInteger.SecondTry: DefaultJob [A=Int32[1090240], missingInteger=507314]
