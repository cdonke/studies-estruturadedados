using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Codility.Exams.SumOfDigits
{
    [MemoryDiagnoser]
    [KeepBenchmarkFiles]
    [MarkdownExporterAttribute.GitHub]
    public class SumOfDigits
    {
        [Benchmark]
        [Arguments(14)]
        [Arguments(10)]
        [Arguments(99)]
        public int FirstTry(int N)
        {
            int sumOfDigitsOfN = FindSumOfDigits(N);
            int newMinimumDigit = N + sumOfDigitsOfN;

            int finalSumOfDigits = FindSumOfDigits(newMinimumDigit);
            while (finalSumOfDigits < 2 * sumOfDigitsOfN)
            {
                finalSumOfDigits = FindSumOfDigits(++newMinimumDigit);
            }

            return newMinimumDigit;
        }
        int FindSumOfDigits(int N)
        {
            int sumOfDigits = 0;

            while (N > 0)
            {
                int part = N % 10;
                sumOfDigits += part;
                N /= 10;
            }

            return sumOfDigits;
        }

    }
}
