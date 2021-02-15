using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Algorithms.Stacks
{
    public class LinkedStack_SecondTry<T>
    {
        private Node<T> _bottom;
        private Node<T> _top;

        public void Push(T elemento)
        {
            var temp = _top;
            _top = new Node<T>(elemento);
            _top.Proximo = temp;

            if (temp == null)
                _bottom = _top;

            Length++;
        }

        public IEnumerable<T> Pop(int n)
        {
            for (int i = 0; i < n; i++)
                yield return Pop();
        }

        public T Pop()
        {
            T valor = default(T);

            if (_bottom == null)
                throw new Exception("Lista vazia");

            valor = _top.Valor;
            _top = _top.Proximo;

            Length--;
            return valor;
        }

        [ExcludeFromCodeCoverage]
        public bool isEmpty => _bottom == null;
        public int Length { get; private set; }

        class Node<TInput>
        {
            public Node(TInput elemento)
            {
                Valor = elemento;
            }
            public TInput Valor { get; set; }
            public Node<TInput> Proximo { get; set; }
        }

    }
}
