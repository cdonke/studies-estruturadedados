``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|      Method |  valores |     Mean |    Error |   StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------ |--------- |---------:|---------:|---------:|------:|------:|------:|----------:|
| SortWithAux | Int32[9] | 37.03 ns | 0.783 ns | 0.804 ns |     - |     - |     - |         - |
| SortWithXOR | Int32[9] | 38.25 ns | 0.661 ns | 0.619 ns |     - |     - |     - |         - |
