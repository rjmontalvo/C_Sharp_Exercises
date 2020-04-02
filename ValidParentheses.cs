using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Exercises
{
    class ValidParentheses
    {
        /*Write a function which makes a list of strings 
         * representing all of the ways you can balance n pairs of parentheses
         */

        public static bool IsValid(string s)
        {
            //Add each value opening parentheses to the stack
            //If you encounter the opposite parentheses remove it from the stack
            //If the stack is empty at the end it is valid
            if(String.IsNullOrEmpty(s)) return true;

            Stack<char> myStack = new Stack<char>();
            foreach (char l in s)
            {
                if(l=='('|| l == '[' || l == '{')
                {
                    myStack.Push(l);
                }
                //if its a closing parentheses
                //check whats on top of the stack
                //if its a matching opening parentheses
                //pop it from the stack
                //else return false
                else if(l == ')' || l == ']' || l == '}')
                {
                    if (myStack.Count==0) return false;
                    
                    char top = myStack.Peek();

                    if (top == '(' && l == ')')
                    {
                        myStack.Pop();
                    }
                    else if (top == '[' && l == ']')
                    {
                        myStack.Pop();
                    }
                    else if (top == '{' && l == '}')
                    {
                        myStack.Pop();
                    }
                    else
                        return false;
                }
            }
            return (myStack.Count == 0);
        }
    }
}
