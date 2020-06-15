using System;

namespace MilitaryTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the time in 12Hr (hh:mm:ssAM or hh:mm:ssPM)");
            string s = Console.ReadLine();
            Console.WriteLine("The military time is:");
            string result = timeConversion(s);

            Console.WriteLine(result);
            Console.ReadLine();

        }

        static string timeConversion(string s)
        {
            string hour = s.Substring(0, 2);
            string ampm = s.Substring(8, 2);
            int numHour = Int32.Parse(hour);
            if (ampm == "AM") 
            {
                if (numHour == 12)
                {
                    string newHour = "00";
                    string milTime = newHour + s.Substring(2, 6);
                    return milTime;
                }
                else
                {
                    return s.Substring(0, 8);
                }
            }
            
            else
            {
                if (numHour ==12)
                {
                    return s.Substring(0, 8);

                }
                numHour = numHour + 12;
                string newHour = numHour.ToString() + s.Substring(2, 6);
                return newHour;
            }

        }
    }

}