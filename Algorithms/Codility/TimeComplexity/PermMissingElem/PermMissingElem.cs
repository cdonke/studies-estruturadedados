using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Algorithms.Codility.TimeComplexity.PermMissingElem
{
    [MemoryDiagnoser]
    [KeepBenchmarkFiles]
    [MarkdownExporterAttribute.GitHub]
    public class PermMissingElem
    {
        [ExcludeFromCodeCoverage]
        public object[] data()
        {
            var range = (from q in Enumerable.Range(1, DataLength)
                         where q != MissingValue
                         select q).ToArray();


            return new[] { range };
        }
        [ExcludeFromCodeCoverage]
        [Params(10_001, 12_345)]
        public int MissingValue { get; set; }

        [ExcludeFromCodeCoverage]
        [Params(100_000)]
        public int DataLength { get; set; }

        [Benchmark]
        [ArgumentsSource(nameof(data))]
        public int FirstTry(int[] A)
        {
            // Total expected elements
            // [1..(N + 1)]
            var N = A.Length + 1;

            // From Maths, there is a concept calle Summation, where:
            // Sum of elements = (n*(n+1)) / 2
            // This way:
            var missing = (N * (N + 1)) / 2;

            // Now, from the expected sum, we subtract the existing elements.
            // The rest will be the missing number:
            for (int i = 0; i < A.Length; i++)
                missing -= A[i];

            return (int)missing;
        }

        [Benchmark]
        [ArgumentsSource(nameof(data))]
        public int SecondTry(int[] A)
        {
            // Total expected elements
            // [1..(N + 1)]
            var N = A.Length + 1;

            // From Maths, there is a concept calle Summation, where:
            // Sum of elements = (n*(n+1)) / 2
            // This way:
            long missing = (N * (N + 1)) / 2;

            // Now, from the expected sum, we subtract the existing elements.
            // The rest will be the missing number:
            for (int i = 0; i < A.Length; i++)
                missing -= A[i];

            return (int)missing;
        }

        [Benchmark]
        [ArgumentsSource(nameof(data))]
        public int ThirdTry(int[] A)
        {
            // Total expected elements
            // [1..(N + 1)]
            var N = A.Length + 1;

            // From Maths, there is a concept calle Summation, where:
            // Sum of elements = (n*(n+1)) / 2
            // This way:
            long missing = (N * (N + 1)) / 2;

            // Now, from the expected sum, we subtract the existing elements.
            // The rest will be the missing number:
            for (int i = 0; i < A.Length; i++)
            {
                long y = A[i];
                long borrow = 0;

                while (y != 0)
                {
                    borrow = (~missing) & y;
                    missing ^= y;
                    y = borrow << 1;
                }
            }
            return (int)missing;
        }
    }
}
