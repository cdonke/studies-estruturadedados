using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Algorithms.Stacks
{
    public class StackWithArrays<T>
    {
        private readonly T[] _valores;
        private readonly int _maximo;
        private int primeiro;
        private int ultimo;
        private int total;

        public StackWithArrays() : this(100) { }
        public StackWithArrays(int maximo)
        {
            _maximo = maximo;
            _valores = new T[_maximo];
        }

        [ExcludeFromCodeCoverage]
        public bool IsEmpty => total == 0;

        [ExcludeFromCodeCoverage]
        public bool IsFull => total == _maximo;

        public void Push(T elemento)
        {
            _valores[ultimo++] = elemento;
            total++;
        }
        public T Pop()
        {
            var elemento = _valores[--ultimo];
            total--;

            return elemento;
        }

        public int Size => total;
    }
}
