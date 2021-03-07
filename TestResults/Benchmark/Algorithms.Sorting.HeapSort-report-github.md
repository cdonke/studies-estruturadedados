``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host] : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
| Method |               A | Mean | Error |
|------- |---------------- |-----:|------:|
|   **Sort** | **Object[1000000]** |   **NA** |    **NA** |
|   **Sort** |  **Object[100000]** |   **NA** |    **NA** |
|   **Sort** |   **Object[10000]** |   **NA** |    **NA** |
|   **Sort** |      **Object[10]** |   **NA** |    **NA** |
|   **Sort** |      **Object[50]** |   **NA** |    **NA** |

Benchmarks with issues:
  HeapSort.Sort: DefaultJob [A=Object[1000000]]
  HeapSort.Sort: DefaultJob [A=Object[100000]]
  HeapSort.Sort: DefaultJob [A=Object[10000]]
  HeapSort.Sort: DefaultJob [A=Object[10]]
  HeapSort.Sort: DefaultJob [A=Object[50]]
