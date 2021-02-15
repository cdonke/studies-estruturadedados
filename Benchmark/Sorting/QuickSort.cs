using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace Benchmark.Sorting
{
    [SimpleJob(RuntimeMoniker.Net48)]
    public class QuickSort
    {
        private int[] valoresRaw, valores;

        [GlobalSetup]
        public void Setup()
        {
            valoresRaw = Helpers.CriarAleatoriosUnicos(100_000);
        }

        [Benchmark]
        public int[] XorQuickSort()
        {
            var quickSort = new Sort.Quick(valores);
            return quickSort.SortXOR(0, valores.Length - 1);
        }

        [IterationSetup]
        public void IterationSetup() => valores = (int[])valoresRaw.Clone();

        [Benchmark]
        public int[] AuxQuickSort()
        {
            var quickSort = new Sort.Quick(valores);
            return quickSort.SortAux(0, valores.Length - 1);
        }
    }
}
