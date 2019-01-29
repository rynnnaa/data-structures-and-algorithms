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

            Console.WriteLine("========================");
            BinaryTree bb = new BinaryTree();
            bb.CreateTree();
            Console.WriteLine("========PreOrder=======");
            bb.PreOrder(bb.Root);
            Console.WriteLine("========inOrder=========");
            bb.InOrder(bb.Root);
            Console.WriteLine();
            Console.WriteLine("=====postOrder=======");
            bb.PostOrder(bb.Root);


        }



    }
}
