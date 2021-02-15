using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Algorithms.Sorting
{
    [MemoryDiagnoser]
    public class SelectionSort
    {
        private IEnumerable<int[]> _valores = new[] {
#if !DEBUG
            Helpers.CriarAleatoriosUnicos(50000)
#else
            new int[0]
#endif
        };

        [ExcludeFromCodeCoverage]
        public IEnumerable<int[]> Valores => _valores;

        [Benchmark]
        [ArgumentsSource(nameof(Valores))]
        public int[] SortWithXOR(int[] valores)
        {
            for (int it = 0; it < valores.Length-1; it++)
            {
                int posMenor = it + 1;
                for (int i = it + 1; i < valores.Length; i++)
                {
                    if (valores[i] < valores[posMenor])
                        posMenor = i;
                }

                if (valores[posMenor] < valores[it])
                {
                    valores[it] ^= valores[posMenor];
                    valores[posMenor] ^= valores[it];
                    valores[it] ^= valores[posMenor];
                }
            }

            return valores;
        }

        [Benchmark]
        [ArgumentsSource(nameof(Valores))]
        public int[] SortWithAux(int[] valores)
        {
            for (int it = 0; it < valores.Length - 1; it++)
            {
                int posMenor = it + 1;
                for (int i = it + 1; i < valores.Length; i++)
                {
                    if (valores[i] < valores[posMenor])
                        posMenor = i;
                }

                if (valores[posMenor] < valores[it])
                {
                    var aux = valores[posMenor];
                    valores[posMenor] = valores[it];
                    valores[it] = aux;
                }
            }

            return valores;
        }
    }
}
