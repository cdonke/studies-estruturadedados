``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host] : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|   Method |     nums | target | expected | Mean | Error |
|--------- |--------- |------- |--------- |-----:|------:|
| **FirstTry** | **Int32[2]** |      **6** | **Int32[2]** |   **NA** |    **NA** |
| ThirdTry | Int32[2] |      6 | Int32[2] |   NA |    NA |
| **FirstTry** | **Int32[3]** |      **6** | **Int32[2]** |   **NA** |    **NA** |
| ThirdTry | Int32[3] |      6 | Int32[2] |   NA |    NA |
| **FirstTry** | **Int32[4]** |      **9** | **Int32[2]** |   **NA** |    **NA** |
| ThirdTry | Int32[4] |      9 | Int32[2] |   NA |    NA |

Benchmarks with issues:
  TwoSum.FirstTry: DefaultJob [nums=Int32[2], target=6, expected=Int32[2]]
  TwoSum.ThirdTry: DefaultJob [nums=Int32[2], target=6, expected=Int32[2]]
  TwoSum.FirstTry: DefaultJob [nums=Int32[3], target=6, expected=Int32[2]]
  TwoSum.ThirdTry: DefaultJob [nums=Int32[3], target=6, expected=Int32[2]]
  TwoSum.FirstTry: DefaultJob [nums=Int32[4], target=9, expected=Int32[2]]
  TwoSum.ThirdTry: DefaultJob [nums=Int32[4], target=9, expected=Int32[2]]
