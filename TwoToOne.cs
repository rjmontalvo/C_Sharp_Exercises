using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Exercises
{
    class TwoToOne
    {
        /*Take 2 strings s1 and s2 including only letters from ato z. 
         * Return a new sorted string, the longest possible, containing distinct letters, each taken only once - coming from s1 or s2.*/
        public static string Longest(string s1, string s2)
        {
            //Create a character array of distinct letters from each string
            char[] distinct = s1.Distinct().Union(s2.Distinct()).ToArray<char>();
            
            //Sort the array
            Array.Sort(distinct);
            
            //Return all the characters in the form of a string
            return String.Concat(distinct);
        }

    }
}
