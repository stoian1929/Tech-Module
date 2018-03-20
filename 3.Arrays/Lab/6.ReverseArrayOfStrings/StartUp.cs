using System;

namespace _6.ReverseArrayOfStrings
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            string[] reversed = new string[array.Length];

            Array.Reverse(array);

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
