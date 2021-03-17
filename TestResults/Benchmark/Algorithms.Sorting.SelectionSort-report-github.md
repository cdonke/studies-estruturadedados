``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host]     : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  DefaultJob : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|      Method |      valores |    Mean |    Error |   StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------ |------------- |--------:|---------:|---------:|------:|------:|------:|----------:|
| SortWithXOR | Int32[50000] | 1.050 s | 0.0206 s | 0.0221 s |     - |     - |     - |    8648 B |
| SortWithAux | Int32[50000] | 1.043 s | 0.0150 s | 0.0140 s |     - |     - |     - |         - |
|    ThirdTry | Int32[50000] | 1.117 s | 0.0214 s | 0.0200 s |     - |     - |     - |    8648 B |
