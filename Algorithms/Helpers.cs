using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Algorithms
{
    class Helpers
    {
        private static bool contains(int[] vetor, int valor)
        {
            for (int i = 0; i < vetor.Length; i++)
                if (vetor[i] == valor)
                    return true;

            return false;
        }

        [ExcludeFromCodeCoverage]
        public static int[] CriarAleatoriosUnicos(int tamanho)
        {
            Random r = new Random();
            int[] vetor = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                var valor = 0;
                do
                {
                    valor = r.Next(1, tamanho * 2);
                } while (contains(vetor, valor));

                vetor[i] = valor;
            }

            return vetor;
        }
    }
}
