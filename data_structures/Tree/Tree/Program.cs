﻿using System;
using Tree.Classes;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(1);
            node.Left = new Node(2);
            node.Left.Left = new Node(3);
            node.Left.Right = new Node(4);
            node.Right = new Node(5);
            node.Right.Left = new Node(6);
            node.Right.Right = new Node(7);

            BinaryTree tree1 = new BinaryTree(node);
            BinaryTree tree2 = new BinaryTree(node);

            object[] result = tree1.PreOrder(node);
            foreach (object i in result)
            {
                Console.Write($"[{i}]");
            }

            Console.WriteLine();
            tree1.ArrayList.Clear();

            object[] resultIn = tree1.InOrder(node);
            foreach (object i in resultIn)
            {
                Console.Write($"[{i}]");
            }
            Console.WriteLine();

            object[] result2 = tree2.PostOrder(node);
            foreach (object i in result2)
            {
                Console.Write($"[{i}]");
            }

            Console.WriteLine();

            BinarySearchTree BSTree = new BinarySearchTree();
            BSTree.Add(BSTree.Root, 1);
            BSTree.Add(BSTree.Root, 2);
            BSTree.Add(BSTree.Root, 3);
            BSTree.Add(BSTree.Root, 4);
            BSTree.Add(BSTree.Root, 5);
            BSTree.Add(BSTree.Root, 6);


            BinaryTree BST = new BinaryTree(BSTree.Root);

            object[] result3 = BST.InOrder(BST.Root);
            foreach (object i in result3)
            {
                Console.Write($"[{i}]");
            }

            Console.WriteLine();

            Console.WriteLine($"Does 4 exist in the tree of 1-6? {BSTree.Contains(4)}");
            Console.WriteLine($"Does 7 exist in the tree of 1-6? {BSTree.Contains(7)}");

        }

    }
}
