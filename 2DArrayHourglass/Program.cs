using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Net;

namespace _2DArrayHourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Still Working on this
            Console.WriteLine("Enter the 6 lines of numbers");
            int[,] allNumbers = getIntArray();
            Console.WriteLine();
            printArray(allNumbers);
            int highestHourglassSum = calculateHourglass(allNumbers);
            Console.WriteLine("The highest hourglass sum is " + highestHourglassSum);
            Console.ReadLine();
        }
        public static int[,] getIntArray()
        {
            int[,] allNumbers = new int[6, 6];

            for (int i = 0; i < 6; i++)
            {
                // Get each line and split
                Console.WriteLine("Type in a line of 6 numbers");
                string[] line = (Console.ReadLine().Split(" "));
                for (int j = 0; j < 6; j++)
                {
                    allNumbers[i, j] = int.Parse(line[j]);

                }
            }
            return allNumbers;

        }
        public static void printArray(int[,] allNumbers)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(allNumbers[i, j] + " ");
                }
                Console.WriteLine();

            }

        }
        public static int calculateHourglass(int[,] allNumbers)
        {
            List<int> sums = new List<int>();
            int sumElement = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Sums: ");

                for (int j = 0; j < 4; j++)
                {
                    sumElement = allNumbers[i, j] + allNumbers[i +1, j ] + allNumbers[i+2, j]
                        + allNumbers[i + 1, j + 1]
                        + allNumbers[i, j+2] + allNumbers[i + 1, j + 2] + allNumbers[i + 2, j + 2];
                    sums.Add(sumElement);
                    Console.Write(sumElement + " ");
                }
                Console.WriteLine("next");
                
            }
            return findMaxSums(sums);
        }
        public static int findMaxSums(List<int> sums)
        {
            Console.WriteLine(sums.Count);
            sums.Sort();

            /*int maxSum = 0;
            for (int i = 0; i < 16; i++)
            {
                if (sums[i] > maxSum)
                {
                    maxSum = sums[i];
                }
            }*/
            return sums[15];

        }

    }
}
