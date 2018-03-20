using System;

namespace _05.Calculate_Triangle_Area
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var area = TriangleArea(width , height);
            Console.WriteLine(area);
        }
        public static double TriangleArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
