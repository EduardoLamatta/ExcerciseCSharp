using System;
using System.Collections.Generic;

namespace ejercicioPalindromo
{
    //Indicar si la palabra escrita por el usuario es o no un palindromo
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
