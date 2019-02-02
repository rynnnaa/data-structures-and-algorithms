using System;
using Tree.Classes;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bt = CreateTree();
            bool a = bt.Contains(38);
            Console.WriteLine("this contains 38");
            Console.WriteLine(a);
            bool b = bt.Contains(2);
            Console.WriteLine("this Does not contain  2");
            Console.WriteLine(b);

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



        }
    }
}
