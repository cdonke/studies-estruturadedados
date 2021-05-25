using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Algorithms.Arrays.CountInversions
{
    [MemoryDiagnoser, KeepBenchmarkFiles, MarkdownExporterAttribute.GitHub]
    public class CountInversions
    {
        [ExcludeFromCodeCoverage]
        public IEnumerable<object[]> Data()
        {
            yield return new object[] { new[] { 1, 3, 5, 2, 4, 6 }, 3, };
        }

        #region First Try
        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public int FirstTry(int[] A, int expected)
        {
            var i = SortAndCount_FirstTry(A);
            return i.Item2;
        }

        private (int[], int) SortAndCount_FirstTry(int[] A)
        {
#if DEBUG
            Console.WriteLine($"len(A): {A.Length}");
#endif
            if (A.Length <= 1)
                return (A, 0);

            int[] left = new int[A.Length / 2];
            int[] right = new int[A.Length - left.Length];

            for (int i = 0; i < left.Length; i++)
                left[i] = A[i];
            for (int i = 0; i < right.Length; i++)
                right[i] = A[right.Length - 1 + i];


            (int[] B, int x) = SortAndCount_FirstTry(left);
            (int[] C, int y) = SortAndCount_FirstTry(right);
            (int[] D, int z) = CountSplitInversions_FirstTry(A, A.Length);

            return (D, z);
        }

        private (int[], int) CountSplitInversions_FirstTry(int[] A, int n)
        {
            int inversions = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (A[i] < A[i + 1])
                    inversions++;
            }

            return (A, inversions);
        }
        #endregion
    }
}
