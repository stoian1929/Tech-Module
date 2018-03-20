using System;
using System.Linq;

namespace _6.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int k = arr.Length / 4;
            int[] leftUp = arr.Take(k).Reverse().ToArray();
            int[] rightUp = arr.Reverse().Take(k).ToArray();
            int[] up = leftUp.Concat(rightUp).ToArray();
            int[] down = arr.Skip(k).Take(2 * k).ToArray();

            int[] sum = up.Select((x, index) => x + down[index]).ToArray();

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
