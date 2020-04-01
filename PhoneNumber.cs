using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Exercises
{
    class PhoneNumber
    {
        public static void CreatePhoneNumber(int[] numbers)
        {
            /*Write a function that accepts an array of 10 integers (between 0 and 9), 
             * that returns a string of those numbers in the form of a phone number.*/
            if (numbers.Length > 10) Console.WriteLine("Too many numbers.");
            else
            {
                //Better way//
                //string pn = long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");

                //Brute Force//
                string phoneNumber = String.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}",
                    numbers[0], numbers[1], numbers[2],
                    numbers[3], numbers[4], numbers[5],
                    numbers[6], numbers[7], numbers[8], numbers[9]);

                Console.WriteLine(phoneNumber);
            }

        }
    }
}
