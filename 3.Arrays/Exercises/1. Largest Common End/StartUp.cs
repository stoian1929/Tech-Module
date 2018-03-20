using System;
using System.Linq;

namespace _1.Largest_Common_End
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var arrayOne = Console.ReadLine().Split(' ').ToArray();
            var arrayTwo = Console.ReadLine().Split(' ').ToArray();
            var leftCounter = 0;
            var rightCounter = 0;
            for (int i = 0; i < Math.Min(arrayOne.Length,arrayTwo.Length); i++)
            {
                if (arrayOne[i] == arrayTwo[i])
                {
                    leftCounter++;
                }
                else { break; }
            }
            for (int i = 0; i < Math.Min(arrayTwo.Length, arrayOne.Length); i++)
            {
                if (arrayOne[arrayOne.Length - 1 - i] == arrayTwo[arrayTwo.Length - 1 - i])
                {
                    rightCounter++;
                }
                else { break; }
            }
            Console.WriteLine(Math.Max(leftCounter,rightCounter));
        }
    }
}
