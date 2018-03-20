using System;

namespace _5.RoundingNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] numbersArray = Console.ReadLine().Split(' ');
            double[] parsedNumbers = new double[numbersArray.Length];

            for (int i = 0; i < numbersArray.Length; i++)
            {
                parsedNumbers[i] = double.Parse(numbersArray[i]);
            }

            for (int j = 0; j < parsedNumbers.Length; j++)
            {
                Console.Write($"{parsedNumbers[j]} => ");
                parsedNumbers[j] = Math.Round(parsedNumbers[j], MidpointRounding.AwayFromZero);
                Console.WriteLine(parsedNumbers[j]);
            }
        }
    }
}
