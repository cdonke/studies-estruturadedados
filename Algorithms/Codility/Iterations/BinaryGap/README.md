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
|    Method |    N |       Mean |      Error |     StdDev |     Median |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |----- |-----------:|-----------:|-----------:|-----------:|-------:|------:|------:|----------:|
|  FirstTry |    1 |  47.894 ns |  1.0784 ns |  3.1798 ns |  48.084 ns | 0.0172 |     - |     - |      72 B |
| SecondTry |    1 |   1.083 ns |  0.0638 ns |  0.0533 ns |   1.079 ns |      - |     - |     - |         - |
|  FirstTry |    2 |  59.144 ns |  3.1159 ns |  9.1383 ns |  56.020 ns | 0.0172 |     - |     - |      72 B |
| SecondTry |    2 |   3.808 ns |  0.2147 ns |  0.6057 ns |   3.730 ns |      - |     - |     - |         - |
|  FirstTry |   15 |  77.908 ns |  3.2594 ns |  9.3518 ns |  75.513 ns | 0.0172 |     - |     - |      72 B |
| SecondTry |   15 |   7.834 ns |  0.3992 ns |  1.1453 ns |   7.670 ns |      - |     - |     - |         - |
|  FirstTry |   32 | 128.742 ns |  6.7851 ns | 19.1376 ns | 125.208 ns | 0.0305 |     - |     - |     128 B |
| SecondTry |   32 |   9.203 ns |  0.2107 ns |  0.2953 ns |   9.138 ns |      - |     - |     - |         - |
|  FirstTry |  147 | 126.808 ns |  2.5103 ns |  5.8678 ns | 124.574 ns | 0.0305 |     - |     - |     128 B |
| SecondTry |  147 |  11.472 ns |  0.2737 ns |  0.5467 ns |  11.480 ns |      - |     - |     - |         - |
|  FirstTry |  483 | 170.440 ns |  3.3974 ns |  6.8629 ns | 170.217 ns | 0.0515 |     - |     - |     216 B |
| SecondTry |  483 |  15.149 ns |  0.8294 ns |  2.3930 ns |  14.372 ns |      - |     - |     - |         - |
|  FirstTry |  647 | 207.919 ns | 11.2371 ns | 32.4215 ns | 203.372 ns | 0.0515 |     - |     - |     216 B |
| SecondTry |  647 |  15.541 ns |  0.8432 ns |  2.4192 ns |  14.899 ns |      - |     - |     - |         - |
|  FirstTry | 1041 | 211.884 ns | 11.0953 ns | 32.5405 ns | 207.393 ns | 0.0515 |     - |     - |     216 B |
| SecondTry | 1041 |  14.133 ns |  0.7641 ns |  2.1676 ns |  13.460 ns |      - |     - |     - |         - |