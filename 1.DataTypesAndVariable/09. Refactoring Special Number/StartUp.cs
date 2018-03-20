using System;

namespace ConsoleApplication1
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int sum = 0;
                int tempNum = i;
                while (tempNum > 0)
                {
                    int digit = tempNum % 10;
                    tempNum /= 10;
                    sum += digit;
                }
                bool checker = false;

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    checker = true;
                }

                Console.WriteLine("{0} -> {1}", i, checker);
            }
        }
    }
}
