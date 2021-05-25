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

**Last update:** Tue May 25 20:02:21 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.409
  [Host] : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|   Method |     nums | target | expected | Mean | Error |
|--------- |--------- |------- |--------- |-----:|------:|
| **FirstTry** | **Int32[2]** |      **6** | **Int32[2]** |   **NA** |    **NA** |
| ThirdTry | Int32[2] |      6 | Int32[2] |   NA |    NA |
| **FirstTry** | **Int32[3]** |      **6** | **Int32[2]** |   **NA** |    **NA** |
| ThirdTry | Int32[3] |      6 | Int32[2] |   NA |    NA |
| **FirstTry** | **Int32[4]** |      **9** | **Int32[2]** |   **NA** |    **NA** |
| ThirdTry | Int32[4] |      9 | Int32[2] |   NA |    NA |

Benchmarks with issues:
  TwoSum.FirstTry: DefaultJob [nums=Int32[2], target=6, expected=Int32[2]]
  TwoSum.ThirdTry: DefaultJob [nums=Int32[2], target=6, expected=Int32[2]]
  TwoSum.FirstTry: DefaultJob [nums=Int32[3], target=6, expected=Int32[2]]
  TwoSum.ThirdTry: DefaultJob [nums=Int32[3], target=6, expected=Int32[2]]
  TwoSum.FirstTry: DefaultJob [nums=Int32[4], target=9, expected=Int32[2]]
  TwoSum.ThirdTry: DefaultJob [nums=Int32[4], target=9, expected=Int32[2]]
