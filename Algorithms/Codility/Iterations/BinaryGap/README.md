# Exercise


A _binary gap_ within a positive integer N is any maximal sequence of consecutive zeros that is surrounded by ones at both ends in the binary representation of N.

For example, number 9 has binary representation 1001 and contains a binary gap of length 2. The number 529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3. The number 20 has binary representation 10100 and contains one binary gap of length 1. The number 15 has binary representation 1111 and has no binary gaps. The number 32 has binary representation 100000 and has no binary gaps.

Write a function:

```
class Solution { public int solution(int N); }
```

that, given a positive integer N, returns the length of its longest binary gap. The function should return 0 if N doesn't contain a binary gap.

For example, given N = 1041 the function should return 5, because N has binary representation 10000010001 and so its longest binary gap is of length 5. Given N = 32 the function should return 0, because N has binary representation '100000' and thus no binary gaps.

Write an efficient algorithm for the following assumptions:

- N is an integer within the range [1..2,147,483,647].

# Results
https://app.codility.com/demo/results/trainingDVVF6N-MKK/

# Benchmark

**Last update:** Wed Mar 17 15:15:21 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host]     : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  DefaultJob : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|    Method |    N |        Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |----- |------------:|----------:|----------:|-------:|------:|------:|----------:|
|  **FirstTry** |    **1** |  **42.4466 ns** | **0.7215 ns** | **0.6396 ns** | **0.0027** |     **-** |     **-** |      **72 B** |
| SecondTry |    1 |   0.9763 ns | 0.0432 ns | 0.0383 ns |      - |     - |     - |         - |
|  **FirstTry** |    **2** |  **48.9953 ns** | **0.9899 ns** | **0.9259 ns** | **0.0027** |     **-** |     **-** |      **72 B** |
| SecondTry |    2 |   2.9139 ns | 0.0801 ns | 0.0749 ns |      - |     - |     - |         - |
|  **FirstTry** |   **15** |  **64.6827 ns** | **1.2916 ns** | **1.8107 ns** | **0.0027** |     **-** |     **-** |      **72 B** |
| SecondTry |   15 |   5.9381 ns | 0.1328 ns | 0.1242 ns |      - |     - |     - |         - |
|  **FirstTry** |   **32** | **104.3030 ns** | **2.0654 ns** | **1.9320 ns** | **0.0049** |     **-** |     **-** |     **128 B** |
| SecondTry |   32 |  12.5423 ns | 0.1588 ns | 0.1485 ns |      - |     - |     - |         - |
|  **FirstTry** |  **147** | **120.1853 ns** | **2.2361 ns** | **3.2777 ns** | **0.0048** |     **-** |     **-** |     **128 B** |
| SecondTry |  147 |  14.8126 ns | 0.2784 ns | 0.2604 ns |      - |     - |     - |         - |
|  **FirstTry** |  **483** | **158.2907 ns** | **1.9079 ns** | **1.6913 ns** | **0.0081** |     **-** |     **-** |     **216 B** |
| SecondTry |  483 |  13.2881 ns | 0.2422 ns | 0.2266 ns |      - |     - |     - |         - |
|  **FirstTry** |  **647** | **163.6959 ns** | **3.2590 ns** | **3.0485 ns** | **0.0081** |     **-** |     **-** |     **216 B** |
| SecondTry |  647 |  15.0123 ns | 0.2753 ns | 0.2440 ns |      - |     - |     - |         - |
|  **FirstTry** | **1041** | **164.9029 ns** | **2.6816 ns** | **2.3772 ns** | **0.0081** |     **-** |     **-** |     **216 B** |
| SecondTry | 1041 |  14.1534 ns | 0.2880 ns | 0.2828 ns |      - |     - |     - |         - |
