using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Algorithms.Sorting
{
    /// <summary>
    /// Time: O(n*log n)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [MemoryDiagnoser]
    [KeepBenchmarkFiles]
    [MarkdownExporterAttribute.GitHub]
    public class HeapSort
    {
        #region Data
        [ExcludeFromCodeCoverage]
        private object[] GenerateData(int N, int min, int max)
        {
            Random r = new Random();
            HashSet<int> range = new HashSet<int>();
            for (int i = 0; i < N || range.Count < N; i++)
                range.Add(r.Next(min, max));

            return range.OrderBy(q => r.Next()).Select(q=>(object)q).ToArray();
        }
        [ExcludeFromCodeCoverage]
        public IEnumerable<object[]> Data()
        {
            yield return GenerateData(10, 0, 100);
            yield return GenerateData(50, -100, 100);
            yield return GenerateData(10_000, -10_000, 10_000);
            yield return GenerateData(100_000, -100_000, 100_000);
            yield return GenerateData(1_000_000, -1_000_000, 1_000_000);

        }
        #endregion

        // Root = 0
        // Parent = i
        // Left Node = 2i+1
        // Right Node = 2i+2
        // Find Parent = (i-1)/2
        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public int[] Sort(int[] A)
        {
            // Loop goes backward
            // Starting at the half of the vector - 1
            // That's because of the calculation of its children (2i+1 and 2i+2).
            // At half of the vector there would be an Index Out of Bound, considering (2 * Vector Length + 1|2 )
            // Creates heap from the data
            for (int k = A.Length / 2 - 1; k >= 0; k--)
                heapfy(A, k, A.Length - 1);

            // Replace A[last] with A[first]
            // That's because the highest number will be at the first position
            // So we move it to the last position (so called ordered part), and recalculate the heap.
            for (int i = A.Length - 1; i > 0; i--)
            {
                // Bitwise invertion
                A[0] ^= A[i];
                A[i] ^= A[0];
                A[0] ^= A[i];

                // Remake the heap ignoring the last position
                heapfy(A, 0, i - 1);
            }

            return A;
        }
        /// <summary>
        /// Auxiliary function to create tree
        /// </summary>
        /// <param name="A">Vector</param>
        /// <param name="i">Current index</param>
        /// <param name="N">Expected vector length</param>
        private void heapfy(int[] A, int i, int N)
        {
            // Get parent value and calculate child nodes
            int parent = A[i],
                child = i * 2 + 1;

            // While child still in the vector
            while (child <= N)
            {
                // Still in the vector?
                // Does parent have 2 children? (If not, child == N)
                if (child < N)
                {
                    // Which one of the children is bigger?
                    // If it's the right child, increment child;
                    if (A[child] < A[child + 1])
                        child++;
                }

                // Is parent smaller than the child?
                // If so, he is on the wrong position, they must swap
                if (parent < A[child])
                {
                    // Invert child and parent
                    A[i] = A[child];

                    // Change indexes between them too
                    i = child;

                    // Recalculate first child
                    child = i * 2 + 1;
                }
                else
                {
                    // If not, end the loop
                    // We are done.
                    child = N + 1;
                }

            }

            // Place at the last position the value of the parent
            A[i] = parent;
        }
    }
}
