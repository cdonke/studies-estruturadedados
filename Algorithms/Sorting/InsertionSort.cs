using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Algorithms.Sorting
{
    [MemoryDiagnoser]
    public class InsertionSort
    {
        private IEnumerable<int[]> _valores = new[] { Helpers.CriarAleatoriosUnicos(50000) };

        [ExcludeFromCodeCoverage]
        public IEnumerable<int[]> Valores => _valores;


        [Benchmark]
        [ArgumentsSource(nameof(Valores))]
        public int[] SortWithXOR(int[] vetores)
        {
            int valor;
            for (int i = 1; i < vetores.Length; i++)
            {
                valor = vetores[i];
                for (int x = i - 1; x >= 0 && vetores[x] > valor; x--)
                {
                    vetores[x + 1] ^= vetores[x];
                    vetores[x] ^= vetores[x + 1];
                    vetores[x + 1] ^= vetores[x];
                }
            }

            return vetores;
        }

        [Benchmark]
        [ArgumentsSource(nameof(Valores))]
        public int[] SortWithAux(int[] vetores)
        {
            int valor;
            for (int i = 1; i < vetores.Length; i++)
            {
                valor = vetores[i];
                for (int x = i - 1; x >= 0 && vetores[x] > valor; x--)
                {
                    var aux = vetores[x + 1];
                    vetores[x + 1] = vetores[x];
                    vetores[x] = aux;
                }
#if DEBUG
                foreach (var item in vetores)
                    Console.Write($"{item}  ");
                Console.WriteLine();
#endif
            }

            return vetores;
        }
    }
}
