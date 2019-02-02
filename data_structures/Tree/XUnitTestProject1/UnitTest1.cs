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
            object[] result = tree.PreOrder(node);

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
            object [] result = tree.PreOrder(node);

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
            object[] result = tree.PreOrder(node);

            //assert
            Assert.Equal(5, result[4]);

        }

        [Fact]
        public void InOrderWorks()
        {
            //arrange
            Node node = new Node(1);
            BinaryTree tree = new BinaryTree(node);
            node.Left = new Node(2);
            node.Left.Left = new Node(3);
            node.Left.Right = new Node(4);
            node.Right = new Node(5);

            //act
            object[] result = tree.InOrder(node);

            //assert
            Assert.Equal(3, result[0]);

        }

        [Fact]
        public void InOrderWorks2()
        {
            //arrange
            Node node = new Node(1);
            BinaryTree tree = new BinaryTree(node);
            node.Left = new Node(2);
            node.Left.Left = new Node(3);
            node.Left.Right = new Node(4);
            node.Right = new Node(5);

            //act
            object[] result = tree.InOrder(node);

            //assert
            Assert.Equal(4, result[2]);

        }

        [Fact]
        public void InOrderWorks3()
        {
            //arrange
            Node node = new Node(1);
            BinaryTree tree = new BinaryTree(node);
            node.Left = new Node(2);
            node.Left.Left = new Node(3);
            node.Left.Right = new Node(4);
            node.Right = new Node(5);

            //act
            object[] result = tree.InOrder(node);

            //assert
            Assert.Equal(5, result[4]);

        }

        [Fact]
        public void PostOrderWorks()
        {
            //arrange
            Node node = new Node(1);
            BinaryTree tree = new BinaryTree(node);
            node.Left = new Node(2);
            node.Left.Left = new Node(3);
            node.Left.Right = new Node(4);
            node.Right = new Node(5);

            //act
            object[] result = tree.PostOrder(node);

            //assert
            Assert.Equal(3, result[0]);

        }

        [Fact]
        public void PostOrderWorks2()
        {
            //arrange
            Node node = new Node(1);
            BinaryTree tree = new BinaryTree(node);
            node.Left = new Node(2);
            node.Left.Left = new Node(3);
            node.Left.Right = new Node(4);
            node.Right = new Node(5);

            //act
            object[] result = tree.PostOrder(node);

            //assert
            Assert.Equal(4, result[1]);

        }

        [Fact]
        public void PostOrderWorksAgain3()
        {
            //arrange
            Node node = new Node(1);
            BinaryTree tree = new BinaryTree(node);
            node.Left = new Node(2);
            node.Left.Left = new Node(3);
            node.Left.Right = new Node(4);
            node.Right = new Node(5);

            //act
            object[] result = tree.PostOrder(node);

            //assert
            Assert.Equal(5, result[3]);

        }

        [Fact]
        public void addBetween1()
        {
            //arrange
            Node node = new Node(3);
            node.Left = new Node(1);
            BinarySearchTree tree = new BinarySearchTree(node);

            //act
            tree.Add(node, 2);

            //assert
            Assert.Equal(2, tree.Root.Left.Right.Value);

        }

        [Fact]
        public void addBetween2()
        {
            //arrange
            Node node = new Node(4);
            node.Left = new Node(1);
            BinarySearchTree tree = new BinarySearchTree(node);

            //act
            tree.Add(node, 3);

            //assert
            Assert.Equal(3, tree.Root.Left.Right.Value);

        }

        [Fact]
        public void addBetween3()
        {
            //arrange
            Node node = new Node(10);
            node.Left = new Node(4);
            BinarySearchTree tree = new BinarySearchTree(node);

            //act
            tree.Add(node, 7);

            //assert
            Assert.Equal(7, tree.Root.Left.Right.Value);

        }

        [Fact]
        public void ContainsWorks()
        {
            //arrange
            Node node = new Node(1);
            BinarySearchTree tree = new BinarySearchTree(node);
            tree.Add(tree.Root, 2);
            tree.Add(tree.Root, 3);
            tree.Add(tree.Root, 4);

            //act
            bool result = tree.Contains(2);

            //assert
            Assert.True(result);

        }

        [Fact]
        public void ContainsWorks2()
        {
            //arrange
            Node node = new Node(1);
            BinarySearchTree tree = new BinarySearchTree(node);
            tree.Add(tree.Root, 2);
            tree.Add(tree.Root, 3);
            tree.Add(tree.Root, 4);

            //act
            bool result = tree.Contains(3);

            //assert
            Assert.True(result);

        }

        [Fact]
        public void NotContainsWorks()
        {
            //arrange
            Node node = new Node(1);
            BinarySearchTree tree = new BinarySearchTree(node);
            tree.Add(tree.Root, 2);
            tree.Add(tree.Root, 3);
            tree.Add(tree.Root, 4);

            //act
            bool result = tree.Contains(14);

            //assert
            Assert.False(result);

        }
    }
}