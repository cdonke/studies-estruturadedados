﻿using BenchmarkDotNet.Attributes;
using Microsoft.Diagnostics.Tracing.Parsers.IIS_Trace;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Codility.Arrays.OddOccurrencesInArray
{
    [MemoryDiagnoser]
    public class OddOccurrencesInArray
    {
        public object[] data() =>
            new[] { new int[] { 9, 3, 9, 3, 9, 7, 9 } };

        [Benchmark]
        [ArgumentsSource(nameof(data))]
        public int FirstTry(int[] A)
        {
            int occurrences = 0;
            for (int i = 0; i < A.Length; i++)
            {
                for (int x = 0; x < A.Length; x++)
                {
                    if (A[x] == A[i])
                        occurrences++;
                }

                if (occurrences == 1)
                    return A[i];

                occurrences = 0;
            }

            return default;
        }

        [Benchmark]
        [ArgumentsSource(nameof(data))]
        public int SecondTry(int[] A)
        {
            int ret = 0;

            // Loop through the array
            for (int i = 0; i < A.Length; i++)
            {
                /// Each number acts like a flag
                /// Therefore, if you XOR the number into the variable, the first time it sets the flag on, 
                /// The second time, it will set the flag off.
                /// All numbers on the list are paired, except the one wanted. 
                /// That's why the only unpaired number is returned.
                ret = ret ^ A[i];
            }

            return ret;
        }
    }
}
