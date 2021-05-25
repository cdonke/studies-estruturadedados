``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.409
  [Host] : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|    Method |           A | Mean | Error |
|---------- |------------ |-----:|------:|
| **SecondTry** | **Int32[1020]** |   **NA** |    **NA** |
|  **FirstTry** | **Int32[1184]** |   **NA** |    **NA** |
|  **FirstTry** | **Int32[1390]** |   **NA** |    **NA** |
| **SecondTry** | **Int32[1589]** |   **NA** |    **NA** |
| **SecondTry** | **Int32[1700]** |   **NA** |    **NA** |
|  **FirstTry** | **Int32[1980]** |   **NA** |    **NA** |
| **SecondTry** | **Int32[2286]** |   **NA** |    **NA** |
|  **FirstTry** | **Int32[2809]** |   **NA** |    **NA** |
| **SecondTry** | **Int32[3132]** |   **NA** |    **NA** |
| **SecondTry** | **Int32[3203]** |   **NA** |    **NA** |
| **SecondTry** | **Int32[3609]** |   **NA** |    **NA** |
|  **FirstTry** | **Int32[3635]** |   **NA** |    **NA** |
| **SecondTry** | **Int32[3981]** |   **NA** |    **NA** |
| **SecondTry** | **Int32[4086]** |   **NA** |    **NA** |
| **SecondTry** |  **Int32[434]** |   **NA** |    **NA** |
|  **FirstTry** | **Int32[4380]** |   **NA** |    **NA** |
|  **FirstTry** | **Int32[5106]** |   **NA** |    **NA** |
|  **FirstTry** | **Int32[5802]** |   **NA** |    **NA** |
|  **FirstTry** |  **Int32[592]** |   **NA** |    **NA** |
|  **FirstTry** |  **Int32[669]** |   **NA** |    **NA** |
|  **FirstTry** |    **Int32[7]** |   **NA** |    **NA** |
| SecondTry |    Int32[7] |   NA |    NA |
|  **FirstTry** |    **Int32[8]** |   **NA** |    **NA** |
|  FirstTry |    Int32[8] |   NA |    NA |
|  FirstTry |    Int32[8] |   NA |    NA |
| SecondTry |    Int32[8] |   NA |    NA |
| SecondTry |    Int32[8] |   NA |    NA |
| SecondTry |    Int32[8] |   NA |    NA |

Benchmarks with issues:
  MergeSort.SecondTry: DefaultJob [A=Int32[1020]]
  MergeSort.FirstTry: DefaultJob [A=Int32[1184]]
  MergeSort.FirstTry: DefaultJob [A=Int32[1390]]
  MergeSort.SecondTry: DefaultJob [A=Int32[1589]]
  MergeSort.SecondTry: DefaultJob [A=Int32[1700]]
  MergeSort.FirstTry: DefaultJob [A=Int32[1980]]
  MergeSort.SecondTry: DefaultJob [A=Int32[2286]]
  MergeSort.FirstTry: DefaultJob [A=Int32[2809]]
  MergeSort.SecondTry: DefaultJob [A=Int32[3132]]
  MergeSort.SecondTry: DefaultJob [A=Int32[3203]]
  MergeSort.SecondTry: DefaultJob [A=Int32[3609]]
  MergeSort.FirstTry: DefaultJob [A=Int32[3635]]
  MergeSort.SecondTry: DefaultJob [A=Int32[3981]]
  MergeSort.SecondTry: DefaultJob [A=Int32[4086]]
  MergeSort.SecondTry: DefaultJob [A=Int32[434]]
  MergeSort.FirstTry: DefaultJob [A=Int32[4380]]
  MergeSort.FirstTry: DefaultJob [A=Int32[5106]]
  MergeSort.FirstTry: DefaultJob [A=Int32[5802]]
  MergeSort.FirstTry: DefaultJob [A=Int32[592]]
  MergeSort.FirstTry: DefaultJob [A=Int32[669]]
  MergeSort.FirstTry: DefaultJob [A=Int32[7]]
  MergeSort.SecondTry: DefaultJob [A=Int32[7]]
  MergeSort.FirstTry: DefaultJob [A=Int32[8]]
  MergeSort.FirstTry: DefaultJob [A=Int32[8]]
  MergeSort.FirstTry: DefaultJob [A=Int32[8]]
  MergeSort.SecondTry: DefaultJob [A=Int32[8]]
  MergeSort.SecondTry: DefaultJob [A=Int32[8]]
  MergeSort.SecondTry: DefaultJob [A=Int32[8]]
