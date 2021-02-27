``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 18.04
Intel Xeon CPU E5-2673 v3 2.40GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|      Method |      valores |    Mean |    Error |   StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------ |------------- |--------:|---------:|---------:|------:|------:|------:|----------:|
| SortWithXOR | Int32[50000] | 1.150 s | 0.0120 s | 0.0107 s |     - |     - |     - |    3576 B |
| SortWithAux | Int32[50000] | 1.165 s | 0.0202 s | 0.0189 s |     - |     - |     - |         - |
