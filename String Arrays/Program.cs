using System;
using System.Diagnostics.Tracing;

namespace OddEvenCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many words?");
            string words = Console.ReadLine();
            int numWords = Convert.ToInt32(words);
            for (int i = 0; i < numWords; i++)
            {
                Console.WriteLine("Enter Word " +  (i+1));
                string S = Console.ReadLine();
                char[] charArr = S.ToCharArray();
                for (int j = 0; j <= charArr.Length - 1; j++)
                {
                    if ((j == 0) || (j % 2 == 0))
                    {
                        Console.Write(charArr[j]);
                    }
                    
                }
                Console.Write(" ");
                for (int j = 0; j <= charArr.Length - 1; j++)
                {
                    if (j % 2 != 0)
                    {
                        Console.Write(charArr[j]);
                    }

                }
                Console.WriteLine();

            }
            Console.ReadLine();

        }
    }
}

