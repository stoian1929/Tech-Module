using System;

namespace _1.DaysOfWeek
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            var number = int.Parse(Console.ReadLine());

            if (number < 8 && number > 0)
            {
                Console.WriteLine(days[number - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
