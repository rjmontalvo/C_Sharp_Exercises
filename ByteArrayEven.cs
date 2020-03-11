using System;


namespace CSharp_Coding_Exercises
{
    class ByteArray
    {
        public static bool ByteArrEven(byte[] array)
        {
            Array.Sort(array);
            if (array.Length % 2 > 0)
                return false;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] != array[i + 1])
                {
                    return false;
                }
                i++;
            }
            return true;
        }
    }
}