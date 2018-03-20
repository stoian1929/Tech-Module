using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.CountRealsNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var inputNum = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            var dictionary = new SortedDictionary<double, int>();

            foreach (double num in inputNum)
            {
                if (dictionary.ContainsKey(num))
                {
                    dictionary[num] += 1;
                }
                else
                {
                    dictionary.Add(num, 1);
                }
            }

            foreach (var entry in dictionary)
            {
                Console.WriteLine("{0} -> {1}", entry.Key, entry.Value);
            }
        }
    }
}
