using BenchmarkDotNet.Attributes;
using Microsoft.Diagnostics.Tracing.Parsers.ApplicationServer;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Algorithms.Codility.CountingElements.MissingInteger
{
    [MemoryDiagnoser]
    [KeepBenchmarkFiles]
    [MarkdownExporterAttribute.GitHub]
    public class MissingInteger
    {
        #region Data
        [ExcludeFromCodeCoverage]
        private object[] dataGenerator(int min, int max, int removed = Int32.MinValue)
        {
            Random r = new Random();

            var elements = Math.Abs(min) + Math.Abs(max);
            var numbers = Enumerable.Range(min, elements).ToArray();

            var skip = r.Next(1, elements / 2);
            var take = r.Next(skip, elements - skip);
            if (removed == Int32.MinValue)
                removed = numbers[r.Next(skip, skip + take - 1)];

            var range = numbers
                .Skip(skip)
                .Take(take)
                .Where(q => q != removed);

            var expected = removed;
            if (expected >= range.Max() || range.Contains(expected))
                expected = range.Max() + 1;

            if (range.Min() > 1 || range.Max() <= 0 || expected <= 0)
                expected = 1;

            var arrRange = range.OrderBy(q => r.Next()).ToArray();

            return new object[] { arrRange, expected };
        }
        [ExcludeFromCodeCoverage]
        private object[] largeData() => dataGenerator(-1_000_000, 1_000_000);
        private object[] largeDataNegativeRemoved() => dataGenerator(-1_000, 1_000, -1);
        [ExcludeFromCodeCoverage]
        private object[] negativeData() => dataGenerator(-1_000, -1);
        [ExcludeFromCodeCoverage]
        private object[] positiveData() => dataGenerator(0, 1000);
        [ExcludeFromCodeCoverage]
        private object[] positiveDataNonOne() => dataGenerator(5, 1000);
        private object[] positiveDataNonOneHigh() => dataGenerator(1000, 10_000);
        [ExcludeFromCodeCoverage]
        public IEnumerable<object[]> Data()
        {
            yield return largeData();
            yield return largeDataNegativeRemoved();
            yield return negativeData();
            yield return positiveData();
            yield return positiveDataNonOne();
            yield return positiveDataNonOneHigh();
        }
        #endregion

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        [ExcludeFromCodeCoverage]
        public int FirstTry(int[] A)
        {
            // Keep a list with the found numbers
            // Allocation problems?
            bool[] found = new bool[1_000_000];

            // Keep variable with minimum
            int min = Int32.MaxValue;

            for (int i = 0; i < A.Length; i++)
            {
                // Discard N <= 0
                if (A[i] > 0)
                {
                    // If number haven't been found yet
                    if (!found[A[i]])
                    {
                        // Set the number as found
                        found[A[i]] = true;
                    }

                    if (A[i] < min)
                        min = A[i];
                }
            }

            for (int i = 1; i < found.Length; i++)
            {
                if (!found[i])
                    return i;
            }

            return 1;
        }


        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public int SecondTry(int[] A)
        {
            // Sort 
            Array.Sort(A);


            // Validate
            if (A[0] > 1 || A[A.Length - 1] < 0)
                return 1;

            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] != A[i - 1] && A[i] != A[i - 1] + 1)
                {
                    if (A[i - 1] + 1 < 1)
                        return 1;

                    return A[i - 1] + 1;
                }
            }

            return A[A.Length - 1] + 1;
        }
    }
}
