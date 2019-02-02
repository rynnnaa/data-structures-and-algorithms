using System;
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

            BinaryTree tree = new BinaryTree(node);
            BinaryTree tree2 = new BinaryTree(node);
        }
    }
}
