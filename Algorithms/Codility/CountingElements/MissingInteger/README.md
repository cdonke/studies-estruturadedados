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

**Last update:** Wed Mar 17 15:15:21 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host]     : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  DefaultJob : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|    Method |             A | missingInteger |            Mean |         Error |        StdDev |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
|---------- |-------------- |--------------- |----------------:|--------------:|--------------:|---------:|---------:|---------:|----------:|
|  **FirstTry** |    **Int32[127]** |              **1** |     **57,299.4 ns** |   **1,143.07 ns** |   **2,146.95 ns** | **249.8779** | **249.8779** | **249.8779** | **1000024 B** |
|  **FirstTry** |   **Int32[1424]** |              **1** |     **62,457.4 ns** |   **1,227.18 ns** |   **2,016.29 ns** | **249.8779** | **249.8779** | **249.8779** | **1000024 B** |
|  **FirstTry** |    **Int32[263]** |              **1** |     **57,127.7 ns** |   **1,069.41 ns** |   **1,726.89 ns** | **249.9390** | **249.9390** | **249.9390** | **1000024 B** |
| **SecondTry** |    **Int32[519]** |              **1** |      **3,425.4 ns** |      **63.70 ns** |      **65.41 ns** |        **-** |        **-** |        **-** |         **-** |
|  **FirstTry** |   **Int32[5265]** |              **1** |     **68,178.4 ns** |   **1,362.97 ns** |   **2,351.05 ns** | **249.8779** | **249.8779** | **249.8779** | **1000024 B** |
| **SecondTry** |    **Int32[569]** |              **1** |      **4,332.1 ns** |      **49.90 ns** |      **46.68 ns** |        **-** |        **-** |        **-** |         **-** |
| **SecondTry** |   **Int32[5981]** |              **1** |     **81,216.9 ns** |   **1,479.08 ns** |   **1,383.54 ns** |        **-** |        **-** |        **-** |         **-** |
| **SecondTry** |    **Int32[601]** |              **1** |        **818.1 ns** |      **16.06 ns** |      **15.77 ns** |        **-** |        **-** |        **-** |         **-** |
|  **FirstTry** |    **Int32[630]** |              **1** |     **55,144.6 ns** |   **1,092.59 ns** |   **2,231.88 ns** | **249.9390** | **249.9390** | **249.9390** | **1000024 B** |
| **SecondTry** |    **Int32[828]** |              **1** |      **7,077.6 ns** |      **70.62 ns** |      **66.05 ns** |        **-** |        **-** |        **-** |         **-** |
| **SecondTry** | **Int32[997086]** |          **78747** | **18,425,577.1 ns** | **365,934.73 ns** | **359,396.84 ns** |        **-** |        **-** |        **-** |         **-** |
|  **FirstTry** | **Int32[764448]** |          **83841** |  **5,288,532.4 ns** | **101,159.45 ns** |  **89,675.21 ns** | **140.6250** | **140.6250** | **140.6250** | **1000026 B** |
