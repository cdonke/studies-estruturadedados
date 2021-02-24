using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace Algorithms.Codility.CountingElements.MaxCounters
{
    [MemoryDiagnoser]
    [KeepBenchmarkFiles]
    [MarkdownExporterAttribute.GitHub]
    public class MaxCounters
    {
        public IEnumerable<object[]> data()
        {
            return new[] {
                new object[] { 5, generateRandom(5) },
                new object[] { 10_000, generateRandom(10_000) },
                new object[] { 10_000, Enumerable.Repeat(10_001, 3000).ToArray() }
            };
        }
        private int[] generateRandom(int N)
        {
            Random r = new Random();
            List<int> range = new List<int>();

            for (int i = 0; i < 10_000; i++)
                range.Add(r.Next(1, N + 1));

            return range.ToArray();
        }

        [Benchmark]
        [ArgumentsSource(nameof(data))]
        public int[] FirstTry(int N, int[] A)
        {
            // N = total counters
            // A = Operations on them

            var counters = new int[N];

            // Keep the maximum counter value
            int maximumCounterValue = 0;

            for (int i = 0; i < A.Length; i++)
            {
                // if A[i] = N + 1 then operation K is max counter.
                if (A[i] == N + 1)
                {
                    // loop through all counters, setting the max value
                    for (int c = 0; c < counters.Length; c++)
                        counters[c] = maximumCounterValue;

                    // Continue loop
                    continue;
                }

                // Increment the counter 
                // Compares to the maximumCounterValue. 
                if (++counters[A[i] - 1] > maximumCounterValue)
                    // If greater, keep it to the variable
                    maximumCounterValue = counters[A[i] - 1];

            }

            return counters;
        }

        [Benchmark]
        [ArgumentsSource(nameof(data))]
        public int[] SecondTry(int N, int[] A)
        {
            // N = total counters
            // A = Operations on them

            var counters = new int[N];

            // Keep the maximum counter value
            int maximumCounterValue = 0;

            for (int i = 0; i < A.Length; i++)
            {
                // if A[i] = N + 1 then operation K is max counter.
                if (A[i] == N + 1)
                {
                    // loop through all counters, setting the max value
                    Array.Fill(counters, maximumCounterValue);

                    // Continue loop
                    continue;
                }

                // Increment the counter 
                // Compares to the maximumCounterValue. 
                if (++counters[A[i] - 1] > maximumCounterValue)
                    // If greater, keep it to the variable
                    maximumCounterValue = counters[A[i] - 1];

            }

            return counters;
        }

        [Benchmark]
        [ArgumentsSource(nameof(data))]
        public int[] ThirdTry(int N, int[] A)
        {
            // N = total counters
            // A = Operations on them

            var counters = new int[N];

            // Keep the maximum counter value
            int maximumCounterValue = 0,
                maxCounter = 0;

            for (int k = 0; k < A.Length; k++)
            {
                // When no to set max counters
                if (A[k] <= N)
                {
                    // if the current counter < maxCounter, set
                    if (counters[A[k] - 1] < maximumCounterValue)
                        counters[A[k] - 1] = maximumCounterValue;

                    // Increment the current counter
                    // Compare to maxCounterValue
                    if (++counters[A[k] - 1] > maximumCounterValue)
                        // If greater, keep it to the variable
                        maxCounter = counters[A[k] - 1];
                }
                else // When to set the max counters
                {
                    maximumCounterValue = maxCounter;
                }
            }

            //set all values to last reset value that was never explicitly changed after last reset
            for (int k = 0; k < N; k++)
            {
                if (counters[k] < maximumCounterValue)
                    counters[k] = maximumCounterValue;
            }

            return counters;
        }


        [Benchmark]
        [ArgumentsSource(nameof(data))]
        public int[] FourthTry(int N, int[] A)
        {
            // N = total counters
            // A = Operations on them

            var counters = new int[N];

            // Keep the maximum counter value
            int maximumCounterValue = 0,
                maxCounter = 0;

            for (int k = 0; k < A.Length; k++)
            {

                // When no to set max counters
                if (A[k] <= N)
                {
                    // If not set with the Max Value yet, set it
                    if (counters[A[k] - 1] < maximumCounterValue)
                        counters[A[k] - 1] = maximumCounterValue;

                    // Increment the current counter
                    // Compare to maxCounterValue
                    if (++counters[A[k] - 1] > maximumCounterValue)
                    {
                        // If greater, keep it to the variable
                        maxCounter = counters[A[k] - 1];
                    }
                }
                else if (A[k] == N + 1)
                {
                    maximumCounterValue = maxCounter;
                }
            }

            //set all values to last reset value that was never explicitly changed after last reset
            for (int k = 0; k < N; k++)
            {
                if (counters[k] < maximumCounterValue)
                    counters[k] = maximumCounterValue;
            }

            return counters;
        }
    }
}
