using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    [MemoryDiagnoser]
    [KeepBenchmarkFiles]
    [MarkdownExporterAttribute.GitHub]
    public class ShellSort
    {
        public IEnumerable<int[]> Data()
        {
            yield return new int[] { 1 };
            yield return new int[] { 2, 1 };
            yield return new int[] { 2, 1, 3 };
            yield return new int[] { 1, 1, 1 };
            yield return new int[] { 2, -1, 3, 3 };
            yield return new int[] { 4, -5, 3, 3 };
            yield return new int[] { 0, -5, 3, 3 };
            yield return new int[] { 0, -5, 3, 0 };
            yield return new int[] { 3, 2, 5, 5, 1, 0, 7, 8 };
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public int[] FirstTry(int[] A)
        {
            // Find initial Gap:
            int gap = 1;
            while (gap < A.Length / 3)
            {
                gap = 3 * gap + 1;
            }

            // Start sorting
            while (gap >= 1)
            {
                // GEneralize evrsion of Insert Sort
                for (int i = gap; i < A.Length; i++)
                {
                    for (int j = i; j >= gap && A[j] < A[j - gap]; j -= gap)
                    {
                        Swap(A, j, j - gap);
                    }
                }

                // Decrease gap
                gap /= 3;
            }

            return A;
        }

        private static void Swap(int[] array, int i, int j)
        {
            if (i == j)
                return;
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
