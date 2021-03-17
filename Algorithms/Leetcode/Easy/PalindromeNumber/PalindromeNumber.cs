using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Algorithms.Leetcode.Easy.PalindromeNumber
{
    [MemoryDiagnoser, KeepBenchmarkFiles, MarkdownExporterAttribute.GitHub]
    public class PalindromeNumber
    {
        [ExcludeFromCodeCoverage]
        public IEnumerable<object[]> Data()
        {
            yield return new object[] { 121, true };
            yield return new object[] { -121, false };
            yield return new object[] { 10, false };
            yield return new object[] { -101, false };
            yield return new object[] { 1221, true };
            yield return new object[] { 0, true };
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public bool FirstTry(int x, bool expected)
        {
            if (x == 0)
                return true;

            if (x < 0 || x % 10 == 0)
                return false;

            int originalNumber = x;
            long reversed = 0;
            int pop = 0;
            while (x != 0)
            {
                pop = x % 10;
                x /= 10;

                if (reversed > Int32.MaxValue / 10 || (reversed == Int32.MaxValue / 10 && pop > 7))
                    return false;

                if (reversed < Int32.MinValue / 10 || (reversed == Int32.MinValue / 10 && pop < -8))
                    return false;

                reversed = reversed * 10 + pop;
            }


            return (reversed == originalNumber);
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public bool SecondTry(int x, bool expected)
        {
            // Special cases:
            // As discussed above, when x < 0, x is not a palindrome.
            // Also if the last digit of the number is 0, in order to be a palindrome,
            // the first digit of the number also needs to be 0.
            // Only 0 satisfy this property.
            if (x < 0 || (x % 10 == 0 && x != 0))
                return false;

            int revertedNumber = 0;
            while (x > revertedNumber)
            {
                revertedNumber = revertedNumber * 10 + x % 10;
                x /= 10;
            }

            // When the length is an odd number, we can get rid of the middle digit by revertedNumber/10
            // For example when the input is 12321, at the end of the while loop we get x = 12, revertedNumber = 123,
            // since the middle digit doesn't matter in palidrome(it will always equal to itself), we can simply get rid of it.
            return x == revertedNumber || x == revertedNumber / 10; ;
        }
    }
}
