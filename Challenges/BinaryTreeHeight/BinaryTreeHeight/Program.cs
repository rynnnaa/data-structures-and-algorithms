using System;
using Tree;
using Tree.Classes;

namespace BinaryTreeHeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(1);
            node.Left = new Node(1);
            node.Left.Left = new Node(1);
            node.Left.Right = new Node(1);
            node.Right = new Node(1);

            Console.WriteLine(BinaryTreeHeight(node));
        }
        /// <summary>
        /// returns the height of the binary tree by comparing left/right nodes
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
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
