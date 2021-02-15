using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Stacks
{
    public class LinkedStack<T>
    {
        private Node<T> _inicio;

        public void Push(T elemento)
        {
            var node = new Node<T>(elemento);

            if (isEmpty)
                _inicio = node;
            else
            {
                var aux = _inicio;
                while (aux.Proximo != null)
                    aux = aux.Proximo;

                aux.Proximo = node;
            }

            Size++;
        }

        public IEnumerable<T> Pop(int n)
        {
            for (int i = 0; i < n; i++)
                yield return Pop();
        }

        public T Pop()
        {
            T valor = default(T);

            if (_inicio == null)
                throw new Exception("Lista vazia");
            else
            {
                var aux = _inicio;
                Node<T> previous = null;
                while (aux.Proximo != null)
                {
                    previous = aux;
                    aux = aux.Proximo;
                }

                valor = aux.Valor;
                if (previous != null)
                    previous.Proximo = null;
            }

            Size--;
            return valor;
        }

        public bool isEmpty => _inicio == null;
        public int Size { get; private set; }

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
