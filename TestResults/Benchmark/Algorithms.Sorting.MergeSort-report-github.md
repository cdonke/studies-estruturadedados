``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.409
  [Host] : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|    Method |           A | Mean | Error |
|---------- |------------ |-----:|------:|
|  **FirstTry** | **Int32[1412]** |   **NA** |    **NA** |
| **SecondTry** | **Int32[1529]** |   **NA** |    **NA** |
| **SecondTry** | **Int32[1870]** |   **NA** |    **NA** |
|  **FirstTry** | **Int32[2205]** |   **NA** |    **NA** |
|  **FirstTry** | **Int32[2278]** |   **NA** |    **NA** |
|  **FirstTry** | **Int32[2390]** |   **NA** |    **NA** |
| **SecondTry** | **Int32[2514]** |   **NA** |    **NA** |
|  **FirstTry** | **Int32[3043]** |   **NA** |    **NA** |
| **SecondTry** | **Int32[3152]** |   **NA** |    **NA** |
| **SecondTry** | **Int32[3918]** |   **NA** |    **NA** |
|  **FirstTry** | **Int32[4005]** |   **NA** |    **NA** |
| **SecondTry** | **Int32[4151]** |   **NA** |    **NA** |
|  **FirstTry** | **Int32[4478]** |   **NA** |    **NA** |
| **SecondTry** | **Int32[4569]** |   **NA** |    **NA** |
| **SecondTry** | **Int32[4996]** |   **NA** |    **NA** |
| **SecondTry** | **Int32[5295]** |   **NA** |    **NA** |
|  **FirstTry** |  **Int32[540]** |   **NA** |    **NA** |
|  **FirstTry** | **Int32[5421]** |   **NA** |    **NA** |
|  **FirstTry** | **Int32[6218]** |   **NA** |    **NA** |
| **SecondTry** |  **Int32[665]** |   **NA** |    **NA** |
|  **FirstTry** |    **Int32[7]** |   **NA** |    **NA** |
| SecondTry |    Int32[7] |   NA |    NA |
|  **FirstTry** |    **Int32[8]** |   **NA** |    **NA** |
|  FirstTry |    Int32[8] |   NA |    NA |
|  FirstTry |    Int32[8] |   NA |    NA |
| SecondTry |    Int32[8] |   NA |    NA |
| SecondTry |    Int32[8] |   NA |    NA |
| SecondTry |    Int32[8] |   NA |    NA |

Benchmarks with issues:
  MergeSort.FirstTry: DefaultJob [A=Int32[1412]]
  MergeSort.SecondTry: DefaultJob [A=Int32[1529]]
  MergeSort.SecondTry: DefaultJob [A=Int32[1870]]
  MergeSort.FirstTry: DefaultJob [A=Int32[2205]]
  MergeSort.FirstTry: DefaultJob [A=Int32[2278]]
  MergeSort.FirstTry: DefaultJob [A=Int32[2390]]
  MergeSort.SecondTry: DefaultJob [A=Int32[2514]]
  MergeSort.FirstTry: DefaultJob [A=Int32[3043]]
  MergeSort.SecondTry: DefaultJob [A=Int32[3152]]
  MergeSort.SecondTry: DefaultJob [A=Int32[3918]]
  MergeSort.FirstTry: DefaultJob [A=Int32[4005]]
  MergeSort.SecondTry: DefaultJob [A=Int32[4151]]
  MergeSort.FirstTry: DefaultJob [A=Int32[4478]]
  MergeSort.SecondTry: DefaultJob [A=Int32[4569]]
  MergeSort.SecondTry: DefaultJob [A=Int32[4996]]
  MergeSort.SecondTry: DefaultJob [A=Int32[5295]]
  MergeSort.FirstTry: DefaultJob [A=Int32[540]]
  MergeSort.FirstTry: DefaultJob [A=Int32[5421]]
  MergeSort.FirstTry: DefaultJob [A=Int32[6218]]
  MergeSort.SecondTry: DefaultJob [A=Int32[665]]
  MergeSort.FirstTry: DefaultJob [A=Int32[7]]
  MergeSort.SecondTry: DefaultJob [A=Int32[7]]
  MergeSort.FirstTry: DefaultJob [A=Int32[8]]
  MergeSort.FirstTry: DefaultJob [A=Int32[8]]
  MergeSort.FirstTry: DefaultJob [A=Int32[8]]
  MergeSort.SecondTry: DefaultJob [A=Int32[8]]
  MergeSort.SecondTry: DefaultJob [A=Int32[8]]
  MergeSort.SecondTry: DefaultJob [A=Int32[8]]
