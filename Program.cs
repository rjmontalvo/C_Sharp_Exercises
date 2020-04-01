using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using GradeBook;

namespace CSharp_Coding_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Book book = new Book("My Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            Console.WriteLine(book.AvgGrade());
            Console.WriteLine(book.LowestGrade());
            Console.WriteLine(book.HighestGrade());
            */

            //ValidParentheses validParentheses = new ValidParentheses();
            //validParentheses.IsValid("()[]{}");

            //int[] vs = {0,0,1,1,1,2,2,3,3,4};
            //RemoveDups(vs);

            //Console.WriteLine(GrowingPlant(62, 59, 723));

            //   string[] arr = {"shark", "cow", "moose", "horse", "owl", "cat"};
            //   string[] arr2 = {"cow", "moose", "owl", "cat"};
            //   string[] result = WordDiff(arr, arr2);
            //   foreach (var item in result)
            //{
            //       Console.Write(item+ " ");
            //}
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            PhoneNumber.CreatePhoneNumber(nums);


        }
   //     public static void RemoveDups(int[] nums)
   //     {

   //         int dLength = nums.Distinct().Count();

   //         //iterate through the array
   //         for (int i = 0; i < nums.Length; i++)
			//{
   //             //if the values are the same 
   //             //store the second value and continue until a difference is found
   //             if(nums[i] == nums[i++])
   //             {
   //                 int temp = nums[i++];
   //                 for (int j = i++; j < nums.Length; j++)
			//        {
   //                     if(temp != nums[j])
   //                     {
   //                         int newVal = nums[j];
   //                         nums[i++] = newVal; 
   //                         break;
   //                     }

			//        }
   //             }


			//}

   //         //set the second value to the new number

  
   //         foreach (var item in nums)
   //         {
   //             Console.WriteLine(item);
   //         }
   //         Console.WriteLine(nums.Distinct().Count());
   //     }

        static public int GrowingPlant(int UpSpeed, int DownSpeed, int DesiredHeight)
        {
            int days = 0;
            int height = 0;
            while(height != DesiredHeight){
                height+=UpSpeed;
                days+=1;
                if(height == DesiredHeight){
                    break;
                }
                else
                    height-=DownSpeed;
            }
            return days;
        }

    }
}
