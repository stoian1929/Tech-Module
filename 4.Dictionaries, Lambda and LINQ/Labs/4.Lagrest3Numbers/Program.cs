using System;
using System.Linq;

namespace _4.Lagrest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var largestNumber = numbers.OrderByDescending(x => x).Take(3).ToList();
            Console.WriteLine(string.Join(" ", largestNumber));
        }
    }
}
