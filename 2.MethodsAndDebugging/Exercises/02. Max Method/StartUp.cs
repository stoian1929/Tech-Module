using System;

namespace _02.Max_Method
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var third = int.Parse(Console.ReadLine());
            if (GetMax(first,second) >= third)
            {
                Console.WriteLine(GetMax(first,second));
            }
            else
            {
                Console.WriteLine(third);
            }
        }
        public static int GetMax(int first, int second)
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
