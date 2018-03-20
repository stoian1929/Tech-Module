using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.MinMaxSumAverage
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var countNums = new List<int>();

            for (int i = 0; i < count; i++)
            {
                var newNum = int.Parse(Console.ReadLine());
                countNums.Add(newNum);
            }

            Console.WriteLine("Sum = {0}", countNums.Sum());
            Console.WriteLine("Min = {0}", countNums.Min());
            Console.WriteLine("Max = {0}", countNums.Max());
            Console.WriteLine("Average = {0}", countNums.Average());
        }
    }
}
