using System;

namespace _05.Special_Numbers
{
    class StartUp
    {
        static void Main(string[] args)
        {

            var count = int.Parse(Console.ReadLine());

            var sum = 0;
            for (int i = 1; i <= count; i++)
            {
                sum = i / 10 + i % 10;
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine("{0} -> True", i);
                }
                else
                {
                    Console.WriteLine("{0} -> False", i);
                }
            }
        }
    }
}
