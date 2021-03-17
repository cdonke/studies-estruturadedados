using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Algorithms.Leetcode.Easy.ReverseInteger
{
    [MemoryDiagnoser, KeepBenchmarkFiles, MarkdownExporterAttribute.GitHub]
    public class ReverseInteger
    {
        [ExcludeFromCodeCoverage]
        public IEnumerable<object[]> Data()
        {
            yield return new object[] { 123, 321 };
            yield return new object[] { -123, -321 };
            yield return new object[] { 120, 21 };
            yield return new object[] { 0, 0 };
            yield return new object[] { 1534236469, 0 };
            yield return new object[] { -2147483648, 0 };
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public int FirstTry(int x, int expected)
        {
            if (x <= Math.Pow(-2, 31) || x >= Math.Pow(2, 31) - 1)
                return 0;

            var sign = x < 0 ? -1 : 1;
            var originalNumber = Math.Abs(x).ToString().ToCharArray();
            var newNumber = new char[originalNumber.Length];

            for (int i = 0; i < newNumber.Length; i++)
            {
                newNumber[i] = originalNumber[originalNumber.Length - 1 - i];
            }

            var reversed = long.Parse(new string(newNumber)) * sign;
            if (reversed <= Math.Pow(-2, 31) || reversed >= Math.Pow(2, 31) - 1)
                return 0;

            return (int)reversed;
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public int SecondTry(int x, int expected)
        {
            var queue = new Queue<int>();
            while (x != 0)
            {
                queue.Enqueue(x % 10);
                x /= 10;
            }

            // -1 -2 -3 -4 -5 -6 
            long reversed = 0;
            for (int i = queue.Count - 1; i >= 0; i--)
            {
                long next = (queue.Dequeue() * (long)Math.Pow(10, i));
                if (reversed <= Math.Pow(-2, 31) + Math.Abs(next) || reversed >= Math.Pow(2, 31) - 1 - next)
                    return 0;

                reversed += next;
            }
            return (int)reversed;
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public int ThirdTry(int x, int expected)
        {
            int reversed = 0,
                pop = 0;
            while (x!= 0)
            {
                pop = x % 10;
                x /= 10;

                if (reversed > Int32.MaxValue / 10 || (reversed == Int32.MaxValue / 10 && pop > 7))
                    return 0;

                if (reversed < Int32.MinValue / 10 || (reversed == Int32.MinValue / 10 && pop < -8))
                    return 0;

                reversed = reversed * 10 + pop;
            }

            return reversed;
        }
    }
}
