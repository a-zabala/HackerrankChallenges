using System;
using System.Collections.Generic;
using System.Threading;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameNumber = new string[2];
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();


            Console.WriteLine("Enter the number of elements in array:");
            int howmany = Int32.Parse(Console.ReadLine());
            for (int i = 0; i <howmany; i++)
            {
                Console.WriteLine("Enter name and phone number separated by a space:");
                nameNumber = Console.ReadLine().Split();
                phoneBook.Add(nameNumber[0], nameNumber[1]);
                
            }
            Console.WriteLine("Enter a name to look for followed by enter.  When done entering names, press enter a final time");
            List<string> searchNames = new List<string>();
            int count = 0;
            string inputName = " ";
            do
            {
                    inputName = Console.ReadLine();
                    searchNames.Add(inputName);
                    count = count + 1;
                         }
            while (inputName != "");
            foreach (string item2 in searchNames)
            {
                if (phoneBook.ContainsKey(item2))
                {
                    string value2 = phoneBook.GetValueOrDefault(item2);
                    Console.WriteLine("{0}={1}", item2, value2);
                }
                else if (item2 != "")
                {
                    Console.WriteLine("Not found");
                }
            }

            /*foreach (KeyValuePair<string, string> entry in phoneBook)
            { 
            if (searchNames.Contains(entry.Key))
                {

                    Console.WriteLine("{0}={1}", entry.Key, entry.Value);

                }
            
            }*/

            /*foreach (string item in searchNames)
            {
                foreach (KeyValuePair<string,string> pair in phoneBook)
                {
                    if (pair.Key ==item)
                    {
                        Console.WriteLine("{0}={1}", pair.Key, pair.Value);
                    }


                }
                if (!phoneBook.ContainsKey(item))
                {
                    Console.WriteLine("Not found");
                }

            }*/
            Console.ReadLine();
        }
    }
}
