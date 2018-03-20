using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();

            Array.Sort(numbers);

            Dictionary<int, int> numbersDictionary = new Dictionary<int, int>();

            foreach (int num in numbers)
            {
                if (!numbersDictionary.ContainsKey(num))
                {
                    numbersDictionary.Add(num, 1);
                }
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbersDictionary[numbers[i]] += 1;
                }
            }

            foreach (KeyValuePair<int, int> entry in numbersDictionary)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }
    }
}
