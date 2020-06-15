using System;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Still Working on this
            Console.WriteLine("What size would you like the staircase (btn 0-100)");
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
            Console.ReadLine();

            // Complete the staircase function below.
            static void staircase(int n)
            {
                string line = "";

                string staircase = "";


                for (int i = 0; i < n; i++)
                {

                    //Console.Write(" ");
                    line = line + " ";

                }
                Console.WriteLine(line + "#");




            }

        }
    }
}
