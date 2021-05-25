# Exercise
Given an unsorted integer array, find a pair with a given sum in it.

For Example:
**Input:**
``` 
arr = [8, 7, 2, 5, 3, 1]
sum = 10
```

**Output:**
``` 
Pair found at index 0 and 2 (8 + 2)
or
Pair found at index 1 and 4 (7 + 3)
```

# Benchmark

**Last update:** Tue May 25 19:55:36 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.409
  [Host] : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|    Method |        A | sum | Mean | Error |
|---------- |--------- |---- |-----:|------:|
|  FirstTry | Int32[6] |  10 |   NA |    NA |
| SecondTry | Int32[6] |  10 |   NA |    NA |
|  ThirdTry | Int32[6] |  10 |   NA |    NA |

Benchmarks with issues:
  FindTheSum.FirstTry: DefaultJob [A=Int32[6], sum=10]
  FindTheSum.SecondTry: DefaultJob [A=Int32[6], sum=10]
  FindTheSum.ThirdTry: DefaultJob [A=Int32[6], sum=10]
