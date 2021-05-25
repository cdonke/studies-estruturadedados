using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Algorithms.Sorting
{
    [MemoryDiagnoser]
    [KeepBenchmarkFiles]
    [MarkdownExporterAttribute.GitHub]
    public class QuickSort
    {
        private int[] _valores;

        public QuickSort()
        {
            _valores = Helpers.CriarAleatoriosUnicos(50_000);
        }

        [ExcludeFromCodeCoverage]
        public QuickSort(int[] valores)
        {
            _valores = valores;
        }

        [ExcludeFromCodeCoverage]
        public IEnumerable<object[]> Valores()
        {
            yield return new object[] { (int[])_valores.Clone() };
        }

        [Benchmark]
        [ArgumentsSource(nameof(Valores))]
        public int[] SortWithXOR(int[] valores)
        {
            _valores = valores;
            return SortWithXOR(0, _valores.Length - 1);
        }
        [Benchmark]
        [ArgumentsSource(nameof(Valores))]
        public int[] SortWithAux(int[] valores)
        {
            _valores = valores;
            return SortWithAux(0, _valores.Length - 1);
        }

        public int[] SortWithXOR(int inicio, int fim)
        {
            if (inicio > fim)
                return _valores;

            int pivo = partitionXOR(inicio, fim);
            SortWithXOR(inicio, pivo - 1);
            SortWithXOR(pivo + 1, fim);

            return _valores;
        }
        private int partitionXOR(int inicio, int fim)
        {
            int referencia = _valores[inicio], //pivo
                down = inicio,
                up = fim;

            while (down < up)
            {
                // encontrar numero maior q o pivo
                while (_valores[down] <= referencia && down < fim)
                    down++; //avanco para encontrar um valor maior

                while (_valores[up] > referencia)
                    up--;

                if (down < up) // nao se cruzaram, logo troca
                {
                    _valores[down] ^= _valores[up];
                    _valores[up] ^= _valores[down];
                    _valores[down] ^= _valores[up];
                }
            }

            _valores[inicio] = _valores[up];
            _valores[up] = referencia;

            return up; // up é quem denota onde está o pivo.
        }




        public int[] SortWithAux(int inicio, int fim)
        {
            if (inicio > fim)
                return _valores;

            int pivo = partitionAux(inicio, fim);
            SortWithAux(inicio, pivo - 1);
            SortWithAux(pivo + 1, fim);

            return _valores;
        }
        private int partitionAux(int inicio, int fim)
        {
            int referencia = _valores[inicio], //pivo
                down = inicio,
                up = fim;

            while (down < up)
            {
                // encontrar numero maior q o pivo
                while (_valores[down] <= referencia && down < fim)
                    down++; //avanco para encontrar um valor maior

                while (_valores[up] > referencia)
                    up--;

                if (down < up) // nao se cruzaram, logo troca
                {
                    var aux = _valores[down];
                    _valores[down] = _valores[up];
                    _valores[up] = aux;
                }
            }

            _valores[inicio] = _valores[up];
            _valores[up] = referencia;

            return up; // up é quem denota onde está o pivo.
        }

    }
}
