using System;

namespace _2.ReverseArrayOfInt
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int j = array.Length - 1; j >= 0; j--)
            {
                Console.Write(array[j] + " ");
            }
        }
    }
}
