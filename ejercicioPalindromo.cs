using System;
using System.Collections.Generic;

namespace ejercicioPalindromo
{

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
          
            Console.WriteLine(wordInverse);


        }


    }
}
