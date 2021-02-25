``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 18.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|      Method |  valores |     Mean |    Error |   StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------ |--------- |---------:|---------:|---------:|------:|------:|------:|----------:|
| SortWithAux | Int32[9] | 55.67 ns | 0.897 ns | 0.839 ns |     - |     - |     - |         - |
| SortWithXOR | Int32[9] | 55.08 ns | 0.709 ns | 0.663 ns |     - |     - |     - |         - |
