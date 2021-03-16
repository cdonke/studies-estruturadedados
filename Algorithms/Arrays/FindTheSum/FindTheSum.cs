using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Arrays.FindTheSum
{
    [MemoryDiagnoser]
    [KeepBenchmarkFiles]
    [MarkdownExporterAttribute.GitHub]
    public class FindTheSum
    {
        public IEnumerable<object> Data()
        {
            yield return new object[] { new int[] { 8, 7, 2, 5, 3, 1 }, 10 };
        }

        //[Benchmark]
        [ArgumentsSource(nameof(Data))]
        public bool FirstTry(int[] A, int sum)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int x = i; x < A.Length; x++)
                {
                    if (A[i] + A[x] == sum)
                        return true;
                }
            }

            return false;
        }

        //[Benchmark]
        [ArgumentsSource(nameof(Data))]
        public bool SecondTry(int[] A, int sum)
        {
            Array.Sort(A);
            int left = 0, right = A.Length - 1;

            // If left and right crosses, means that we are out of combinations.
            while (left < right)
            {
                // If sum is higher, it means that the right part is too big, therefore, decrease it
                if (A[left] + A[right] > sum)
                {
                    right--;
                }
                // If sum is not high enough, increase the left part
                else if (A[left] + A[right] < sum)
                {
                    left++;
                }
                // Found it
                else
                {
                    return true;
                }
            }

            return false;
        }

        //[Benchmark]
        [ArgumentsSource(nameof(Data))]
        public bool ThirdTry(int[] A, int sum)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                // The difference between current and sum the value we are looking for
                // If it has already been added the dictionary, we take the value (= index) and have the correct value.
                if (map.ContainsKey(sum - A[i]))
                    return true;

                map.Add(A[i], i);
            }

            return false;
        }
    }
}
