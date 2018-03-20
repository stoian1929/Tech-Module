﻿using System;
using System.Numerics;

namespace _13.Factorial
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Result(n));
        }

        static BigInteger Result(int n)
        {
            BigInteger sum = 0;

            if (n == 1)
            {
                return 1;
            }
            else
            {
                sum = Result(n - 1) * n;
                return sum;
            }
        }
    }
}
