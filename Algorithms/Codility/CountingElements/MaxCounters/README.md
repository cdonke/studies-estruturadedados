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
|    Method |     N |            A |         Mean |      Error |     StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|---------- |------ |------------- |-------------:|-----------:|-----------:|-------:|-------:|------:|----------:|
|  FirstTry |     5 | Int32[10000] |     54.32 us |   1.085 us |   2.242 us |      - |      - |     - |      48 B |
| SecondTry |     5 | Int32[10000] |     48.92 us |   0.855 us |   1.170 us |      - |      - |     - |      48 B |
|  ThirdTry |     5 | Int32[10000] |     55.33 us |   2.817 us |   8.306 us |      - |      - |     - |      48 B |
| FourthTry |     5 | Int32[10000] |     53.22 us |   2.553 us |   7.243 us |      - |      - |     - |      48 B |
|  FirstTry | 10000 | Int32[10000] |     28.62 us |   1.335 us |   3.936 us | 9.5215 | 0.0610 |     - |   40024 B |
| SecondTry | 10000 | Int32[10000] |     33.17 us |   1.214 us |   3.561 us | 9.5215 | 0.0610 |     - |   40024 B |
|  ThirdTry | 10000 | Int32[10000] |     77.87 us |   2.825 us |   8.284 us | 9.5215 | 0.1221 |     - |   40024 B |
| FourthTry | 10000 | Int32[10000] |     69.31 us |   1.524 us |   4.273 us | 9.5215 | 0.1221 |     - |   40024 B |
|  FirstTry | 10000 |  Int32[3000] | 20,532.25 us | 409.688 us | 799.064 us |      - |      - |     - |   40024 B |
| SecondTry | 10000 |  Int32[3000] | 25,837.09 us | 508.230 us | 499.150 us |      - |      - |     - |   40024 B |
|  ThirdTry | 10000 |  Int32[3000] |     14.76 us |   0.294 us |   0.711 us | 9.5215 | 0.0305 |     - |   40024 B |
| FourthTry | 10000 |  Int32[3000] |     21.17 us |   0.422 us |   1.010 us | 9.5215 | 0.0305 |     - |   40024 B |