# Shell Sorting
- **In-place:** uses small amount of extra memory
- **Unstable**: Changes the order of duplicate itens.

---

- Improvement of Insertion Sort
- It's fast on pre-sorted array
- **Basic Idea:** pre-sort the input and switch to Insertion Sort
- Gap is used for pre-sorting => swap distant elements.
- Shell sort starts with a "large" gap and gradually reduces it
  - When gap =1, Insertion Sort finishes the sorting process

---

- Shell sort performance depends on a concrete gap value
- in 99% of cases, you can rely on the "universal" sequence of gap values

1. Calculate the max gap < N/3, where N = array length
   ```csharp
   int gap=1;
   while (gap < array.Lenth / 3) 
      gap = 3 * gap + 1
   ```
1. Reduce gap at the end of each step to the outer loop:
   ```csharp
   while (gap >= 1) {
      // sorting
      // ...
      gap /= 3;
   }
   ```
   It gives the sequence: 1, 4, 13, 40, 121, 364, ..., (0.5*(3^k -1))

## Caracteristicas
- **Time complexity:** O(n^2)
  - Depends on how th gap value is calculated.
  - **Worst case:** O(n^(3/2))
  - **Best case:** O(n^(6/5))
- **Space efficiency:** O(1)

## Benchmark

**Last update:** Wed Mar 17 15:15:21 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host]     : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  DefaultJob : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|   Method |        A |       Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |--------- |-----------:|----------:|----------:|------:|------:|------:|----------:|
| **FirstTry** | **Int32[1]** |  **0.9514 ns** | **0.1055 ns** | **0.1408 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** | **Int32[2]** |  **2.5202 ns** | **0.0865 ns** | **0.0767 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** | **Int32[3]** |  **4.1443 ns** | **0.1675 ns** | **0.1792 ns** |     **-** |     **-** |     **-** |         **-** |
| FirstTry | Int32[3] |  3.8290 ns | 0.0826 ns | 0.0690 ns |     - |     - |     - |         - |
| **FirstTry** | **Int32[4]** |  **5.3075 ns** | **0.1729 ns** | **0.1617 ns** |     **-** |     **-** |     **-** |         **-** |
| FirstTry | Int32[4] |  5.3794 ns | 0.1938 ns | 0.2074 ns |     - |     - |     - |         - |
| FirstTry | Int32[4] |  5.2569 ns | 0.1303 ns | 0.1219 ns |     - |     - |     - |         - |
| FirstTry | Int32[4] |  5.1898 ns | 0.1895 ns | 0.1861 ns |     - |     - |     - |         - |
| **FirstTry** | **Int32[8]** | **17.3054 ns** | **0.4239 ns** | **0.3758 ns** |     **-** |     **-** |     **-** |         **-** |
