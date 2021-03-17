# Exercise

Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have **exactly one solution**, and you may not use the same element twice.

You can return the answer in any order. 

**Example 1:**
```
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Output: Because nums[0] + nums[1] == 9, we return [0, 1].
```

**Example 2:**
```
Input: nums = [3,2,4], target = 6
Output: [1,2]
```

**Example 3:**
```
Input: nums = [3,3], target = 6
Output: [0,1]
```

**Constraints:**
```
- 2 <= nums.length <= 103
- -109 <= nums[i] <= 109
- -109 <= target <= 109
- **Only one valid answer exists.**
```

# Benchmark

**Last update:** Wed Mar 17 15:15:21 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.407
  [Host]     : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  DefaultJob : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|   Method |     nums | target | expected |       Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |--------- |------- |--------- |-----------:|----------:|----------:|-------:|------:|------:|----------:|
| **FirstTry** | **Int32[2]** |      **6** | **Int32[2]** |   **8.420 ns** | **0.2499 ns** | **0.2455 ns** | **0.0012** |     **-** |     **-** |      **32 B** |
| ThirdTry | Int32[2] |      6 | Int32[2] | 182.323 ns | 1.7210 ns | 1.4371 ns | 0.0131 |     - |     - |     344 B |
| **FirstTry** | **Int32[3]** |      **6** | **Int32[2]** |  **10.624 ns** | **0.2298 ns** | **0.2037 ns** | **0.0012** |     **-** |     **-** |      **32 B** |
| ThirdTry | Int32[3] |      6 | Int32[2] | 245.948 ns | 4.8218 ns | 5.9216 ns | 0.0196 |     - |     - |     512 B |
| **FirstTry** | **Int32[4]** |      **9** | **Int32[2]** |   **8.354 ns** | **0.2055 ns** | **0.1922 ns** | **0.0012** |     **-** |     **-** |      **32 B** |
| ThirdTry | Int32[4] |      9 | Int32[2] | 198.194 ns | 3.5655 ns | 3.5018 ns | 0.0167 |     - |     - |     440 B |
