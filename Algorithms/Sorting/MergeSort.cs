using BenchmarkDotNet.Attributes;
using Microsoft.Diagnostics.Tracing.Parsers.Kernel;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Algorithms.Sorting
{
    [MemoryDiagnoser]
    [KeepBenchmarkFiles]
    [MarkdownExporterAttribute.GitHub]
    public class MergeSort
    {
        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> Data()
        {
            yield return new[] { new int[] { 2, 4, 5, 7, 1, 2, 3, 6 } };
            yield return new[] { new int[] { 5, 2, 4, 7, 1, 3, 2, 6 } };
            yield return new[] { new int[] { 8, 7, 6, 5, 4, 3, 2, 1 } };
            yield return new[] { new int[] { 7, 6, 5, 4, 3, 2, 1 } };

            Random r = new Random();
            int last = 100;
            for (int i = 0; i < 10; i++)
            {
                int[] arr = new int[r.Next(last, 1000 + last)];
                last = arr.Length;
                for (int x = 0; x < last; x++)
                {
                    arr[x] = r.Next(-1000, 1000);
                }

                yield return new[] { arr };
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public int[] FirstTry(int[] A)
        {
            Merge_Sort_FirstTry(A, 0, A.Length - 1);
#if DEBUG
            PrintArray("=", A);
#endif

            return A;
        }
        private void Merge_Sort_FirstTry(int[] A, int start, int length)
        {
            if (start < length)
            {
                int middle = (start + length) / 2;
#if DEBUG
                PrintArray("L", A, start, middle);
                PrintArray("R", A, middle + 1, length);
#endif

                Merge_Sort_FirstTry(A, start, middle);
                Merge_Sort_FirstTry(A, middle + 1, length);
                Merge_FirstTry(A, start, middle, length);
            }
        }
        private void Merge_FirstTry(int[] A, int start, int middle, int length)
        {
            int i = 0,
                j = 0,
                n1 = middle - start + 1,
                n2 = length - middle;

            var L = new int[n1 + 1];
            var R = new int[n2 + 1];

            for (int x = 0; x < n1; x++)
                L[x] = A[start + x];
            for (int x = 0; x < n2; x++)
                R[x] = A[middle + 1 + x];

            L[n1] = Int32.MaxValue;
            R[n2] = Int32.MaxValue;

#if DEBUG
            PrintArray("L2", L);
            PrintArray("R2", R);
#endif

            for (int k = start; k <= length; k++)
            {
                if (L[i] <= R[j])
                {
                    A[k] = L[i];
                    i++;
                }
                else
                {
                    A[k] = R[j];
                    j++;
                }
            }

#if DEBUG
            PrintArray("", A);
#endif
        }




        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public int[] SecondTry(int[] A)
        {
            Merge_Sort_SecondTry(A, 0, A.Length - 1);
#if DEBUG
            PrintArray("=", A);
#endif

            return A;
        }
        private void Merge_Sort_SecondTry(int[] A, int start, int length)
        {
            if (start < length)
            {
                int middle = (start + length) / 2;
#if DEBUG
                PrintArray("L", A, start, middle);
                PrintArray("R", A, middle + 1, length);
#endif

                Merge_Sort_SecondTry(A, start, middle);
                Merge_Sort_SecondTry(A, middle + 1, length);
                Merge_SecondtTry(A, start, middle, length);
            }
        }
        private void Merge_SecondtTry(int[] A, int start, int middle, int length)
        {
            int startRight = middle + 1;

            if (A[middle] < A[startRight])
                return;

            while (start <= middle && startRight <= length)
            {
                if (A[start] <= A[startRight])
                {
                    start++;
                }
                else
                {
                    int value = A[startRight];
                    int index = startRight;

                    while(index != start)
                    {
                        A[index] = A[index - 1];
                        index--;
                    }
                    A[start] = value;

                    start++;
                    middle++;
                    startRight++;
                }
            }

#if DEBUG
            PrintArray("", A);
#endif
        }



        #region Auxiliary Functions
        [ExcludeFromCodeCoverage]
        [System.Diagnostics.DebuggerStepThrough]
        private void PrintArray(string l, int[] A)
        {
            Console.Write($"{l}: [");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i]);
                if (i < A.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine("]");

        }
        [ExcludeFromCodeCoverage]
        [System.Diagnostics.DebuggerStepThrough]
        private void PrintArray(string l, int[] A, int start, int length)
        {
            Console.Write($"{l}: [");
            for (int i = start; i <= length; i++)
            {
                Console.Write(A[i]);
                if (i < length)
                    Console.Write(", ");
            }
            Console.WriteLine("]");

        }
        #endregion
    }
}
