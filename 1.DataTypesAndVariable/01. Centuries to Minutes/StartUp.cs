using System;

namespace _01.Centuries_to_Minutes
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int years = 100 * n;
            int days = (int)(365.2422 * years);
            int hours = 24 * days;
            int minutes = 60 * hours;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", n, years, days, hours, minutes);
        }
    }
}
