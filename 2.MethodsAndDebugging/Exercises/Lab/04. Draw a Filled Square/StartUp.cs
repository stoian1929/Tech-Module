using System;

namespace _04.Draw_a_Filled_Square
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            TopHeader(num);
            MiddleFooter(num);
            DownHeader(num);
        }
        public static void TopHeader(int n)
        {
            Console.WriteLine(new string('-',n*2));
        }
        public static void MiddleFooter(int n)
        {
            for (int i = 0; i < n-2; i++)
            {
                Console.Write('-');
                for (int j = 1; j < n; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }
        public static void DownHeader(int n)
        {
            TopHeader(n);
        }
    }
}
