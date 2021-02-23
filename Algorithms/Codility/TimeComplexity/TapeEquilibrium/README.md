﻿# Exercise

A non-empty array A consisting of N integers is given. Array A represents numbers on a tape.

Any integer P, such that 0 < P < N, splits this tape into two non-empty parts: `A[0], A[1], ..., A[P − 1]` and `A[P], A[P + 1], ..., A[N − 1]`.

The difference between the two parts is the value of: `|(A[0] + A[1] + ... + A[P − 1]) − (A[P] + A[P + 1] + ... + A[N − 1])|`

In other words, it is the absolute difference between the sum of the first part and the sum of the second part.

For example, consider array A such that:
```
  A[0] = 3
  A[1] = 1
  A[2] = 2
  A[3] = 4
  A[4] = 3
```

We can split this tape in four places:

```
P = 1, difference = |3 − 10| = 7
P = 2, difference = |4 − 9| = 5
P = 3, difference = |6 − 7| = 1
P = 4, difference = |10 − 3| = 7
```

Write a function:

```
class Solution { public int solution(int[] A); }
```

that, given a non-empty array A of N integers, returns the minimal difference that can be achieved.

For example, given:
```
  A[0] = 3
  A[1] = 1
  A[2] = 2
  A[3] = 4
  A[4] = 3
```

the function should return 1, as explained above.

Write an efficient algorithm for the following assumptions:

- N is an integer within the range [2..100,000];
- each element of array A is an integer within the range [−1,000..1,000].

# Results
- [First Try](https://app.codility.com/demo/results/trainingNXSD2K-KQW/)
- [Second Try](https://app.codility.com/demo/results/trainingRRN428-VGA/)


# Benchmark
|               Method |        A |      Mean |     Error |    StdDev |    Median | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |----------:|----------:|----------:|----------:|------:|------:|------:|----------:|
|             FirstTry | Int32[5] |  9.220 ns | 0.4279 ns | 1.2483 ns |  9.126 ns |     - |     - |     - |         - |
|  FirstTry_BitwiseAbs | Int32[5] | 12.008 ns | 1.5484 ns | 4.5167 ns | 10.121 ns |     - |     - |     - |         - |
|            SecondTry | Int32[5] | 12.319 ns | 0.3858 ns | 1.0689 ns | 11.886 ns |     - |     - |     - |         - |
| SecondTry_BitwiseAbs | Int32[5] |  7.066 ns | 0.1901 ns | 0.2335 ns |  7.091 ns |     - |     - |     - |         - |