using System;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input the size of the staircase the user wants
            Console.WriteLine("What size would you like the staircase (btn 0-100)");
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
            Console.ReadLine();

            // Prints the staircase of the inputted size
       
                static void staircase(int n)
                {
                    char hash = '#';
                    string blank = "";

                    for (int i = 0; i < n; i++)
                    {
                        string spaces = blank.PadLeft(n-i-1);
                        string hashes = blank.PadLeft(i+1, hash);
                        Console.WriteLine(spaces + hashes);
                    }

            }

        }
    }
}
