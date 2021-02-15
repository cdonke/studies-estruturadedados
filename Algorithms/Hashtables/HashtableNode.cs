using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Hashtables
{
    public class HashtableNode<T>
    {
        public HashtableNode(int tamanho, int key) : this(tamanho, key, default(T)) { }
        public HashtableNode(int tamanho, int key, T value)
        {
            _tamanho = tamanho;
            Key = key;
            Value = value;
        }

        private readonly int _tamanho;

        public int Key { get; set; }
        public T Value { get; set; }

        public HashtableNode<T> Proximo { get; set; }

        public override int GetHashCode()
        {
            return Key % _tamanho;
        }
    }
}
