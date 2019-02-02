using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public List<object> ArrayList = new List<object>();

        public BinaryTree(Node node)
        {
            Root = node;
        }
        public BinaryTree()
        {

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
