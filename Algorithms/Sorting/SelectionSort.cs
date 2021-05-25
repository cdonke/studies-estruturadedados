using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Algorithms.Sorting
{
    [MemoryDiagnoser]
    [KeepBenchmarkFiles]
    [MarkdownExporterAttribute.GitHub]
    public class SelectionSort
    {
        private IEnumerable<int[]> _valores = new[] {
            Helpers.CriarAleatoriosUnicos(50000)
        };

        [ExcludeFromCodeCoverage]
        public IEnumerable<object[]> Valores()
        {
            yield return new object[] { Helpers.CriarAleatoriosUnicos(50000) };
        }

        [Benchmark]
        [ArgumentsSource(nameof(Valores))]
        public int[] SortWithXOR(int[] valores)
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

        [Benchmark]
        [ArgumentsSource(nameof(Valores))]
        public int[] ThirdTry(int[] valores)
        {
            for (int partIndex = valores.Length - 1; partIndex > 0; partIndex--)
            {
                int idxLargest = 0;
                // <= because we are not comparing neighbors.
                for (int i = 1; i <= partIndex; i++)
                {
                    if (valores[i] > valores[idxLargest])
                    {
                        idxLargest = i;
                    }
                }

                // Finally, we swap the last element with the largest found.
                var aux = valores[idxLargest];
                valores[idxLargest] = valores[partIndex];
                valores[partIndex] = aux;
            }

            return valores;
        }
    }
}
