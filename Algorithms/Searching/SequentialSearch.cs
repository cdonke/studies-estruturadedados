using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Searching
{
    public class SequentialSearch : ISearching
    {
        private readonly int[] _valores;
        public SequentialSearch(int[] valores)
        {
            _valores = valores;
        }

        public int Search(int val)
        {
            for (int i = 0; i < _valores.Length; i++)
            {
                if (_valores[i].Equals(val))
                    return i;
            }

            return -1;
        }
    }
}
