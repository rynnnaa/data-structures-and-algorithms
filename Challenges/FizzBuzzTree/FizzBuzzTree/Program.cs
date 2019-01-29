using System;
using System.Collections.Generic;
using Tree;
using Tree.Classes;

namespace FizzBuzzTree
{
    class Program
    {
        static void Main(string[] args)
        {


        }
        /// <summary>
        /// Checks each node for divisibility by 3, or 5, and
        /// changes value to 'FizzBuzz', 'Fizz', or 'Buzz' (respectively) if yes
        /// </summary>
        /// <param name="node"> node to check </param>
        public static object[] FizzBuzz(Node root)
        {
            List<object> arrList = new List<object>();

            if (root.Value % 15 == 0)
            {
                root.Value = "FizzBuzz";
            }
            else if ((int)root.Value % 3 == 0)
            {
                root.Value = "Fizz";
            }
            else if ((int)root.Value % 5 == 0)
            {
                root.Value = "Buzz";
            }

            arrList.Add(root.Value);

            if (root.Left != null)
            {
                FizzBuzz(root.Left);
            }
            if (root.Right != null)
            {
                FizzBuzz(root.Right);
            }

            return arrList.ToArray();
        }
    }
    }
}
