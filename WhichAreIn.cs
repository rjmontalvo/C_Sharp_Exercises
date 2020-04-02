using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Exercises
{
    class WhichAreIn
    {
        /*Given two arrays of strings a1 and a2 
         * return a sorted array r in lexicographical order 
         * of the strings of a1 which are substrings of strings of a2.
         */
        public static string[] inArray(string[] array1, string[] array2)
        {
            //Create an array list to store the words
            List<string> result = new List<string>();         

            //Compare each word in array 1 to each word in array 2
            foreach (string word in array1)
            {
                foreach (string word2 in array2)
                {
                    //If the word1 is a substring of word2...
                    if (word2.Contains(word))
                    {
                        //...and it is not in the list, add it to the list
                        if (!result.Contains(word))
                            result.Add(word);
                    }

                }
            }
            //sort the list and return it as an array
            result.Sort();
            return result.ToArray();
        }
    }
}
