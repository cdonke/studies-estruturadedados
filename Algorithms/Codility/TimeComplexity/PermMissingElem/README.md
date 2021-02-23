# Exercise

An array A consisting of N different integers is given. The array contains integers in the range ```[1..(N + 1)]```, 
which means that exactly one element is missing.

Your goal is to find that missing element.

Write a function:

```
class Solution { public int solution(int[] A); }
```

that, given an array A, returns the value of the missing element.

For example, given array A such that:
```
  A[0] = 2
  A[1] = 3
  A[2] = 1
  A[3] = 5
```

the function should return 4, as it is the missing element.

Write an *efficient* algorithm for the following assumptions:

N is an integer within the range [0..100,000];
the elements of A are all distinct;
each element of array A is an integer within the range [1..(N + 1)].

# Results

# Benchmark
|    Method | MissingValue | DataLength |        A |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |------------- |----------- |--------- |----------:|----------:|----------:|------:|------:|------:|----------:|
|  FirstTry |        10001 |     100000 | Int32[0] | 1.1301 ns | 0.1672 ns | 0.4849 ns |     - |     - |     - |         - |
| SecondTry |        10001 |     100000 | Int32[0] | 0.7568 ns | 0.0535 ns | 0.0878 ns |     - |     - |     - |         - |
|  ThirdTry |        10001 |     100000 | Int32[0] | 1.3034 ns | 0.1026 ns | 0.2960 ns |     - |     - |     - |         - |
|  FirstTry |        12345 |     100000 | Int32[0] | 0.6665 ns | 0.0457 ns | 0.0427 ns |     - |     - |     - |         - |
| SecondTry |        12345 |     100000 | Int32[0] | 0.9200 ns | 0.0952 ns | 0.2638 ns |     - |     - |     - |         - |
|  ThirdTry |        12345 |     100000 | Int32[0] | 0.9663 ns | 0.1628 ns | 0.4619 ns |     - |     - |     - |         - |