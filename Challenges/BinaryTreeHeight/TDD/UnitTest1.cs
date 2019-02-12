using System;
using Tree;
using BinaryTreeHeight;
using Xunit;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TDD
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindHeight()
        {
            Node node = new Node(1);
            node.Left = new Node(1);
            node.Left.Left = new Node(1);
            node.Left.Right = new Node(1);
            node.Right = new Node(1);
        }

        int height = Program.BinaryTreeHeight(node);
    }
}
