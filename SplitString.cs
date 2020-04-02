using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Exercises
{
    class SplitString
    {
        /*Complete the solution so that it splits the string into pairs of two characters. 
         *If the string contains an odd number of characters 
         * then it should replace the missing second character of the final pair with an underscore ('_').*/

        public static string[] Solution(string str)
        {
            //Compute the length of the array
            //If the length of the string is odd, append "_" to the end of the str
            if (str.Length%2 != 0)
            {
                str = str + "_";
            }

            //Create an array half the length of the string
            string[] result = new string[str.Length/2];
            
            //Create an index int
            int idx = 0;
            //Create a trail index for the iteration
            int j = 0;
            //For each pair, add it to the array
            for (int i = 1; i < str.Length; i+=2)
            {
                result[idx] = Convert.ToString(str[j]) + Convert.ToString(str[i]);
                idx++;
                j+=2;
            }
            return result;
        }
    }
}
