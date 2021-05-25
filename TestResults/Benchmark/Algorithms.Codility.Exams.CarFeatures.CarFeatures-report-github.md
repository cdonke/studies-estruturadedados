``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.409
  [Host] : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|    Method |      cars | Mean | Error |
|---------- |---------- |-----:|------:|
|  FirstTry | String[5] |   NA |    NA |
| SecondTry | String[5] |   NA |    NA |

Benchmarks with issues:
  CarFeatures.FirstTry: DefaultJob [cars=String[5]]
  CarFeatures.SecondTry: DefaultJob [cars=String[5]]
