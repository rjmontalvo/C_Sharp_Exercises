using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using GradeBook;
using LinkedList;

namespace CSharp_Coding_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(SLLtoString.Stringify(new Node(1, new Node(2, new Node(3)))));

            SLinkedList<int> myList = new SLinkedList<int>();
            //myList.Add(8);
            //myList.Add(7);
            //myList.Add(1);
            //myList.Add(40);
            //myList.Append(175);
            //myList.Insert(35, 30);
            //myList.SortedInsert(myList.Head, 5);

            myList.Add(1);
            myList.Add(3);
            myList.Add(5);
            myList.Add(6);
            //Console.WriteLine(myList.ToString());

            Console.WriteLine(myList.Count(myList.Head, value => value %2 != 0));

            //Console.WriteLine(CaesarCipher.Rot13("C# is cool! 000"));

            //string[] a1 = { "arp", "live", "strong" };
            //string[] a2 = { "lively", "alive", "harp", "sharp", "armstrong" };
            //foreach (var word in WhichAreIn.inArray(a1, a2))
            //    Console.WriteLine(word);

            //Console.WriteLine(BouncingBall.bouncingBall(3, .66, 1.5));

            //Console.WriteLine(ValidParentheses.IsValid("]"));

            //string[] myarr = { "NORTH", "WEST", "SOUTH", "EAST" };
            //foreach (var item in DirReduction.dirReduc(myarr))
            //{
            //    Console.WriteLine(item);
            //}

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


            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //PhoneNumber.CreatePhoneNumber(nums);


            ////SPLIT STRING////
            //string[] vs = SplitString.Solution("abc");


            //foreach (var item in vs)
            //{
            //    Console.WriteLine(item);
            //}

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
