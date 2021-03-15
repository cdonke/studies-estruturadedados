``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host] : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|    Method |        A | sum | Mean | Error |
|---------- |--------- |---- |-----:|------:|
|  FirstTry | Int32[6] |  10 |   NA |    NA |
| SecondTry | Int32[6] |  10 |   NA |    NA |
|  ThirdTry | Int32[6] |  10 |   NA |    NA |

Benchmarks with issues:
  FindTheSum.FirstTry: DefaultJob [A=Int32[6], sum=10]
  FindTheSum.SecondTry: DefaultJob [A=Int32[6], sum=10]
  FindTheSum.ThirdTry: DefaultJob [A=Int32[6], sum=10]
