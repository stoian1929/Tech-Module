﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ')
               .Select(double.Parse)
               .ToList();

            bool canContinue = true;

            while (canContinue)
            {
                canContinue = false;
                for (int i = 0; i <= numbers.Count - 2; i++)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        numbers[i + 1] = numbers[i] * 2;
                        numbers.Remove(numbers[i]);
                        canContinue = true;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
