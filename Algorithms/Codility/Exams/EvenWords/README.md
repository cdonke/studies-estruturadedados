# Exercise


In an _even_ word, each letter occurs an even number of times.
Write a function that, given a string S consisting of N characters, returns the minimum number of letters that must
be deleted to obtain an even word.

Examples:
1) Given `S="acbcbba"`, the function should return 1 (one letter b must be deleted)
1) Given `S="axxaxa"`, your function shlhoud return 2 (one letter a and one letter x must be deleted)
1) Give `S="aaaa"`, your function should return 0 (there is no neeed to delete any letters).

Write an *efficient* algorithim for the following assumptions:
- N is an integer within the rage [0..200_000]
- string S consists only of lowercase letters (a-z)

# Benchmark

**Last update:** Tue May 25 19:55:36 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.409
  [Host] : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|   Method |       S | Mean | Error |
|--------- |-------- |-----:|------:|
| **FirstTry** |    **aaaa** |   **NA** |    **NA** |
| **FirstTry** | **acbcbba** |   **NA** |    **NA** |
| **FirstTry** |  **axxaxa** |   **NA** |    **NA** |

Benchmarks with issues:
  EvenWords.FirstTry: DefaultJob [S=aaaa]
  EvenWords.FirstTry: DefaultJob [S=acbcbba]
  EvenWords.FirstTry: DefaultJob [S=axxaxa]
