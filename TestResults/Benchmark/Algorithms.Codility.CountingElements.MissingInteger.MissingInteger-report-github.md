``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.409
  [Host] : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|    Method |              A | missingInteger | Mean | Error |
|---------- |--------------- |--------------- |-----:|------:|
|  **FirstTry** |    **Int32[1534]** |              **1** |   **NA** |    **NA** |
|  **FirstTry** |     **Int32[156]** |              **1** |   **NA** |    **NA** |
| **SecondTry** |    **Int32[1824]** |              **1** |   **NA** |    **NA** |
|  **FirstTry** |     **Int32[435]** |              **1** |   **NA** |    **NA** |
| **SecondTry** |     **Int32[451]** |              **1** |   **NA** |    **NA** |
| **SecondTry** |    **Int32[4918]** |              **1** |   **NA** |    **NA** |
|  **FirstTry** |     **Int32[492]** |              **1** |   **NA** |    **NA** |
| **SecondTry** |     **Int32[573]** |              **1** |   **NA** |    **NA** |
|  **FirstTry** |  **Int32[759791]** |              **1** |   **NA** |    **NA** |
| **SecondTry** |     **Int32[867]** |              **1** |   **NA** |    **NA** |
|  **FirstTry** |    **Int32[8750]** |              **1** |   **NA** |    **NA** |
| **SecondTry** | **Int32[1218344]** |         **831126** |   **NA** |    **NA** |

Benchmarks with issues:
  MissingInteger.FirstTry: DefaultJob [A=Int32[1534], missingInteger=1]
  MissingInteger.FirstTry: DefaultJob [A=Int32[156], missingInteger=1]
  MissingInteger.SecondTry: DefaultJob [A=Int32[1824], missingInteger=1]
  MissingInteger.FirstTry: DefaultJob [A=Int32[435], missingInteger=1]
  MissingInteger.SecondTry: DefaultJob [A=Int32[451], missingInteger=1]
  MissingInteger.SecondTry: DefaultJob [A=Int32[4918], missingInteger=1]
  MissingInteger.FirstTry: DefaultJob [A=Int32[492], missingInteger=1]
  MissingInteger.SecondTry: DefaultJob [A=Int32[573], missingInteger=1]
  MissingInteger.FirstTry: DefaultJob [A=Int32[759791], missingInteger=1]
  MissingInteger.SecondTry: DefaultJob [A=Int32[867], missingInteger=1]
  MissingInteger.FirstTry: DefaultJob [A=Int32[8750], missingInteger=1]
  MissingInteger.SecondTry: DefaultJob [A=Int32[1218344], missingInteger=831126]
