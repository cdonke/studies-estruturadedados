# Exercise

Roman numerals are represented by seven different symbols: `I`, `V`, `X`, `L`, `C`, `D` and `M`.

| Symbol | Value |
| --- | --- |
| I | 1	  | 
| V | 5	  | 
| X | 10  | 
| L | 50  | 
| C | 100 | 
| D | 500 | 
| M | 1000| 

For example, `2` is written as `II` in Roman numeral, just two one's added together. `12` is written as `XII`, which is simply `X + II`. The number `27` is written as `XXVII`, which is `XX + V + II`.

Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not `IIII`. Instead, the number four is written as `IV`. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as `IX`. There are six instances where subtraction is used:


- `I` can be placed before `V` (5) and `X` (10) to make 4 and 9. 
- `X` can be placed before `L` (50) and `C` (100) to make 40 and 90. 
- `C` can be placed before `D` (500) and `M` (1000) to make 400 and 900.
Given a roman numeral, convert it to an integer.

 

**Example 1:**
```
Input: s = "III"
Output: 3
```

**Example 2:**
```
Input: s = "IV"
Output: 4
```

**Example 3:**
```
Input: s = "IX"
Output: 9
```

**Example 4:**
```
Input: s = "LVIII"
Output: 58
Explanation: L = 50, V= 5, III = 3.
```

**Example 5:**
```
Input: s = "MCMXCIV"
Output: 1994
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
```

**Constraints:**

- `1 <= s.length <= 15`
- `s` contains only the characters `('I', 'V', 'X', 'L', 'C', 'D', 'M')`.
- It is **guaranteed** that s is a valid roman numeral in the range `[1, 3999]`.

# Benchmark

**Last update:** Tue May 25 19:55:36 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.409
  [Host] : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|   Method |       s | expected | Mean | Error |
|--------- |-------- |--------- |-----:|------:|
| **FirstTry** |       **I** |        **1** |   **NA** |    **NA** |
| **FirstTry** |     **III** |        **3** |   **NA** |    **NA** |
| **FirstTry** |      **IV** |        **4** |   **NA** |    **NA** |
| **FirstTry** |      **IX** |        **9** |   **NA** |    **NA** |
| **FirstTry** |   **LVIII** |       **58** |   **NA** |    **NA** |
| **FirstTry** | **MCMXCIV** |     **1994** |   **NA** |    **NA** |
| **FirstTry** |       **V** |        **5** |   **NA** |    **NA** |
| **FirstTry** |       **X** |       **10** |   **NA** |    **NA** |

Benchmarks with issues:
  RomanToInteger.FirstTry: DefaultJob [s=I, expected=1]
  RomanToInteger.FirstTry: DefaultJob [s=III, expected=3]
  RomanToInteger.FirstTry: DefaultJob [s=IV, expected=4]
  RomanToInteger.FirstTry: DefaultJob [s=IX, expected=9]
  RomanToInteger.FirstTry: DefaultJob [s=LVIII, expected=58]
  RomanToInteger.FirstTry: DefaultJob [s=MCMXCIV, expected=1994]
  RomanToInteger.FirstTry: DefaultJob [s=V, expected=5]
  RomanToInteger.FirstTry: DefaultJob [s=X, expected=10]
