using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Codility.CountingElements.FrogRiverOne
{
    [MemoryDiagnoser]
    public class FrogRiverOne
    {
        [Benchmark]
        [Arguments(6, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 })]
        public int FirstTry(int X, int[] A)
        {
            // Create an empty list for all the positions of leaves in the river
            // IF they felt already, it must be true.
            var path = new bool[X];

            // Iterate through all the leaves falling
            for (int i = 0; i < A.Length; i++)
            {
                // Leaves are 1-indexed, and not 0-index. This way, the current position in the array is P-1.
                // If the current leaf hadn't fallen yet, set is as true.
                if (!path[A[i] - 1])
                {
                    path[A[i] - 1] = true;

                    // Decrement X for each placed leaf.
                    // When X == 0, means that all the leaves are placed, and i indicates the time.
                    if (--X == 0)
                        return i;
                }

            }

            return -1;
        }
    }
}
