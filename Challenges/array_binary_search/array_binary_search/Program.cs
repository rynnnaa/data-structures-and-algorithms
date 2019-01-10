using System;

namespace array_binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] binaryArray = new int[] { 1, 2, 3, 4, 5, 6 };
            int searchKey = 3;
            Console.WriteLine(BinarySearch(binaryArray, searchKey));
        }

        public static int BinarySearch (int[] binaryArray, int searchKey)
        {
            int min = 0;
            int max = binaryArray.Length - 1;
        }
                
        }
    }
}
