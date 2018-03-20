using System;
using System.Linq;

namespace _2.Rotate_and_Sum
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();//3 2 4 -1
            var k = int.Parse(Console.ReadLine());//2
            var rotated = new int[array.Length];
            for (int i = 0; i < k; i++)
            {
                var temp = array[array.Length - 1];
                for (int j =array.Length-1; j>0; j--)
                {
                    array[j] = array[j - 1];
                }
                array[0] = temp;
                for (int l = 0; l < array.Length; l++)
                {
                    rotated[l] += array[l];
                }
            }
            Console.WriteLine(string.Join(" ",rotated));
        }
    }
}
