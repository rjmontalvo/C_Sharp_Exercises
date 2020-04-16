using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Exercises
{
    class DirReduction
    {
        public static string[] dirReduc(string[] arr)
        {
            //If the array is empty return the arr.
            if (arr.Length == 0) return arr;
            
            //Create a stack
            Stack<string> myStack = new Stack<string>();

            //Iterate through array
            foreach (var dir in arr)
            {
                //If the stack is empty add the next value
                if (myStack.Count == 0)
                {
                    myStack.Push(dir);
                    continue;
                }

                string top = myStack.Peek();

                //If opposites are encountered, pop the stack
                if ((top == "NORTH" && dir == "SOUTH") ||
                    (top == "SOUTH" && dir == "NORTH") ||
                    (top == "EAST" && dir == "WEST") ||
                    (top == "WEST" && dir == "EAST"))
                    myStack.Pop();
                //Otherwise add to the stack
                else
                    myStack.Push(dir);
            }

            return myStack.Reverse().ToArray();

            #region Long way w/o additional methods
            //Without adding additional methods

            ////Create a string array the length of the stack
            //string[] result = new string[myStack.Count];

            ////Make a counter
            //int i = 0;

            ////Add each item in the stack to the array
            //foreach (var item in myStack)
            //{
            //    result[i] = item;
            //    i++;
            //}

            ////Reverse the array
            //for (int j = 0; j < result.Length/2; j++)
            //{
            //    string temp = result[j];
            //    result[j] = result[result.Length - 1 - j];
            //    result[result.Length - 1 - j] = temp;
            //}

            //return result;
            #endregion

        }
    }
}
