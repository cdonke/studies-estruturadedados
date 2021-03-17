using BenchmarkDotNet.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Leetcode.Easy.RomanToInteger
{
    [MemoryDiagnoser, KeepBenchmarkFiles, MarkdownExporterAttribute.GitHub]
    public class RomanToInteger
    {
        static Dictionary<char, int> _equivalences = Setup();

        public IEnumerable<object[]> Data()
        {
            yield return new object[] { "I", 1 };
            yield return new object[] { "V", 5 };
            yield return new object[] { "X", 10 };
            yield return new object[] { "III", 3 };
            yield return new object[] { "IV", 4 };
            yield return new object[] { "IX", 9 };
            yield return new object[] { "LVIII", 58 };
            yield return new object[] { "MCMXCIV", 1994 };
        }

        private static Dictionary<char, int> Setup()
        {
            _equivalences = new Dictionary<char, int>();
            _equivalences.Add('I', 1);
            _equivalences.Add('V', 5);
            _equivalences.Add('X', 10);
            _equivalences.Add('L', 50);
            _equivalences.Add('C', 100);
            _equivalences.Add('D', 500);
            _equivalences.Add('M', 1000);

            return _equivalences;
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public int FirstTry(string s, int expected)
        {
            if (s.Length == 1)
                return _equivalences[s[0]];

            int result = 0;

            for (int i = 0; i < s.Length-1; i++)
            {
                if (_equivalences[s[i]] < _equivalences[s[i + 1]])
                {
                    result -= _equivalences[s[i]];
                }
                else
                {
                    result += _equivalences[s[i]];
                }
            }
            result += _equivalences[s[s.Length - 1]];

            return result;
        }
    }
}
