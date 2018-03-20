using System;

namespace _03.Exact_Sum_of_Real_Numbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            decimal sum = 0m;
            for (int i = 0; i < number; i++)
            {
                var num = decimal.Parse(Console.ReadLine());
                sum = num + sum;
            }
            Console.WriteLine(sum);
        }
    }
}
