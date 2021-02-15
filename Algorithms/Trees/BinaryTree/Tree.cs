using Microsoft.Diagnostics.Tracing.Parsers.IIS_Trace;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;

namespace Algorithms.Trees.BinaryTree
{
    public class Tree<T>
        where T : IComparable<T>
    {
        private BinaryTreeNode<T> _root;
        public BinaryTreeNode<T> Root
        {
            get => _root;
            set => _root = value;
        }

        public void Insert(T value
#if DEBUG
            , bool trace = true
#endif
            )
        {
            var node = new BinaryTreeNode<T>(value);
            if (IsEmpty)
            {
                Root = node;
#if DEBUG
                if (trace)
                    Console.WriteLine($"Elementro {node.Valor} é a raiz");
#endif
            }
            else
                Insert(Root, node
#if DEBUG
                    , trace
#endif
                    );
        }
        private void Insert(BinaryTreeNode<T> root, BinaryTreeNode<T> value
#if DEBUG
            , bool trace
#endif
            )
        {
            switch (value.CompareTo(root))
            {
                case -1:
                    if (root.Left == null)
                    {
                        root.Left = value;
#if DEBUG
                        if (trace)
                            Console.WriteLine($"Inseri elemento {value.Valor} à esquerda de {root.Valor}");
#endif
                    }
                    else
                        Insert(root.Left, value
#if DEBUG
                            , trace
#endif
                            );

                    break;

                case 1:
                    if (root.Right == null)
                    {
                        root.Right = value;
#if DEBUG
                        if (trace)
                            Console.WriteLine($"Inseri elemento {value.Valor} à direita de {root.Valor}");
#endif
                    }
                    else
                        Insert(root.Right, value
#if DEBUG
                            , trace
#endif
                            );

                    break;
            }
        }


        public void Remove(T value)
        {
            Console.WriteLine($"Removing element {value}");

            BinaryTreeNode<T> targetValue = new BinaryTreeNode<T>(value);
            BinaryTreeNode<T> previous = null;
            var current = Root;

            while (current != null)
            {
                switch (targetValue.CompareTo(current))
                {
                    case -1:
                        previous = current;
                        current = current.Left;
                        break;

                    case 1:
                        previous = current;
                        current = current.Right;
                        break;

                    case 0:
                        if (previous == null) // root node
                        {
                            previous = current;

                            BinaryTreeNode<T> aux = current.Left.Right;
                            while (aux.Right != null)
                                aux = aux.Right;

                            var currentValue = current.Valor;
                            current.Valor = aux.Valor;
                            aux.Valor = currentValue;

                            current = current.Left;
                        }
                        else
                        {
                            if (current.Left == null && current.Right == null) // leaf
                            {
                                var compare = targetValue.CompareTo(previous);
                                if (compare < 0)
                                    previous.Left = null;
                                else if (compare > 0)
                                    previous.Right = null;

                                current = null;
                            }
                            else if (current.Left != null && current.Right == null) // node, right null
                            {
                                previous.Left = current.Left;
                                current = null;
                            }
                            else if (current.Left == null && current.Right != null) // node, left null
                            {
                                previous.Left = current.Right;
                                current = null;
                            }
                            else // node, double descendents
                            {
                                BinaryTreeNode<T> aux = current.Right;
                                while (aux.Right != null)
                                    aux = aux.Right;

                                var currentValue = current.Valor;
                                current.Valor = aux.Valor;
                                aux.Valor = currentValue;

                                current.Right = null;
                            }
                        }
                        break;
                }
            }
        }



        //public void Remove(T value)
        //{
        //    Root = Remove(Root, value);
        //}
        //private BinaryTreeNode<T> Remove(BinaryTreeNode<T> parent, T value)
        //{
        //    switch (parent.Valor.CompareTo(value))
        //    {
        //        case 0:
        //            if (parent.Left == null && parent.Right == null)
        //                return null;
        //            else
        //            {
        //                if (parent.Left != null && parent.Right == null)
        //                    parent = parent.Left;
        //                else if (parent.Left == null && parent.Right != null)
        //                    parent = parent.Right;
        //                else
        //                {
        //                    var current = parent.Valor;
        //                    var aux = parent.Left;
        //                    while (aux.Right != null)
        //                        aux = aux.Right;

        //                    parent.Valor = aux.Valor;
        //                    aux.Valor = current;


        //                    Remove(value);
        //                }
        //            }

        //            break;

        //        case -1:
        //            if (parent.Right == null)
        //                return null;
        //            parent.Right = Remove(parent.Right, value);
        //            break;

        //        case 1:
        //            if (parent.Left == null)
        //                return null;
        //            parent.Left = Remove(parent.Left, value);
        //            break;
        //    }

        //    return parent;
        //}



        public T Find(T value)
        {
            BinaryTreeNode<T> targetValue = new BinaryTreeNode<T>(value);
            BinaryTreeNode<T> result = Root;
            while (result != null)
            {
                switch (targetValue.CompareTo(result))
                {
                    case -1:
                        result = result.Left;
                        break;
                    case 1:
                        result = result.Right;
                        break;
                    case 0:
                        return result.Valor;
                }
            }

            return default(T);
        }



        #region Print
        /// <summary>
        /// Prints root, than left nodes, than right nodes
        /// </summary>
        [ExcludeFromCodeCoverage]
        public void PrintPreOrder()
        {
            Console.WriteLine("Pre-Order:");
            Console.Write("\t");

            foreach (var item in ExportPreOrder())
                Console.Write(item.ToString().PadLeft(2, '0') + " ");
           
            Console.WriteLine();
        }       
    
        public IEnumerable<T> ExportPreOrder()
        {
            if (!IsEmpty)
                foreach (var item in ExportPreOrder(Root))
                    yield return item;
        }
        private IEnumerable<T> ExportPreOrder(BinaryTreeNode<T> node)
        {
            yield return node.Valor;

            if (node.Left != null)
                foreach (var item in ExportPreOrder(node.Left))
                    yield return item;

            if (node.Right != null)
                foreach (var item in ExportPreOrder(node.Right))
                    yield return item;
        }



        /// <summary>
        /// Prints left nodes, than root node, than right nodes
        /// </summary>
        [ExcludeFromCodeCoverage]
        public void PrintInOrder()
        {
            Console.WriteLine("In-Order:");
            Console.Write("\t");

            foreach (var item in ExportInOrder())
                Console.Write(item.ToString().PadLeft(2, '0') + " ");


            Console.WriteLine();
        }
        public IEnumerable<T> ExportInOrder()
        {
            if (!IsEmpty)
                foreach (var item in ExportInOrder(Root))
                    yield return item;
        }
        private IEnumerable<T> ExportInOrder(BinaryTreeNode<T> node)
        {

            if (node.Left != null)
                foreach (var item in ExportInOrder(node.Left))
                    yield return item;

            yield return node.Valor;

            if (node.Right != null)
                foreach (var item in ExportInOrder(node.Right))
                    yield return item;
        }


        /// <summary>
        /// Prints right nodes, right nodes, than root node
        /// </summary>
        [ExcludeFromCodeCoverage]
        public void PrintPostOrder()
        {
            Console.WriteLine("Post-Order:");
            Console.Write("\t");

            foreach (var item in ExportPostOrder())
                Console.Write(item.ToString().PadLeft(2, '0') + " ");

            Console.WriteLine();

        }
        public IEnumerable<T> ExportPostOrder()
        {
            if (!IsEmpty)
                foreach (var item in ExportPostOrder(Root))
                    yield return item;
        }
        private IEnumerable<T> ExportPostOrder(BinaryTreeNode<T> node)
        {
            if (node.Right != null)
                foreach (var item in ExportPostOrder(node.Right))
                    yield return item;

            if (node.Left != null)
                foreach (var item in ExportPostOrder(node.Left))
                    yield return item;



            yield return node.Valor;
        }
        #endregion



        public bool IsEmpty => Root == null;
    }
}
