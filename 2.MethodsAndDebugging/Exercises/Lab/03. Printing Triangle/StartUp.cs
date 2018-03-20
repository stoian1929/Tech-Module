using System;

namespace _03.Printing_Triangle
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                PrintLine(1, i);
            }
            for (int i = n - 1; i >= 0; i--)
            {
                PrintLine(1, i);
            }
        }
        public static void PrintLine(int start, int end)
        {
            for (int row = start; row <= end; row++)
            {
                Console.Write(row + " ");
            }
            Console.WriteLine();
        }
    }
}
