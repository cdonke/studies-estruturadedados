using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Algorithms.Codility.BinaryGap.FirstTry
{
    [MemoryDiagnoser]
    public class Solution
    {
        [Benchmark]
        [Arguments(1)]
        [Arguments(2)]
        [Arguments(147)]
        [Arguments(483)]
        [Arguments(647)]
        [Arguments(1041)]
        [Arguments(15)]
        [Arguments(32)]
        public int solution(int N)
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

    }
}
