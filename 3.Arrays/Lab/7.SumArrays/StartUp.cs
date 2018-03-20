﻿using System;
using System.Linq;

namespace _7.SumArrays
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] arrayOne = Console.ReadLine()
                             .Split(' ')
                             .Select(int.Parse)
                             .ToArray();

            int[] arrayTwo = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            int[] sumArray = new int[Math.Max(arrayOne.Length, arrayTwo.Length)];

            for (int i = 0; i < sumArray.Length; i++)
            {
                sumArray[i] = arrayOne[i % arrayOne.Length] + arrayTwo[i % arrayTwo.Length];
            }

            foreach (int sum in sumArray)
            {
                Console.Write($"{sum} ");
            }
        }
    }
}
