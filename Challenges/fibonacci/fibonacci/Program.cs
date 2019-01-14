using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = fibonacci(9);
            Console.WriteLine(answer);
        }

        public static int fibonacci(int num) 
        {
            int Num1 = 0;
            int Num2 = 1;
            int FibAnswer = 0;

            for (int i = 2; i < num; i++)
            {
                FibAnswer = Num1 + Num2;
                Num1 = Num2;
                Num2 = FibAnswer;

            }

            return FibAnswer;
        }

    }
} 