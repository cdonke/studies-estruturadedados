# Bubble Sorting
- **In-place:** uses small amount of extra memory
- **Unstable**: There is no garantee that the original order is preserver.
- Simillar to Bubble Sort

It has a wall, initially set to the end of the array.

We select the largest element at each pass.
At the beginning of each pass, we consider the largest element as the first one, and set the iterator as the 2nd one.

```
for(int i=0; i < array.Length; i++) { /* ... */ };

var largest = 0
var iterator = i + 1
```

At each pass, we increment the iterator, until we reach the wall, searching for the largest element.
When we find the a larger element compared to the current largest, we change the `largest` index to the current.
```
largest = i;
```

Then we swap the biggest element with the last one, and decrement the wall.


## Caracteristicas
- **Time complexity:** O(n^2)
- **Space efficiency:** O(1)
- **Degrades rapidly** - Though usually fast than Bubble Sort


## Benchmark

**Last update:** Wed Mar 17 15:15:21 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host]     : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  DefaultJob : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|      Method |      valores |    Mean |    Error |   StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------ |------------- |--------:|---------:|---------:|------:|------:|------:|----------:|
| SortWithXOR | Int32[50000] | 1.050 s | 0.0206 s | 0.0221 s |     - |     - |     - |    8648 B |
| SortWithAux | Int32[50000] | 1.043 s | 0.0150 s | 0.0140 s |     - |     - |     - |         - |
|    ThirdTry | Int32[50000] | 1.117 s | 0.0214 s | 0.0200 s |     - |     - |     - |    8648 B |
