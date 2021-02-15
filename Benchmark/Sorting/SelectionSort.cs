using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark.Sorting
{
    [SimpleJob(RuntimeMoniker.Net48)]
    public class SelectionSort
    {
        private static int[] valores;
        private static Sort.Selection selectionSort = new Sort.Selection();


        [GlobalSetup]
        public void Setup()
        {
            valores = Helpers.CriarAleatoriosUnicos(50000);
        }

        [Benchmark]
        public int[] XorSelectionSort() => selectionSort.SortXOR(valores);

        [Benchmark]
        public int[] AuxSelectionSort() => selectionSort.SortAux(valores);
    }
}
