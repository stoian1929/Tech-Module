using System;

namespace _5.FibonacciNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));
        }

        static long Fib(long n)
        {
            long oneStepBehind = 1;
            long currrentNumber = 0;
            for (int i = 0; i <= n; i++)
            {
                long tempLong = currrentNumber;
                currrentNumber += oneStepBehind;
                oneStepBehind = tempLong;
            }
            return currrentNumber;
        }
    }
}
