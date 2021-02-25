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
|    Method |         A |      Mean |     Error |    StdDev |    Median |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |---------- |----------:|----------:|----------:|----------:|-------:|------:|------:|----------:|
|  FirstTry | Object[2] | 19.510 ns | 1.1481 ns | 3.3307 ns | 18.705 ns | 0.0095 |     - |     - |      40 B |
|  FirstTry | Object[2] | 18.372 ns | 0.7511 ns | 2.1062 ns | 17.507 ns | 0.0095 |     - |     - |      40 B |
|  FirstTry | Object[2] | 24.767 ns | 0.7336 ns | 2.1165 ns | 24.441 ns | 0.0114 |     - |     - |      48 B |
|  FirstTry | Object[2] | 25.290 ns | 0.5976 ns | 1.3367 ns | 24.978 ns | 0.0115 |     - |     - |      48 B |
| SecondTry | Object[2] | 21.847 ns | 0.5489 ns | 1.5483 ns | 21.379 ns | 0.0095 |     - |     - |      40 B |
| SecondTry | Object[2] | 27.808 ns | 2.6970 ns | 7.9522 ns | 24.713 ns | 0.0095 |     - |     - |      40 B |
| SecondTry | Object[2] | 52.862 ns | 1.4475 ns | 3.9380 ns | 54.106 ns |      - |     - |     - |         - |
| SecondTry | Object[2] |  3.902 ns | 0.1511 ns | 0.4211 ns |  3.759 ns |      - |     - |     - |         - |