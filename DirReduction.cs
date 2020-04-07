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

                //If opposites are encountered 
                if ((top == "NORTH" && dir == "SOUTH") ||
                    (top == "SOUTH" && dir == "NORTH") ||
                    (top == "EAST" && dir == "WEST") ||
                    (top == "WEST" && dir == "EAST"))
                    myStack.Pop();
                else
                    myStack.Push(dir);
            }

            return myStack.Reverse().ToArray();

        }
    }
}
