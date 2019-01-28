using System;
using System.Collections.Generic;
using System.Text;
using Tree.Classes;

namespace Tree.Classes
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree(Node node)
        {
            if (Root == null)
            {
                Root = node;
            }

            else
            {
                Add(Root, node.Value);
            }
        }

        /// <summary>
        /// Using greater than or less than logic to determine where to add the node
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns>node</returns>
        /// 
        public Node Add(Node root, int value)
        {

            Node node = new Node(value);

            if (root == null)
            {
                root = node;
                return node;
            }

            Node parent = null;

            while (root != null)
            {
                parent = root;

                if (value < root.Value)
                {
                    root = root.Left;
                }

                else
                {
                    root = root.Right;
                }
            }

            if (value <= parent.Value)
            {
                parent.Left = node;
            }
            else
            {
                parent.Right = node;
            }

            return node;
        }

     
    }
}
