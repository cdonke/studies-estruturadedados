using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    [MemoryDiagnoser]
    public class BubbleSort
    {
        [Benchmark]
        [Arguments(new int[] { 25, 57, 48, Int32.MaxValue, Int32.MinValue, 37, 12, 92, 33 })]
        public int[] SortWithAux(int[] valores)
        {
            int aux;
            for (int x = 0; x < valores.Length; x++)
            {
                for (int i = 0; i < valores.Length - x - 1; i++)
                {
                    if (valores[i] > valores[i + 1])
                    {
                        aux = valores[i];
                        valores[i] = valores[i + 1];
                        valores[i + 1] = aux;
                    }
                }
            }

            return valores;
        }

        [Benchmark]
        [Arguments(new int[] { 25, 57, 48, Int32.MaxValue, Int32.MinValue, 37, 12, 92, 33 })]
        public int[] SortWithXOR(int[] valores)
        {
            for (int x = 0; x < valores.Length; x++)
            {
                for (int i = 0; i < valores.Length - x - 1; i++)
                {
                    if (valores[i] > valores[i + 1])
                    {
                        valores[i] ^= valores[i + 1];
                        valores[i + 1] ^= valores[i];
                        valores[i] ^= valores[i + 1];
                    }
                }
            }

            return valores;
        }
    }
}
