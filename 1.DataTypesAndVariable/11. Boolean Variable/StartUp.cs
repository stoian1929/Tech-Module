﻿using System;

namespace _05.Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool text = Convert.ToBoolean(Console.ReadLine());
            if (text)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
