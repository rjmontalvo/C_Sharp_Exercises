using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Exercises
{
    class StringArrayDiff
    {
        public string[] WordDiff(string[] arr, string[] arr2)
        {
            /////EASY WAY/////
            //return  arr.Except(arr2).Union(arr2.Except(arr)).ToArray();

            /////HARD WAY////
            
            //Create a dictionary
            Dictionary<string, int> result = new Dictionary<string, int>();

            //Iterate through the first and add words to the dictionary with a value of 1
            foreach (var word in arr)
            {
                if (!result.ContainsKey(word))
                {
                    result.Add(word, 1);
                }
                else
                    result[word]++;
            }

            //Iterate through the second one, if its already in the dictionary, increment by 1
            foreach (var word in arr2)
            {
                if (!result.ContainsKey(word))
                {
                    result.Add(word, 1);
                }
                else
                    result[word]++;
            }

            //Find the keys with values less than 2
            var newresult =
                from w in result
                where (w.Value < 2)
                select w.Key;

            //lambda result.Where(w => w.Value <2).Select(c => c.Key);

            //Return the result as an array
            return newresult.ToArray();
        }

    }
}
