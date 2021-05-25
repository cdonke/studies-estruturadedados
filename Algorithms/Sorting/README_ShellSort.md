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

**Last update:** Tue May 25 19:55:36 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.409
  [Host] : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|   Method |        A | Mean | Error |
|--------- |--------- |-----:|------:|
| **FirstTry** | **Int32[1]** |   **NA** |    **NA** |
| **FirstTry** | **Int32[2]** |   **NA** |    **NA** |
| **FirstTry** | **Int32[3]** |   **NA** |    **NA** |
| FirstTry | Int32[3] |   NA |    NA |
| **FirstTry** | **Int32[4]** |   **NA** |    **NA** |
| FirstTry | Int32[4] |   NA |    NA |
| FirstTry | Int32[4] |   NA |    NA |
| FirstTry | Int32[4] |   NA |    NA |
| **FirstTry** | **Int32[8]** |   **NA** |    **NA** |

Benchmarks with issues:
  ShellSort.FirstTry: DefaultJob [A=Int32[1]]
  ShellSort.FirstTry: DefaultJob [A=Int32[2]]
  ShellSort.FirstTry: DefaultJob [A=Int32[3]]
  ShellSort.FirstTry: DefaultJob [A=Int32[3]]
  ShellSort.FirstTry: DefaultJob [A=Int32[4]]
  ShellSort.FirstTry: DefaultJob [A=Int32[4]]
  ShellSort.FirstTry: DefaultJob [A=Int32[4]]
  ShellSort.FirstTry: DefaultJob [A=Int32[4]]
  ShellSort.FirstTry: DefaultJob [A=Int32[8]]
