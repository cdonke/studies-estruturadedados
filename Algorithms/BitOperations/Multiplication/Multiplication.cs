using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.BitOperations.Multiplication
{
    [MemoryDiagnoser]
    [KeepBenchmarkFiles]
    [MarkdownExporterAttribute.GitHub]
    public class Multiplication
    {
        public IEnumerable<object[]> Data()
        {
            yield return new object[] { -3, 6 };
            yield return new object[] { -3, -6 };
            yield return new object[] { 3, 6 };
            yield return new object[] { 61, 73 };
            yield return new object[] { 1034, 2343 };
            yield return new object[] { 0, Int32.MaxValue };
        }
        public IEnumerable<object[]> Data1()
        {
            foreach (var item in Data())
                yield return item;

            yield return new object[] { Int32.MinValue, Int32.MaxValue };
        }


        //[Benchmark]
        [ArgumentsSource(nameof(Data))]
        public long FirstTry(int A, int B)
        {
            if (A == 0 || B == 0)
                return 0;

            int minor = 0, major = 0;
            long result = 0;
            if (A < B)
            {
                minor = A;
                major = B;
            }
            else
            {
                minor = B;
                major = A;
            }

            if (minor > 0)
            {
                for (int i = 0; i < minor; i++)
                {
                    result += major;
                }
            }
            else
            {
                for (int i = minor; i < 0; i++)
                {
                    result -= major;
                }
            }


            return result;
        }

        //[Benchmark]
        [ArgumentsSource(nameof(Data1))]
        public long SecondTry(int A, int B)
        {
            if (A == 0 || B == 0)
                return 0;

            long result = 0;
            while (B != 0)
            {
                if ((B & 1) == 1)
                {
                    result += A;
                }

                A <<= 1;
                B >>= 1;
            }

            return result;
        }
    }
}
