``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.409
  [Host] : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|    Method | MissingValue | DataLength |         A | Mean | Error |
|---------- |------------- |----------- |---------- |-----:|------:|
|  **FirstTry** |        **10001** |     **100000** | **Object[1]** |   **NA** |    **NA** |
| SecondTry |        10001 |     100000 | Object[1] |   NA |    NA |
|  ThirdTry |        10001 |     100000 | Object[1] |   NA |    NA |
|  **FirstTry** |        **12345** |     **100000** | **Object[1]** |   **NA** |    **NA** |
| SecondTry |        12345 |     100000 | Object[1] |   NA |    NA |
|  ThirdTry |        12345 |     100000 | Object[1] |   NA |    NA |

Benchmarks with issues:
  PermMissingElem.FirstTry: DefaultJob [MissingValue=10001, DataLength=100000, A=Object[1]]
  PermMissingElem.SecondTry: DefaultJob [MissingValue=10001, DataLength=100000, A=Object[1]]
  PermMissingElem.ThirdTry: DefaultJob [MissingValue=10001, DataLength=100000, A=Object[1]]
  PermMissingElem.FirstTry: DefaultJob [MissingValue=12345, DataLength=100000, A=Object[1]]
  PermMissingElem.SecondTry: DefaultJob [MissingValue=12345, DataLength=100000, A=Object[1]]
  PermMissingElem.ThirdTry: DefaultJob [MissingValue=12345, DataLength=100000, A=Object[1]]
