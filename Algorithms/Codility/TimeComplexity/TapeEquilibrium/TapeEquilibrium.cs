using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Codility.TimeComplexity.TapeEquilibrium
{
    [MemoryDiagnoser]
    public class TapeEquilibrium
    {
        public object[] data() =>
            new[] { new int[] { 3, 1, 2, 4, 3 } };

        [Benchmark]
        [ArgumentsSource(nameof(data))]
        public int FirstTry(int[] A)
        {
            int sum = 0,
                left = 0,
                right = 0,
                abs = 0,
                currentSum = Int32.MaxValue;

            for (int i = 0; i < A.Length; i++)
                sum += A[i];

            for (int i = 0; i < A.Length; i++)
            {
                right = sum - left;
                abs = Math.Abs(left - right);
                left += A[i];

                if (abs < currentSum)
                    currentSum = abs;
            }

            return currentSum;
        }

        [Benchmark]
        [ArgumentsSource(nameof(data))]
        public int FirstTry_BitwiseAbs(int[] A)
        {
            int sum = 0,
                left = 0,
                right = 0,
                abs = 0,
                currentSum = Int32.MaxValue,
                mask = 0, delta = 0;

            for (int i = 0; i < A.Length; i++)
                sum += A[i];

            for (int i = 0; i < A.Length; i++)
            {
                right = sum - left;

                delta = left - right;
                mask = delta >> 31;
                delta = delta ^ mask;
                abs = delta - mask;

                left += A[i];

                if (abs < currentSum)
                    currentSum = abs;
            }

            return currentSum;
        }

        [Benchmark]
        [ArgumentsSource(nameof(data))]
        public int SecondTry(int[] A)
        {
            int left = 0,
                right = 0,
                diff = 0,
                minimunDiff = Int32.MaxValue;

            for (int i = 0; i < A.Length; i++)
                right += A[i];

            for (int i = 0; i < A.Length; i++)
            {
                left += A[i];
                right -= A[i];

                diff = Math.Abs(left - right);

                if (diff < minimunDiff)
                    minimunDiff = diff;
            }

            return minimunDiff;
        }

        [Benchmark]
        [ArgumentsSource(nameof(data))]
        public int SecondTry_BitwiseAbs(int[] A)
        {
            int left = 0,
                right = 0,
                diff = 0,
                minimunDiff = Int32.MaxValue,
                mask = 0, delta = 0;

            for (int i = 0; i < A.Length; i++)
                right += A[i];

            for (int i = 0; i < A.Length; i++)
            {
                left += A[i];
                right -= A[i];

                //Let's assume a twos-complement number (as it's the usual case and you don't say otherwise) and let's assume 32-bit:
                delta = left - right;

                // First, we perform an arithmetic right-shift by 31 bits. 
                // This shifts in all 1s for a negative number or all 0s for a positive one 
                mask = delta >> 31;

                //So what we get is 111...111 (-1) for negative numbers and 000...000 (0) for positives
                //Now we XOR this with x, getting the behaviour of a NOT for mask = 111...111(negative) and a no - op for mask = 000...000(positive):
                delta = delta ^ mask;

                //And finally subtract our mask, which means +1 for negatives and +0/no-op for positives:
                diff = delta - mask;

                if (diff < minimunDiff)
                    minimunDiff = diff;
            }

            return minimunDiff;
        }
    }
}
