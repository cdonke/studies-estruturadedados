``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 18.04
Intel Xeon CPU E5-2673 v3 2.40GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host] : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|    Method | MissingValue | DataLength |        A | Mean | Error |
|---------- |------------- |----------- |--------- |-----:|------:|
|  **FirstTry** |        **10001** |     **100000** | **Int32[0]** |   **NA** |    **NA** |
| SecondTry |        10001 |     100000 | Int32[0] |   NA |    NA |
|  ThirdTry |        10001 |     100000 | Int32[0] |   NA |    NA |
|  **FirstTry** |        **12345** |     **100000** | **Int32[0]** |   **NA** |    **NA** |
| SecondTry |        12345 |     100000 | Int32[0] |   NA |    NA |
|  ThirdTry |        12345 |     100000 | Int32[0] |   NA |    NA |

Benchmarks with issues:
  PermMissingElem.FirstTry: DefaultJob [MissingValue=10001, DataLength=100000, A=Int32[0]]
  PermMissingElem.SecondTry: DefaultJob [MissingValue=10001, DataLength=100000, A=Int32[0]]
  PermMissingElem.ThirdTry: DefaultJob [MissingValue=10001, DataLength=100000, A=Int32[0]]
  PermMissingElem.FirstTry: DefaultJob [MissingValue=12345, DataLength=100000, A=Int32[0]]
  PermMissingElem.SecondTry: DefaultJob [MissingValue=12345, DataLength=100000, A=Int32[0]]
  PermMissingElem.ThirdTry: DefaultJob [MissingValue=12345, DataLength=100000, A=Int32[0]]
