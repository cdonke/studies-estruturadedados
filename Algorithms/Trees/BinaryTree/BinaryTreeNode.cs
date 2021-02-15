using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Algorithms.Trees.BinaryTree
{
    [System.Diagnostics.DebuggerDisplay("Valor: {Valor}, Left: [{Left==null}], Right: [{Right==null}]")]
    public class BinaryTreeNode<T> : IComparable<BinaryTreeNode<T>>
        where T: IComparable<T>
    {
        public BinaryTreeNode(T valor)
        {
            Valor = valor;
        }

        public BinaryTreeNode<T> Left { get; set; } // Menor que a raiz
        public BinaryTreeNode<T> Right { get; set; } // Maior que a raiz

        public T Valor { get; set; }

        public int CompareTo([AllowNull] BinaryTreeNode<T> other)
        {
            return Valor.CompareTo(other.Valor);
        }
    }
}
