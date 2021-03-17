using BenchmarkDotNet.Attributes;
using Microsoft.Diagnostics.Tracing.Parsers.Clr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Algorithms.Leetcode.Easy.TwoSum
{
    [MemoryDiagnoser, KeepBenchmarkFiles, MarkdownExporterAttribute.GitHub]
    public class TwoSum
    {
        [ExcludeFromCodeCoverage]
        public IEnumerable<object[]> Data()
        {
            yield return new object[] { new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 } };
            yield return new object[] { new[] { 3, 2, 4 }, 6, new[] { 1, 2 } };
            yield return new object[] { new[] { 3, 3 }, 6, new[] { 0, 1 } };
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public int[] FirstTry(int[] nums, int target, int[] expected)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
                }
            }

            return new int[0];
        }

        // Disabled because it's not achievable.
        //[Benchmark]
        [ArgumentsSource(nameof(Data))]
        public int[] SecondTry(int[] nums, int target, int[] expected)
        {
            var map = new Hashtable(nums.Length);
            for (int i = 0; i < nums.Length; i++)
            {
                map.Add(nums[i], i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement) && (int)map[complement] != i)
                {
                    return new int[] { i, (int)map[complement] };
                }
            }

            throw new Exception("No solutons found");
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public int[] ThirdTry(int[] nums, int target, int[] expected)
        {
            var map = new Hashtable(nums.Length);
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement) && (int)map[complement] != i)
                {
                    return new int[] { (int)map[complement], i };
                }

                map.Add(nums[i], i);
            }

            throw new Exception("No solutons found");
        }
    }
}
