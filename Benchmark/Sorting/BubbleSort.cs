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
    public class BubbleSort
    {
        private static int[] valores;
        private static Sort.Bubble bubbleSort = new Sort.Bubble();


        [GlobalSetup]
        public void Setup()
        {
            valores = Helpers.CriarAleatoriosUnicos(50000);
        }

        [Benchmark]
        public int[] XorBubbleSort() => bubbleSort.SortXOR(valores);

        [Benchmark]
        public int[] AuxBubbleSort() => bubbleSort.SortAux(valores);

    }
}
