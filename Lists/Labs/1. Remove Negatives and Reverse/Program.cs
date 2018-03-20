using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var reverseNums = new List<int>();
            var count = 0;
            for (int i = 0; i < inputNumbers.Count; i++)
            {
                if (inputNumbers[i] > 0)
                {
                    count=1;
                    reverseNums.Add(inputNumbers[i]);
                }
            }
            reverseNums.Reverse();
            if (count > 0)
            {
                Console.WriteLine(string.Join(" ", reverseNums));
            }
            else { Console.WriteLine("empty"); }
        }
    }
}
