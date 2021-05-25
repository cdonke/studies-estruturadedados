using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Codility.Exams.CarFeatures
{
    [MemoryDiagnoser]
    [KeepBenchmarkFiles]
    [MarkdownExporterAttribute.GitHub]
    public class CarFeatures
    {
        public IEnumerable<object[]> Data() {
            yield return new object[] { new[] { "100", "110", "010", "011", "100" } };
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public int[] FirstTry(string[] cars)
        {
            var carFeats = new int[cars.Length];
            for (int car = 0; car < cars.Length; car++)
            {
                carFeats[car] = Convert.ToInt32(cars[car], 2);
            }

            int[] similarCars = new int[carFeats.Length];
            for (int i = 0; i < similarCars.Length - 1; i++)
            { // O(n^2)
                for (int j = i + 1; j < similarCars.Length; j++)
                {
                    var aux = carFeats[i] ^ carFeats[j];

                    var bin = Convert.ToString(aux, 2);
                    int changes = 0;
                    for (int c = 0; c < bin.Length; c++)
                    {
                        if (bin[c] == '1')
                            changes++;
                    }

                    if (changes <= 1)
                    {
                        similarCars[i]++;
                        similarCars[j]++;
                    }
                }
            }


            return similarCars;
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public int[] SecondTry(string[] cars)
        {
            var carFeats = new int[cars.Length];
            for (int car = 0; car < cars.Length; car++)
            {
                carFeats[car] = Convert.ToInt32(cars[car], 2);
            }

            int[] similarCars = new int[carFeats.Length];
            { // O(n log n)
            for (int i = 0; i < similarCars.Length - 1; i++)
                for (int j = i + 1; j < similarCars.Length; j++)
                {
                    var aux = carFeats[i] ^ carFeats[j];

                    int changes = 0;
                    while (aux > 0)
                    {
                        if ((aux & 1) == 1)
                        {
                            changes++;
                        }

                        aux >>= 1;
                    }

                    if (changes <= 1)
                    {
                        similarCars[i]++;
                        similarCars[j]++;
                    }
                }
            }


            return similarCars;
        }
    }
}
