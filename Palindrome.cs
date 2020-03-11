using System;

namespace CSharp_Coding_Exercises
{
    class Palindrome
    {
        //Determine whether an integer is a palindrome. 
        //An integer is a palindrome when it reads the same backward as forward.
        public static bool IsPalindrome(int x)
        {
            int rev = 0;
            int num = x;
            if ((x < 0) || (x % 10 == 0 && x != 0))
                return false;
            else
                while (x > 0)
                {
                    rev = (rev * 10) + (x % 10);
                    x /= 10;
                }
            if (num == rev)
                return true;
            else
                return false;
        }
    }
}
