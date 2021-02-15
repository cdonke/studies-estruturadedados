using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Stacks
{
    class DoubleLinkedList<T>
    {
        private Node<T> _inicio;

        public void Adicionar(T elemento)
        {
            var el = new Node<T>(elemento);
            if (_inicio == null)
            {
                _inicio = el;
            }
            else
            {
                var aux = _inicio;
                while (aux.Proximo != null)
                    aux = aux.Proximo;

                aux.Proximo = el;
                el.Anterior = aux;
            }

            Tamanho++;
        }

        public IEnumerable<T> Listar()
        {
            var aux = _inicio;
            do
            {
                yield return aux.Valor;
                aux = aux.Proximo;
            } while (aux != null);
        }

        public int Tamanho { get; private set; }



        class Node<TElement>
        {
            public Node() { }
            public Node(TElement elemento)
            {
                Valor = elemento;
            }

            public TElement Valor { get; set; }

            public Node<TElement> Anterior { get; set; }
            public Node<TElement> Proximo { get; set; }
        }
    }
}
