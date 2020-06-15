using System;
using System.Linq;

namespace SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in array:");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arrElements = new string[n];
            Console.WriteLine("Enter all of the elements separated by a space");
            string listChars = Console.ReadLine();
            arrElements = listChars.Split(" ");
            Array.Reverse(arrElements);
            Console.WriteLine("These are the elements reversed");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arrElements[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
