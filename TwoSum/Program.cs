using System;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the sample array and target
            int[] nums = new int[3] { 3, 2, 4 };
            int target = 6;

            //Creating the array to hold the indexes of the two correct elements that add up to the target sum
            int[] final = new int[2];
            final = TwoSum(nums, target);
            Console.WriteLine("The Indexes of elements of your array that have that sum are:" + final[0] + " " + final[1]);
            Console.ReadLine();


        }
        //This function takes an array and target sum and returns the  indexes of the two elements that add up to the target
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] answer = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {

                for (int j = 1; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            answer[0] = i;
                            answer[1] = j;
                            return answer;
                        }
                    }
                }


            }
            return answer;
        }
    }
}
