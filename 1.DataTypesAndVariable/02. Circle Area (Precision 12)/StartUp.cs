using System;

namespace _02.Circle_Area__Precision_12_
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            double radius = r * r * Math.PI;
            Console.WriteLine("{0:f12}", radius);
        }
    }
}
