using System;
using System.Collections.Generic;

namespace Palindrome
{
    //Show if a user's word is or not a palindrome
    internal class Program
    {
        static void Main(string[] args)
        {
            string initialWord;
            string wordInverse = "";

            initialWord = Console.ReadLine();

            List<char> letters = new List<char>(initialWord);

            for (int i = 0; i < letters.Count; i++)
            {
                wordInverse += letters[letters.Count - 1 - i];
            }
            Console.WriteLine("Your word inverted is : " + wordInverse);
            if (wordInverse == initialWord) Console.WriteLine("Your word is palindrome");
            else Console.WriteLine("Your word isn't palindrome");
        }


    }
}
