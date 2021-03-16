using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace Algorithms.Arrays.MaximumProduct
{
    [MemoryDiagnoser]
    [KeepBenchmarkFiles]
    [MarkdownExporterAttribute.GitHub]
    public class MaximumProduct
    {
        [ExcludeFromCodeCoverage]
        public IEnumerable<int[]> Data()
        {
            yield return new int[] { -10, -3, 5, 6, -2 };

            Random r = new Random();

            foreach (var item in new int[] { 15, 50, 100, 500, 1000 })
            {
                List<int> numbers = new List<int>();

                for (int i = 0; i < item; i++)
                    numbers.Add(r.Next(-1000, 1000));

                var arrNumbers = numbers.ToArray();
#if DEBUG
                Console.WriteLine($"[{string.Join(", ", arrNumbers)}]");
#endif
                yield return arrNumbers;
            }
        }

        [Benchmark(Description = "Double-loop - O(n^2)")]
        [ArgumentsSource(nameof(Data))]
        public int FirstTry(int[] A)
        {
            int maxValue = 0;
            int product = 0;

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i; j < A.Length; j++)
                {
                    if (i == j)
                        continue;

                    product = A[i] * A[j];
                    if (product > maxValue)
                        maxValue = product;
                }
            }

            return maxValue;
        }

        [Benchmark(Description = "Linear - Sorted - O(n.log n)")]
        [ArgumentsSource(nameof(Data))]
        public int SecondTry(int[] A)
        {
            Array.Sort(A);

            if (A[0] * A[1] > A[A.Length - 1] * A[A.Length - 2])
            {
                return A[0] * A[1];
            }
            else
            {
                return A[A.Length - 1] * A[A.Length - 2];
            }
        }

        [Benchmark(Description = "Linear - Traversal - O(n)")]
        [ArgumentsSource(nameof(Data))]
        public int ThirdTry(int[] A)
        {
            // Keep the max and 2nd max value
            int max = 0, max2 = int.MaxValue;

            // Keep the min and 2nd min value
            int min = 0, min2 = int.MinValue;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > max)
                {
                    max2 = max;
                    max = A[i];
                }
                else if (A[i] > max2)
                {
                    max2 = A[i];
                }

                if (A[i] < min)
                {
                    min2 = min;
                    min = A[i];
                }
                else if (A[i] < min2)
                {
                    min2 = A[i];
                }
            }

            if (max * max2 > min * min2)
            {
                return max * max2;
            }
            else
            {
                return min * min2;
            }
        }
    }
}
