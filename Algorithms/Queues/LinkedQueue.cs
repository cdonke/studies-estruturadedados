using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Queues
{
    public class LinkedQueue<T>
    {
        private Node<T> _inicio;

        public void Enqueue(T elemento)
        {
            var node = new Node<T>(elemento);
            if (_inicio == null)
                _inicio = node;
            else
            {
                var nextNode = _inicio;
                while (nextNode.Proximo != null)
                    nextNode = nextNode.Proximo;

                nextNode.Proximo = node;
            }

            Tamanho++;
        }

        public T Dequeue()
        {
            if (_inicio == null)
                throw new Exception("Fila vazia");

            var valor = _inicio.Valor;
            _inicio = _inicio.Proximo;

            Tamanho--;

            return valor;
        }

        public int Tamanho { get; private set; }


        class Node<TElement>
        {
            public Node(TElement elemento)
            {
                Valor = elemento;
            }

            public TElement Valor { get; set; }
            public Node<TElement> Proximo { get; set; }
        }
    }
}
