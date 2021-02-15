using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Algorithms.Queues
{
    public class Queue
    {
        private readonly int[] _valores;
        private int _topo = -1;
        private int _current = -1;

        public Queue() : this(10) { }
        public Queue(int size)
        {
            _valores = new int[size];
        }

        public bool IsEmpty => _topo == -1;

        [ExcludeFromCodeCoverage]
        public bool IsFull => _topo == (_valores.Length - 1);

        public void Enqueue(int elemento)
            => _valores[++_topo] = elemento;

        public int Dequeue()
        {
            if (IsEmpty)
                throw new IndexOutOfRangeException();

            return _valores[++_current];
        }
    }
}
