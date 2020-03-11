using System;

namespace CSharp_Coding_Exercises
{
    class ReverseInteger
    {
        //Given a 32-bit signed integer, reverse digits of an integer.
        /*Note:
         * Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1].
         * For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.
        */
        public static int Reverse(int x)
        {
            long res = 0;

            while (x != 0)
            {
                res = (x % 10) + res * 10;
                x /= 10;
                if (res > Int32.MaxValue || res < Int32.MinValue)
                    return 0;
            }
            int y = Convert.ToInt32(res);
            return y;

        }

    }
}