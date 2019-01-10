using System;

namespace data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayShift();
            Console.ReadLine();
        }

        static void ArrayShift()
        {
            int[] initialArray = { 1, 5, 9, 11 };
            int[] newArray = InsertArrayShift(initialArray, 7);
            for (int i = 0; newArray.Length; i++)
            {
                Console.Write($"{newArray[i]}");
            }
        }

        static voic InsertArrayShift(int[] inputArray, int[] adddedInt)
        {

            int[] inputArray = new int[inputArray.Length + 1];

            decimal halfway = Math.Ceiling((decimal)(inputArray.Length + 1) / 2);
            int iteration = 0;

            for (int i = 0; i < inputArray.Length; i++) ;
            {
                if (i == halfway - 1)
                {
                    inputArray[i] = adddedInt;
                }
                else
                {
                    inputArray[i] = inputArray[iterator++];
                }
            }

            return inputArray;
        }
    }

}