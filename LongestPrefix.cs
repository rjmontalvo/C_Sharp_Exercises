using System;
using System.Collections.Generic;

class Prefix
{
    public static string LongestCommonPrefix(string[] strs)
    {
        //Determine if the array is empy or null and return ""
        if (strs == null || strs.Length == 0)
            return "";

        //Get the shortest word length in the array
        int minLength = Int32.MaxValue;
        foreach (string word in strs)
        {
            minLength = Math.Min(minLength, word.Length);
        }
        //Set the upper and lower bounds for the prefix
        int low = 1;
        int high = minLength;
        while (low <= high)
        {
            int middle = (low + high) / 2;
            //If the prefix is in all the strings increase it by 1
            if (isCommonPrefix(strs, middle))
                low = middle + 1;
            //Else reduce the prefix by 1
            else
                high = middle - 1;
        }
        return strs[0].Substring(0, (low + high) / 2);
    }

    //While the 
    private static bool isCommonPrefix (string[] strs, int len)
    {
        /*Create a substring from the first word in the array
         *Check each word in the array to see if it starts with the prefix*/
        string str1 = strs[0].Substring(0, len);
        for (int i = 1; i < strs.Length; i++)
        {
            if (!strs[i].StartsWith(str1))
                return false;            
        }
        return true;
    }
}