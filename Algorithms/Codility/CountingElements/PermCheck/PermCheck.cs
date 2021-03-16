using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Algorithms.Codility.CountingElements.PermCheck
{
    [MemoryDiagnoser]
    [KeepBenchmarkFiles]
    [MarkdownExporterAttribute.GitHub]
    public class PermCheck
    {
        [ExcludeFromCodeCoverage]
        public object[] Data() => new object[]
        {
            //new object[] { new int[] {4,1,3,2}, 1 },
            //new object[] { new int[] {4,1,3},0 },
            new object[] { new int[] { Int32.MaxValue }, 0 },
            new object[] { new int[] { Int32.MinValue }, 0 },
            new object[] { new int[] { 100,101 }, 1 },
            new object[] { new int[] { 101,100 }, 1 },
            new object[] { new int[] { 100,102 }, 0 },
            new object[] { new int[] { 102,100 }, 0 }
        };

        //[Benchmark]
        [ArgumentsSource(nameof(Data))]
        [ExcludeFromCodeCoverage]
        public int FirstTry(int[] A)
        {
            // Sort the array to simplify work
            Array.Sort(A);

            // Loop through the array
            // Starting with 1
            for (int i = 1; i < A.Length; i++)
            {
                // Test if current-1 = previous
                // if not, stop testing, because it's already false.
                if (A[i] - 1 != A[i - 1])
                    return 0;
            }

            return 1;
        }

        //[Benchmark]
        [ArgumentsSource(nameof(Data))]
        public int SecondTry(int[] A)
        {
            // Sort the array to simplify work
            Array.Sort(A);

            if (A.Length <= 1)
                return 0;

            // Loop through the array
            // Starting with 1
            for (int i = 1; i < A.Length; i++)
            {
                // Test if current-1 = previous
                // if not, stop testing, because it's already false.
                if (A[i] - 1 != A[i - 1])
                    return 0;
            }

            return 1;
        }
    }
}
