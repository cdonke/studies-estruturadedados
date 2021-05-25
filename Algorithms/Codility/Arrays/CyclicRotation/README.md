# Exercise

An array A consisting of N integers is given. Rotation of the array means that each element is shifted right by one index, 
and the last element of the array is moved to the first place. For example, the rotation of array 
```A = [3, 8, 9, 7, 6]``` is ```[6, 3, 8, 9, 7]``` (elements are shifted right by one index and 6 is moved to the first place).

The goal is to rotate array A K times; that is, each element of A will be shifted to the right K times.

Write a function:

```
class Solution { public int[] solution(int[] A, int K); }
```


that, given an array A consisting of N integers and an integer K, returns the array A rotated K times.

For example, given
``` 
    A = [3, 8, 9, 7, 6]
    K = 3
```
the function should return ```[9, 7, 6, 3, 8]```. Three rotations were made:

```
    [3, 8, 9, 7, 6] -> [6, 3, 8, 9, 7]
    [6, 3, 8, 9, 7] -> [7, 6, 3, 8, 9]
    [7, 6, 3, 8, 9] -> [9, 7, 6, 3, 8]
```

For another example, given
```
    A = [0, 0, 0]
    K = 1
```
the function should return ```[0, 0, 0]```

Given
```
    A = [1, 2, 3, 4]
    K = 4
```
the function should return ```[1, 2, 3, 4]```

Assume that:

- N and K are integers within the range ```[0..100]```;
- each element of array A is an integer within the range ```[−1,000..1,000]```.
- In your solution, focus on correctness. The performance of your solution will not be the focus of the assessment.

# Benchmark

**Last update:** Tue May 25 20:02:21 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.409
  [Host] : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|    Method |        A | K | Mean | Error |
|---------- |--------- |-- |-----:|------:|
|  **FirstTry** | **Int32[3]** | **1** |   **NA** |    **NA** |
| SecondTry | Int32[3] | 1 |   NA |    NA |
|  **FirstTry** | **Int32[5]** | **3** |   **NA** |    **NA** |
| SecondTry | Int32[5] | 3 |   NA |    NA |
|  **FirstTry** | **Int32[4]** | **4** |   **NA** |    **NA** |
| SecondTry | Int32[4] | 4 |   NA |    NA |

Benchmarks with issues:
  CyclicRotation.FirstTry: DefaultJob [A=Int32[3], K=1]
  CyclicRotation.SecondTry: DefaultJob [A=Int32[3], K=1]
  CyclicRotation.FirstTry: DefaultJob [A=Int32[5], K=3]
  CyclicRotation.SecondTry: DefaultJob [A=Int32[5], K=3]
  CyclicRotation.FirstTry: DefaultJob [A=Int32[4], K=4]
  CyclicRotation.SecondTry: DefaultJob [A=Int32[4], K=4]
