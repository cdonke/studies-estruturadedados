``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 18.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.406
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|               Method |        A |     Mean |    Error |   StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------- |---------:|---------:|---------:|------:|------:|------:|----------:|
|             FirstTry | Int32[5] | 10.52 ns | 0.142 ns | 0.126 ns |     - |     - |     - |         - |
|  FirstTry_BitwiseAbs | Int32[5] | 10.21 ns | 0.180 ns | 0.159 ns |     - |     - |     - |         - |
|            SecondTry | Int32[5] | 13.38 ns | 0.170 ns | 0.142 ns |     - |     - |     - |         - |
| SecondTry_BitwiseAbs | Int32[5] | 13.00 ns | 0.301 ns | 0.282 ns |     - |     - |     - |         - |
