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
    public class InsertionSort
    {
        private static int[] valores;
        private static Sort.Insert insertSort = new Sort.Insert();


        [GlobalSetup]
        public void Setup()
        {
            valores = Helpers.CriarAleatoriosUnicos(50000);
        }

        [Benchmark]
        public int[] XorInsertSort() => insertSort.SortXOR(valores);

        [Benchmark]
        public int[] AuxInsertSort() => insertSort.SortAux(valores);
    }
}
