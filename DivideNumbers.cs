using System;



namespace Program
{
    class NumberDivision
    {
        //Create a program to divide 2 integers, without using "/" and "*"
        static void Main(string[] args)
        {
            Console.WriteLine("The firts is: ? ");
            int dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("The second is: ? ");
            int divisor = int.Parse(Console.ReadLine());
            int quotient = Operation(dividend, divisor);

            Console.WriteLine("The answer is: " + quotient);
        }

        static int Operation(int dividend, int divisor)
        {
            int initialValue = divisor;
            int result = 1;

            while (dividend != divisor)
            {
                divisor += initialValue;
                result++;
            }
            return result;
        }
    }
}