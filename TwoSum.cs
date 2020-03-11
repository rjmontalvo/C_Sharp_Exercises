using System;

namespace CSharp_Coding_Exercises
{
    class AddTwo
    {
        //Given an array of integers, return indices of the two numbers such that they add up to a specific target.
        //You may assume that each input would have exactly one solution, and you may not use the same element twice.
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] answer = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = i + 1; k < nums.Length; k++)
                {
                    if (nums[k] + nums[i] == target)
                    {
                        answer[0] = i;
                        answer[1] = k;
                    }
                }
            }
            return answer;
        }
    }
}