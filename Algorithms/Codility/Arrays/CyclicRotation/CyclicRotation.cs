using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Codility.Arrays.CyclicRotation
{
    [MemoryDiagnoser]
    [KeepBenchmarkFiles]
    [MarkdownExporterAttribute.GitHub]
    public class CyclicRotation
    {
        [Benchmark]
        [Arguments(new int[] { 3, 8, 9, 7, 6 }, 3)]
        [Arguments(new int[] { 0, 0, 0 }, 1)]
        [Arguments(new int[] { 1, 2, 3, 4 }, 4)]
        public int[] FirstTry(int[] A, int K)
        {
            if (A.Length > 100 || A.Length < 0)
                throw new ArgumentOutOfRangeException(nameof(A));
            if (K > 100 || K < 0)
                throw new ArgumentOutOfRangeException(nameof(K));

            var result = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
                result[(i + K) % A.Length] = A[i];

            return result;
        }

        [Benchmark]
        [Arguments(new int[] { 3, 8, 9, 7, 6 }, 3)]
        [Arguments(new int[] { 0, 0, 0 }, 1)]
        [Arguments(new int[] { 1, 2, 3, 4 }, 4)]
        public int[] SecondTry(int[] A, int K)
        {
            if (A.Length > 100 || A.Length < 0)
                throw new ArgumentOutOfRangeException(nameof(A));
            if (K > 100 || K < 0)
                throw new ArgumentOutOfRangeException(nameof(K));

            var result = new int[A.Length];
            int nextPosition = 0;
            for (int i = 0; i < A.Length; i++)
            {
                nextPosition = (i + K) % A.Length;
                result[nextPosition] = A[i];
            }

            return result;
        }
    }
}
