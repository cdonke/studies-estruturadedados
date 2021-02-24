using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Hashtables
{
    [MemoryDiagnoser]
    [KeepBenchmarkFiles]
    [MarkdownExporterAttribute.GitHub]
    public class HashTable<T>
    {
        private readonly int _tamanho;
        private readonly HashtableNode<T>[] _valores;
        private int _count;

        public HashTable() : this(100) { }
        public HashTable(int tamanho)
        {
            _tamanho = tamanho;
            _valores = new HashtableNode<T>[_tamanho];
        }

        public void Put(int Key, T Value)
        {
            var registro = new HashtableNode<T>(_tamanho, Key, Value);
            int posicao = registro.GetHashCode();
            if (_valores[posicao] == null)
            {
                _valores[posicao] = registro;
                _count++;
            }
            else
            {
                var reg = _valores[posicao];
                if (reg.Key == registro.Key) // se for o mesmo registro, substitui valor
                {
                    reg.Value = registro.Value;
                    return;
                }
                else
                {
                    while (reg.Proximo != null || reg.Key == registro.Key)
                    {
                        if (reg.Key == registro.Key) // se for o mesmo registro, substitui valor
                        {
                            reg.Value = registro.Value;
                            return;
                        }

                        reg = reg.Proximo;
                    }
                }
                _count++;
                reg.Proximo = registro; // novo registro na ultima posicao.
            }
        }

        public HashtableNode<T> Get(int key)
        {
            var registro = new HashtableNode<T>(_tamanho, key);
            var posicao = registro.GetHashCode();

            var resultado = _valores[posicao];
            while (resultado != null && resultado.Key != key)
                resultado = resultado.Proximo;

            return resultado;
        }

        public int Count => _count;

    }
}
