using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Algorithms.Arrays.RemoveDuplicates
{
    [MemoryDiagnoser]
    [KeepBenchmarkFiles]
    [MarkdownExporterAttribute.GitHub]
    public class RemoveDuplicates
    {
        [ExcludeFromCodeCoverage]
        public IEnumerable<object> Data() => new[]
        {
            new int[] { 1, 2, 2, 6, 6, 8, 9, 10, 10 },
            new int[] { 2, 2, 2, 2, 2, 2 },
            new int[] { 2, 3, 3, 3, 6, 9, 9 },
            new int[] { 2, 2, 2, 11 }
        };

        [Benchmark(Description = "With new Array - O(n)")]
        [ArgumentsSource(nameof(Data))]
        public int[] FirstTry(int[] A)
        {
            int[] b = new int[A.Length];

            int current = 0;
            int previous = 0;
            int x = 0;

            b[x++] = A[0];

            for (int i = 1; i < A.Length; i++)
            {                           // 1    2
                current = A[i];         // 2    2
                previous = A[i - 1];    // 1    2   

                if (current != previous)// 1    0
                {
                    b[x++] = current;  //[ 1 ]
                }
            }

            return b;
        }

        [Benchmark(Description = "With sorting - O(n^2)")]
        [ArgumentsSource(nameof(Data))]
        public int[] SecondTry(int[] A)
        {
            int previous = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] == previous)
                {
                    A[i] = 0;
                }
                else
                {
                    previous = A[i];
                }
            }

            for (int i = 1; i < A.Length - 1; i++)
            {
                for (int x = 1; x < A.Length - 1; x++)
                {
                    if (A[x] == 0)
                    {
                        A[x] ^= A[x + 1];
                        A[x + 1] ^= A[x];
                        A[x] ^= A[x + 1];
                    }
                }
            }

            return A;
        }

        [Benchmark(Description = "With Hashset - O(n)")]
        [ArgumentsSource(nameof(Data))]
        public int[] ThirdTry(int[] A)
        {
            int[] B = new int[A.Length];

            int position = 0;
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (set.Add(A[i]))
                    B[position++] = A[i];
            }

            return B;
        }

        [Benchmark(Description = "In-place")]
        [ArgumentsSource(nameof(Data))]
        public int[] FourthTry(int[] A)
        {
            int nextNonDup = 1;

            for (int i = 1; i < A.Length; i++)
            {
                if (A[nextNonDup - 1] != A[i])
                {
                    A[nextNonDup++] = A[i];
                }
            }

            for (int i = nextNonDup; i < A.Length; i++)
            {
                A[i] = 0;
            }

            return A;
        }
    }
}
