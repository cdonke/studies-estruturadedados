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

**Last update:** Mon Mar  8 13:09:01 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|    Method |    N |       Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |----- |-----------:|----------:|----------:|-------:|------:|------:|----------:|
|  **FirstTry** |    **1** |  **57.329 ns** | **0.5945 ns** | **0.5270 ns** | **0.0038** |     **-** |     **-** |      **72 B** |
| SecondTry |    1 |   1.262 ns | 0.0383 ns | 0.0340 ns |      - |     - |     - |         - |
|  **FirstTry** |    **2** |  **65.724 ns** | **0.8377 ns** | **0.7836 ns** | **0.0038** |     **-** |     **-** |      **72 B** |
| SecondTry |    2 |   3.869 ns | 0.0772 ns | 0.0722 ns |      - |     - |     - |         - |
|  **FirstTry** |   **15** |  **84.578 ns** | **0.8197 ns** | **0.7266 ns** | **0.0038** |     **-** |     **-** |      **72 B** |
| SecondTry |   15 |   7.136 ns | 0.0598 ns | 0.0531 ns |      - |     - |     - |         - |
|  **FirstTry** |   **32** | **138.754 ns** | **1.8432 ns** | **1.7242 ns** | **0.0067** |     **-** |     **-** |     **128 B** |
| SecondTry |   32 |   9.570 ns | 0.1525 ns | 0.1426 ns |      - |     - |     - |         - |
|  **FirstTry** |  **147** | **158.674 ns** | **1.3066 ns** | **1.2222 ns** | **0.0067** |     **-** |     **-** |     **128 B** |
| SecondTry |  147 |  14.367 ns | 0.1102 ns | 0.0921 ns |      - |     - |     - |         - |
|  **FirstTry** |  **483** | **213.155 ns** | **3.2446 ns** | **3.0350 ns** | **0.0114** |     **-** |     **-** |     **216 B** |
| SecondTry |  483 |  16.250 ns | 0.2041 ns | 0.1910 ns |      - |     - |     - |         - |
|  **FirstTry** |  **647** | **218.726 ns** | **3.0806 ns** | **2.8816 ns** | **0.0114** |     **-** |     **-** |     **216 B** |
| SecondTry |  647 |  18.035 ns | 0.0770 ns | 0.0720 ns |      - |     - |     - |         - |
|  **FirstTry** | **1041** | **228.485 ns** | **1.6605 ns** | **1.5532 ns** | **0.0114** |     **-** |     **-** |     **216 B** |
| SecondTry | 1041 |  17.788 ns | 0.2217 ns | 0.2074 ns |      - |     - |     - |         - |
