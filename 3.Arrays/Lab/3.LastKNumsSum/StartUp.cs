using System;

namespace _3.LastKNumsSum
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] elements = new long[n];
            elements[0] = 1;
            for (int i = 1; i < n; i++)
            {
                for (int l = i - k; l < i; l++)
                {
                    if (l >= 0)
                    {
                        elements[i] += elements[l];
                    }
                }
            }
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{elements[j]} ");
            }
        }
    }
}
