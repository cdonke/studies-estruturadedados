using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Leetcode.Easy
{
    [TestClass]
    public class TwoSumTests
    {
        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void FirstTry(int[] nums, int target, int[] expected)
        {
            var solution = new Algorithms.Leetcode.Easy.TwoSum.TwoSum();
            var actual = solution.FirstTry(nums, target, null);

            CollectionAssert.AreEqual(expected, actual);
        }


        // Disabled because it's not achievable.
        //[TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void SecondTry(int[] nums, int target, int[] expected)
        {
            var solution = new Algorithms.Leetcode.Easy.TwoSum.TwoSum();
            var actual = solution.SecondTry(nums, target, null);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void ThirdTry(int[] nums, int target, int[] expected)
        {
            var solution = new Algorithms.Leetcode.Easy.TwoSum.TwoSum();
            var actual = solution.ThirdTry(nums, target, null);

            CollectionAssert.AreEqual(expected, actual);
        }

        public static IEnumerable<object[]> Data()
        {
            var solution = new Algorithms.Leetcode.Easy.TwoSum.TwoSum();
            foreach (object[] item in solution.Data())
                yield return item;
        }
    }
}
