using System;

namespace _07.Greater_of_Two_Values
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int max = GetMaxInt(first,second);
                Console.WriteLine(max);
            }
            else if (input == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                var max = GetMaxString(first, second);
                Console.WriteLine(max);
            }
            else if (input == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                var max = GetMaxChar(first, second);
                Console.WriteLine(max);
            }
        }
        public static int GetMaxInt(int first, int second)
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
        public static char GetMaxChar(char first, char second)
        {
            if ((int)first>=(int)second)
            {
               return (char)first;
            }
            else
            {
                return (char)second;
            }
        }
        public static string GetMaxString(string first, string second)
        {
            if (first.CompareTo(second)>=0)
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
