using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
////BST представляет собой структуру данных, где каждый узел содержит ключ (значение) и два дочерних узла - левый и правый.
//Узлы упорядочены таким образом,что для каждого узла все значения в левом поддереве меньше его значения,
//а значения в правом поддереве больше.
namespace treebin
{
    public class BinarySearchTree //Класс BinarySearchTree определяет само дерево BST. Внутри класса есть вложенный класс Node,
                                  //который представляет каждый узел дерева. Каждый узел имеет целочисленное значение Data и ссылки
                                  //на левый и правый дочерние узлы.
    {
        public class Node
        {
            public int Data;
            public Node Left;
            public Node Right;

            public Node(int data)
            {
                Data = data;
                Left = null;
                Right = null;
            }
        }

        public Node Root;

        public BinarySearchTree()
        {
            Root = null;
        }

        public void Insert(int data)
        {
            Node newNode = new Node(data);

            if (Root == null)
            {
                Root = newNode;
                return;
            }

            Node current = Root;
            Node parent = null;

            while (true)
            {
                parent = current;

                if (data < current.Data)
                {
                    current = current.Left;

                    if (current == null)
                    {
                        parent.Left = newNode;
                        return;
                    }
                }
                else
                {
                    current = current.Right;

                    if (current == null)
                    {
                        parent.Right = newNode;
                        return;
                    }
                }
            }
        }

        public void InorderTraversal(Node node) //Мы сначала рекурсивно обходим левое поддерево, вызывая InorderTraversal для левого
                                                //дочернего узла.
        {
            if (node != null)
            {
                InorderTraversal(node.Left);
                Console.Write(node.Data + " ");
                InorderTraversal(node.Right);
            }
        }

        public void PreorderTraversal(Node node) //Обход в порядке "корень-левый-правый" (Preorder Traversal):
                                                 //Мы сначала выводим значение(Data) текущего узла.
                                                 //Затем рекурсивно обходим левое поддерево, вызывая PreorderTraversal
                                                 //для левого дочернего узла.
        {
            if (node != null)
            {
                Console.Write(node.Data + " ");
                PreorderTraversal(node.Left);
                PreorderTraversal(node.Right);
            }
        }

        public void PostorderTraversal(Node node) //Обход в порядке "левый-правый-корень" (Postorder Traversal):
                                                  //Мы сначала рекурсивно обходим левое поддерево, вызывая PostorderTraversal
                                                  //для левого дочернего узла.Затем рекурсивно обходим правое поддерево, вызывая
                                                  //PostorderTraversal для правого дочернего узла.И, наконец, выводим значение (Data)
                                                  //текущего узла.
        {
            if (node != null)
            {
                PostorderTraversal(node.Left);
                PostorderTraversal(node.Right);
                Console.Write(node.Data + " ");
            }
        }
    }
}
