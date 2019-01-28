﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }

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
        public int[] PreOrder(Node root)
        {
            ArrList.Add(root.Value);

            if (root.Left != null)
            {
                PreOrder(root.Left);
            }

            if (root.Right != null)
            {
                PreOrder(root.Right);
            }

            return ArrList.ToArray();
        }

        /// <summary>
        /// The will return nodes in order from left to right, returns root in between
        /// </summary>
        /// <param name="root"></param>
        /// <returns>An array</returns>
        public int[] InOrder(Node root)
        {
            if (root.Left != null)
            {
                InOrder(root.Left);
            }

            ArrList.Add(root.Value);

            if (root.Right != null)
            {
                InOrder(root.Right);
            }

            return ArrList.ToArray();
        }

        /// <summary>
        /// Returns Nodes left, then right then Root
        /// </summary>
        /// <param name="root"></param>
        /// <returns>An array</returns>
        /// 
        public int[] PostOrder(Node root)
        {
            if (root.Left != null)
            {
                PostOrder(root.Left);
            }

            if (root.Right != null)
            {
                PostOrder(root.Right);
            }

            ArrList.Add(root.Value);

            return ArrList.ToArray();
        }
    }
}
