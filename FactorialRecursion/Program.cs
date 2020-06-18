using System;
using System.Security.Cryptography.X509Certificates;

namespace FactorialRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            
            while (cont)
            {
                Console.WriteLine("Enter a number between 1 and 12: ");                
                int n = Convert.ToInt32(Console.ReadLine());

                //Check for good input
                if ((n > 1) && (n < 13))
                {
                    int result = factorial(n);
                    //Output the result
                    Console.WriteLine("{0}! is {1}", n, result);
                    //Want another try?
                    Console.WriteLine("Press enter to do another, or 0 to exit");
                    string answer = Console.ReadLine();
                    //Exit if done
                    if (answer == "0")
                    {
                        cont = false;
                    }
                }
                //Bad input
                else { Console.WriteLine("Invalid Input, try again!"); }
            }
            

          
        }
        //Recursive function to calculate factorial 
        //Factorial multiplies all number from one to the number
        static int factorial(int n)
        {

            if (n <= 1)
            {

                return n;
            }
            else

            {
                return n * factorial(n-1);
            }

        }

    }
}
