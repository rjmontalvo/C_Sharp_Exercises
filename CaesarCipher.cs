using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Exercises
{
    class CaesarCipher
    {
		public static string Rot13(string message)
		{
			//create a character array with all the letters
			char[] abc = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
			string cipher = "";

			//Iterate through the string
			for (int i = 0; i < message.Length; i++)
			{
				//If the character is a letter, replace it
				if (char.IsLetter(message[i]))
				{
					//Find out if the index of that letter is greater than 14 in the alphabet
					int tempIdx = Array.IndexOf(abc, message.ToLower()[i]) + 13;

					//if that index is >= 14 then get the total and subtract from 26
					if (tempIdx >= 26)
					{
						//get the total and subtract 26
						tempIdx -= 26;
					}

					//replace the letter with the new letter from the given index
					if (char.IsUpper(message[i]))
					{
						cipher += Convert.ToString(abc[tempIdx]).ToUpper();
					}
					else
						cipher += abc[tempIdx];
				}
				//If the character is not a letter, add it to the string and continue
				else if (!char.IsLetter(message[i]))
				{
					//convert the char to a string and add to the cipher
					cipher += message[i];
				}
			}
			//return the message
			return cipher;
		}
	}
}
