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

```
**Last update:** Sun Feb 28 15:29:47 UTC 2021
```
``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 18.04
Intel Xeon CPU E5-2673 v3 2.40GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|    Method |    N |       Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |----- |-----------:|----------:|----------:|-------:|------:|------:|----------:|
|  **FirstTry** |    **1** |  **61.340 ns** | **1.2314 ns** | **1.3687 ns** | **0.0045** |     **-** |     **-** |      **72 B** |
| SecondTry |    1 |   1.435 ns | 0.0562 ns | 0.0525 ns |      - |     - |     - |         - |
|  **FirstTry** |    **2** |  **54.887 ns** | **1.0893 ns** | **0.9656 ns** | **0.0046** |     **-** |     **-** |      **72 B** |
| SecondTry |    2 |   5.107 ns | 0.1439 ns | 0.1768 ns |      - |     - |     - |         - |
|  **FirstTry** |   **15** |  **71.405 ns** | **1.4754 ns** | **2.2084 ns** | **0.0045** |     **-** |     **-** |      **72 B** |
| SecondTry |   15 |   6.199 ns | 0.1256 ns | 0.1175 ns |      - |     - |     - |         - |
|  **FirstTry** |   **32** | **130.815 ns** | **2.6262 ns** | **4.0104 ns** | **0.0081** |     **-** |     **-** |     **128 B** |
| SecondTry |   32 |  11.574 ns | 0.2038 ns | 0.1906 ns |      - |     - |     - |         - |
|  **FirstTry** |  **147** | **142.322 ns** | **2.8616 ns** | **5.0865 ns** | **0.0081** |     **-** |     **-** |     **128 B** |
| SecondTry |  147 |  11.890 ns | 0.2538 ns | 0.2374 ns |      - |     - |     - |         - |
|  **FirstTry** |  **483** | **177.396 ns** | **2.9230 ns** | **2.5912 ns** | **0.0136** |     **-** |     **-** |     **216 B** |
| SecondTry |  483 |  18.138 ns | 0.4058 ns | 0.4983 ns |      - |     - |     - |         - |
|  **FirstTry** |  **647** | **188.524 ns** | **3.0837 ns** | **4.3229 ns** | **0.0136** |     **-** |     **-** |     **216 B** |
| SecondTry |  647 |  15.448 ns | 0.3434 ns | 0.4088 ns |      - |     - |     - |         - |
|  **FirstTry** | **1041** | **199.424 ns** | **3.9849 ns** | **7.1856 ns** | **0.0136** |     **-** |     **-** |     **216 B** |
| SecondTry | 1041 |  15.292 ns | 0.2770 ns | 0.2455 ns |      - |     - |     - |         - |
