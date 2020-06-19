using System;
using System.Net.Http.Headers;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to change to binary");
            int enteredNum = makeInt(Console.ReadLine());
            string binaryRep = makeBinary(enteredNum);
            Console.WriteLine("The binary representation of {0} is {1}", enteredNum, binaryRep);
            int consecutiveOnes = countConsecOnes(binaryRep);
            Console.WriteLine("The max number of consecutive ones in this binary number is {0}", consecutiveOnes);
            Console.ReadLine();
        }
        private static int makeInt(string input)
        {
            int i = int.Parse(input);
            return i;
        }
        private static string makeBinary(int enteredNum)
        {
            int remainder;
            string answer = "";
            while (enteredNum > 0)
            {
                remainder = enteredNum % 2;
                enteredNum = enteredNum / 2;
                answer = remainder.ToString() + answer;
            }

            return answer;
        }
        private static int countConsecOnes(string binaryRep)
        {
            int count = 0;
            int maxConsecutives = 0;
            char[] binaryArray = binaryRep.ToCharArray();
            for (int i = 0; i < binaryArray.Length; i++)
            {
                if (binaryArray[i].ToString() == "1")
                {
                    count = count + 1;
                    //Console.WriteLine(binaryArray[i] + " is a 1 so lets add one more to the consecutives:" + count);
                }
                if (count > maxConsecutives)
                {
                    Console.WriteLine(binaryArray[i] + " We got a 0... " + "so count goes to 0");

                    maxConsecutives = count;
                   // Console.WriteLine("What is the number of Consecutives " + maxConsecutives);
                }
                if (binaryArray[i].ToString() == "0")
                {
                    
                    count = 0;
                }
            }
            return maxConsecutives;
        }
    }
}
