using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Searching
{
    public class BinarySearch : ISearching
    {
        private readonly int[] _valores;
        public BinarySearch(int[] valores)
        {
            _valores = valores;
        }

        public int Search(int val)
        {
            int meio,
               inicio = 0,
               fim = _valores.Length - 1;

            while (inicio <= fim)
            {
                meio = (fim + inicio) / 2;      // acha posicao do meio
                if (_valores[meio] == val)       // se for ==, retorna a posicao
                    return meio;
                else if (val > _valores[meio])   // se o valor for maior q o valor da posicao do meio, move inicio para meio+,
                    inicio = meio + 1;
                else
                    fim = meio - 1;             // caso contrario, move o final para meio-1

            }

            return -1;
        }
    }
}
