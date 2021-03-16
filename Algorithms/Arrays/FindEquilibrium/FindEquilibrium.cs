using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Algorithms.Arrays.FindEquilibrium
{
    [MemoryDiagnoser]
    [KeepBenchmarkFiles]
    [MarkdownExporterAttribute.GitHub]
    public class FindEquilibrium
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

        //[Benchmark]
        [Arguments(new int[] { 0, -3, 5, -4, -2, 3, 1, 0 })]
        //[ArgumentsSource(nameof(Data))]
        public int[] FirstTry(int[] A)
        {
            int[] left = new int[A.Length],
                right = new int[A.Length];

            int sumLeft = 0,
                sumRight = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sumLeft += A[i];
                sumRight += A[A.Length - i - 1];

                left[i] = sumLeft;
                right[A.Length - i - 1] = sumRight;
            }

            List<int> zeros = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (left[i] == right[i])
                    zeros.Add(i);
            }

            return zeros.ToArray();
        }
    }
}
