``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 18.04
Intel Xeon CPU E5-2673 v3 2.40GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host] : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|   Method | X |        A | Mean | Error |
|--------- |-- |--------- |-----:|------:|
| FirstTry | 6 | Int32[8] |   NA |    NA |

Benchmarks with issues:
  FrogRiverOne.FirstTry: DefaultJob [X=6, A=Int32[8]]
