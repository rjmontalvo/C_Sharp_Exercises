using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Exercises
{
    class ExesAndOhs
    {
        /*Check to see if a string has the same amount of 'x's and 'o's. 
         * The method must return a boolean and be case insensitive. 
         * The string can contain any char.*/
        public static bool XO(string input)
        {
            return 
                input.ToLower().Where(i => i.Equals('x')).Count() == 
                input.ToLower().Where(i => i.Equals('o')).Count(); 
 
        }
    }
}
