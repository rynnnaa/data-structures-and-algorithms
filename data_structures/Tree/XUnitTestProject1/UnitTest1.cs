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
    }
}
