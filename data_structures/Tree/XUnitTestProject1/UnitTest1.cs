using System;
using Xunit;
using Tree.Classes;
using Tree;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void PreOrderWorks()
        {
            //arrange
            Node node = new Node(1);
            BinaryTree tree = new BinaryTree(node);
            node.Left = new Node(2);
            node.Left.Left = new Node(3);
            node.Left.Right = new Node(4);
            node.Right = new Node(5);

            //act
            int[] result = tree.PreOrder(node);

            //assert
            Assert.Equal(1, result[0]);

        }

        [Fact]
        public void PreOrderWork2()
        {
            //arrange
            Node node = new Node(1);
            BinaryTree tree = new BinaryTree(node);
            node.Left = new Node(2);
            node.Left.Left = new Node(3);
            node.Left.Right = new Node(4);
            node.Right = new Node(5);

            //act
            int[] result = tree.PreOrder(node);

            //assert
            Assert.Equal(3, result[2]);
        }

        [Fact]
        public void PreOrderWorksAgain3()
        {
            //arrange
            Node node = new Node(1);
            BinaryTree tree = new BinaryTree(node);
            node.Left = new Node(2);
            node.Left.Left = new Node(3);
            node.Left.Right = new Node(4);
            node.Right = new Node(5);

            //act
            int[] result = tree.PreOrder(node);

            //assert
            Assert.Equal(5, result[4]);

        }
    }
}
