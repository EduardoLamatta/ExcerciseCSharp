using System;


namespace Program
{
    class HightestNumber
    {
        //Interaging an array one time find the largest number
        static void Main(string[] args)
        {
            List<double> numbersList = new List<double> { 10.5, 20.3, 15.7, 8.2, 30.1, 25.6, 12.9, 18.4, 22.0, 217.8};

            double number = 0;
            for (int i = 0; i < numbersList.Count - 1; i++)
            {
                if (numbersList[i] > number)
                {
                    number = numbersList[i];
                }
                else if (numbersList[i + 1] > number)
                {
                    number = numbersList[i + 1];
                }
            }

            Console.WriteLine(number);

        }
    }
}





