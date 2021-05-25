using BenchmarkDotNet.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Codility.Exams.EvenWords
{
    [MemoryDiagnoser]
    [KeepBenchmarkFiles]
    [MarkdownExporterAttribute.GitHub]
    public class EvenWords
    {
        [Benchmark]
        [Arguments("acbcbba")]
        [Arguments("axxaxa")]
        [Arguments("aaaa")]
        public int FirstTry(string S)
        {
            int amountOfLettersToDelete = 0;

            // MAp the letters and its count into a hastable
            var table = new Hashtable();
            for (int i = 0; i < S.Length; i++)
            {
                if (table.ContainsKey(S[i]))
                {
                    int count = (int)table[S[i]];
                    table[S[i]] = ++count;
                }
                else
                {
                    table.Add(S[i], 1);
                }
            }

            // Find odd amount of letters
            foreach (var letter in table.Keys)
            {
                int count = (int)table[letter];
                if (count % 2 != 0)
                {
                    amountOfLettersToDelete++;
                }
            }

            return amountOfLettersToDelete;
        }
    }
}
