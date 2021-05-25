using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text;

namespace Algorithms.Codility.Iterations.BinaryGap
{
    [MemoryDiagnoser]
    [KeepBenchmarkFiles]
    [MarkdownExporterAttribute.GitHub]
    public class BinaryGap
    {
        [ExcludeFromCodeCoverage]
        public IEnumerable<object[]> data()
        {
            yield return new object[] { new int[] { 1, 2, 147, 483, 647, 1041, 15, 32 } };
        }

        [Benchmark]
        [ArgumentsSource(nameof(data))]
        public int FirstTry(int N)
        {
            var NasBin = BinaryConverter.Convert(N);
            int lengthLongestGap = 0;
            int currentGap = 0;
            bool betweenOnes = false;


            int element = NasBin.Pop();
            while (NasBin.Count > 0)
            {
                if (betweenOnes && element == 0)
                    currentGap++;
                else
                {
                    betweenOnes = true;
                    if (currentGap > lengthLongestGap)
                        lengthLongestGap = currentGap;

                    currentGap = 0;
                }
                element = NasBin.Pop();
            }

            if (element == 1 && currentGap > lengthLongestGap)
                lengthLongestGap = currentGap;

            return lengthLongestGap;
        }

        [Benchmark]
        [ArgumentsSource(nameof(data))]
        public int SecondTry(int N)
        {
            int lengthLongestGap = 0;
            int currentGap = 0;
            bool betweenOnes = false;

            // N >> 1 will divide by 2 N
            while (N != 0)
            {
                /// 1 = 0x0001
                /// AND operator retuns 1 if both bytes are set...
                /// This way, it will return 1 only if 1st byte is 1, otherwise, 0
                if ((N & 1) == 1)
                {
                    if (currentGap > lengthLongestGap)
                        lengthLongestGap = currentGap;

                    // As we need the gap between 1's, we must flag whether an 1 passed
                    betweenOnes = true;
                    currentGap = 0;
                }
                else if (betweenOnes)
                {
                    currentGap++;
                }

                /// Shift bytes to the right in 1 position, this way:
                /// (9)1001 >> 1 = (4)0100
                /// (4)0100 >> 1 = (2)0010
                /// (2)0010 >> 1 = (1)0001
                /// (1)0001 >> 1 = (0)0000
                N >>= 1;
            }

            return lengthLongestGap;
        }
    }
}
