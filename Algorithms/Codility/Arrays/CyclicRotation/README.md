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

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 18.04
Intel Xeon CPU E5-2673 v3 2.40GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|    Method |        A | K |     Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--------- |-- |---------:|---------:|---------:|-------:|------:|------:|----------:|
|  **FirstTry** | **Int32[3]** | **1** | **21.60 ns** | **0.495 ns** | **0.570 ns** | **0.0025** |     **-** |     **-** |      **40 B** |
| SecondTry | Int32[3] | 1 | 21.12 ns | 0.481 ns | 0.573 ns | 0.0025 |     - |     - |      40 B |
|  **FirstTry** | **Int32[5]** | **3** | **29.47 ns** | **0.687 ns** | **0.869 ns** | **0.0030** |     **-** |     **-** |      **48 B** |
| SecondTry | Int32[5] | 3 | 29.46 ns | 0.634 ns | 0.930 ns | 0.0030 |     - |     - |      48 B |
|  **FirstTry** | **Int32[4]** | **4** | **25.10 ns** | **0.508 ns** | **0.475 ns** | **0.0025** |     **-** |     **-** |      **40 B** |
| SecondTry | Int32[4] | 4 | 25.14 ns | 0.607 ns | 0.890 ns | 0.0025 |     - |     - |      40 B |
