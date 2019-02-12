using System;
using Xunit;
using BinaryTreeHeight;
using Tree.Classes;
using Tree;

namespace XUnitTestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void FindHeightWorks()
        {
            //arrange
            Node node = new Node(1);
            node.Left = new Node(2);
            node.Left.Left = new Node(3);
            node.Left.Right = new Node(4);
            node.Right = new Node(5);

            //act
            node = 1;

            Assert.Equal(3, node);
        }
    }
}
