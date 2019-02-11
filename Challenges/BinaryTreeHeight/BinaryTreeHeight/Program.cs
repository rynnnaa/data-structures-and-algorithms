using System;
using Tree;
using Tree.Classes;

namespace BinaryTreeHeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

       public static int BinaryTreeHeight(Node root)
        {
            int counter = 0;
            if (root == null)
            {
                return 0;
            }

            if (root != null)
            {
                counter = Math.Max(BinaryTreeHeight(root.Left), BinaryTreeHeight(root.Right)) + 1;

            }

            return counter;
        }
    }
}
