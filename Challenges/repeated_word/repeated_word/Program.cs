using System;
using System.Collections.Generic;

namespace repeated_word
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string book = "orange pear apple orange";

            RepeatedWord(book);

        }

        public static string RepeatedWord(string book)
        {
            HashSet<string> setOfWords = new HashSet<string>();

            string[] arr = book.Split();

            for (int i = 0; i < arr.Length; i++)
            {
                if (setOfWords.Contains(arr[i]))
                {
                    Console.Write(arr[i]);
                    return arr[i];
                }
                else
                {
                    setOfWords.Add(arr[i]);
                }
               
            }

            return "Not found";
        }
    }
}
