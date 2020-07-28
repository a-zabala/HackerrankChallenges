using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace SockPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How mant socks?");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the numbers");

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = sockMerchant(n, ar);
            Console.WriteLine("This many matches");
            Console.WriteLine(result);
            Console.ReadLine();
            static int sockMerchant(int n, int[] ar)
            {
                int match = 0;
                int count = 0;

                for (int i = 0; i<ar.Length; i++)
                {
                    for (int j = 0; j < ar.Length; i++)
                    {
                        if ((j + 1) > ar.Length) break;
                        if (ar[i] == ar[j +1]) count++;
                        if (count == 1)
                        {
                            
                            match++;
                            count = 0;
                            break;
                        }
                    }

                }
                return match;


            }
        }
    }
}
