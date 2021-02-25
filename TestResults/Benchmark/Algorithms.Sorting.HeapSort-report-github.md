``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 18.04
Intel Xeon CPU E5-2673 v3 2.40GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host] : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
| Method |              A | Mean | Error |
|------- |--------------- |-----:|------:|
|   **Sort** | **Int32[1000000]** |   **NA** |    **NA** |
|   **Sort** |  **Int32[100000]** |   **NA** |    **NA** |
|   **Sort** |   **Int32[10000]** |   **NA** |    **NA** |
|   **Sort** |      **Int32[10]** |   **NA** |    **NA** |
|   **Sort** |      **Int32[50]** |   **NA** |    **NA** |

Benchmarks with issues:
  HeapSort.Sort: DefaultJob [A=Int32[1000000]]
  HeapSort.Sort: DefaultJob [A=Int32[100000]]
  HeapSort.Sort: DefaultJob [A=Int32[10000]]
  HeapSort.Sort: DefaultJob [A=Int32[10]]
  HeapSort.Sort: DefaultJob [A=Int32[50]]
