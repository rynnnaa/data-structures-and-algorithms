﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }


        public List<object> ArrayList = new List<object>();

        public BinaryTree()
        {
            Root = null;
        }

        /// <summary>
        /// just create a binary tree here.Give it several nodes
        /// </summary>
        public void CreateTree()
        {
            Root = new Node(3);
            Root.Left = new Node(59);
            Root.Right = new Node(8);
            Root.Left.Left = new Node(99);
            Root.Left.Right = new Node(2);
            Root.Right.Left= new Node(19);
            Root.Right.Right = new Node(3);
        }




        public List<int> ArrList = new List<int>();

        public BinaryTree(Node node)
        {
            Root = node;
        }

        /// <summary>
        /// Starts with the root, will return root first before going to  it's children
        /// </summary>
        /// <param name="root"></param>
        /// <returns>An array</returns>
        /// 
        public object[] PreOrder(Node root)
        {
            try
            {
                ArrayList.Add(root.Value);

                if (root.Left != null)
                {
                    PreOrder(root.Left);
                }
                if (root.Right != null)
                {
                    PreOrder(root.Right);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return ArrayList.ToArray();
        }

        /// <summary>
        /// The will return nodes in order from left to right, returns root in between
        /// </summary>
        /// <param name="root"></param>
        /// <returns>An array</returns>
        public object[] InOrder(Node root)
        {
            if (root.Left != null)
            {
                InOrder(root.Left);
            }

            ArrayList.Add(root.Value);

            if (root.Right != null)
            {
                InOrder(root.Right);
            }

            return ArrayList.ToArray();
        }

        /// <summary>
        /// Returns Nodes left, then right then Root
        /// </summary>
        /// <param name="root"></param>
        /// <returns>An array</returns>
        /// 
        public object[] PostOrder(Node root)
        {
            if (root.Left != null)
            {
                PostOrder(root.Left);
            }

            if (root.Right != null)
            {
                PostOrder(root.Right);
            }

            ArrayList.Add(root.Value);

            return ArrayList.ToArray();
        }


    }
}
