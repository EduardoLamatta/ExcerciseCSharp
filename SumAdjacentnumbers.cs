using System;

//Indicate the greatest sum of two consecutive numbers in an arrangement
namespace EjercicioSumaNumerosConsecutivosArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 12, 30, 43, 79, 12, 34, 1, 76, 54, 45};
            AddNumbers(numbers);
        }

        static void AddNumbers(int[] _numbers)
        {
            int[] sumNumbers = new int[_numbers.Length - 1];
            int[] numbersOrder = new int[sumNumbers.Length];
            int count = 0;

            for (int i = 0; i < _numbers.Length - 1; i++)
            {
                sumNumbers[i] = _numbers[i] + _numbers[i + 1];
            }

            foreach (int n in sumNumbers)
            {
                for (int i = 0; i < sumNumbers.Length; i++)
                {
                    if (n < sumNumbers[i]) count++;
                }
                numbersOrder[count] = n;
                count = 0;
            }
            Console.WriteLine("the hightest sum of two adjacent numbers is : " + numbersOrder[0]);
        }

    }
}
