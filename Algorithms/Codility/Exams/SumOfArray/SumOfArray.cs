using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Disassemblers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Codility.Exams.SumOfArray
{
    [MemoryDiagnoser]
    [KeepBenchmarkFiles]
    [MarkdownExporterAttribute.GitHub]
    public class SumOfArray
    {
        [Benchmark(Description = "With array")]
        [Arguments(4)]
        [Arguments(3)]
        [Arguments(10)]
        [Arguments(2)]
        [Arguments(70)]
        [Arguments(20)]
        [Arguments(100)]
        public int[] FirstTry(int N)
        {
            Random random = new Random();

            // Validate N
            if (N < 1 || N > 100)
                throw new ArgumentOutOfRangeException("N must be between 1 and 100");

            // Create the array object, initialized with 0, with length N
            var result = new int[N];

            // keep the sum into a variable, so you don't have to loop again.
            int sum = 0;

            // loop through the positions to fill it
            // Skip the last position, so the last position grants the sum is 0.
            for (int i = 0; i < N - 1; i++)
            {
                int number;
                do
                {
                    // If sum > 0, adds a negative number
                    // If sum < 0, adds a positive number
                    // N*2 grants that you may have a wider range of numbers to sum/subtract. 
                    // This way, the sum is balanced all along the way
                    number = random.Next(0, N * 2) * (sum < 0 ? 1 : -1);
                }
                // Since its needed to be unique numbers, it's required to verify whether the number exists already
                while (isContained(result, number));

                // Fill up the array position
                result[i] = number;

                // Increment the sum 
                sum += number;
            }

            // Use the last position to grant the sum is 0.
            // Add the oposite of the sum so far.
            result[N - 1] = -sum;

            return result;
        }

        // Function for a Sequential Search
        // Time: O(n)
        // Use to look for existing numbers in the array
        private bool isContained(int[] vector, int element)
        {
            for (int i = 0; i < vector.Length; i++)
                if (vector[i] == element)
                    return true;

            return false;
        }


        [Benchmark(Description = "With HashSet")]
        [Arguments(4)]
        [Arguments(3)]
        [Arguments(10)]
        [Arguments(2)]
        [Arguments(70)]
        [Arguments(20)]
        [Arguments(100)]
        public int[] SecondTry(int N)
        {
            Random random = new Random();

            // Validate N
            if (N < 1 || N > 100)
                throw new ArgumentOutOfRangeException("N must be between 1 and 100");

            // Create the array object, initialized with 0, with length N
            var set = new HashSet<int>();
            
            // keep the sum into a variable, so you don't have to loop again.
            int sum = 0;

            // loop through the positions to fill it
            // Skip the last position, so the last position grants the sum is 0.
            for (int i = 0; i < N - 1; i++)
            {
                int number;
                do
                {
                    // If sum > 0, adds a negative number
                    // If sum < 0, adds a positive number
                    // N*2 grants that you may have a wider range of numbers to sum/subtract. 
                    // This way, the sum is balanced all along the way
                    number = random.Next(0, N * 2) * (sum < 0 ? 1 : -1);
                }
                // Since its needed to be unique numbers, it's required to verify whether the number exists already
                while (set.Contains(number));

                // Fill up the array position
                set.Add(number);

                // Increment the sum 
                sum += number;
            }

            // Use the last position to grant the sum is 0.
            // Add the oposite of the sum so far.
            set.Add(-sum);

            var result = new int[set.Count];
            set.CopyTo(result);
            return result;
        }
    }
}
