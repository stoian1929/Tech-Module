using System;

namespace _04.Elevator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var people = int.Parse(Console.ReadLine());
            var capacity = int.Parse(Console.ReadLine());
            var liftCourses = Math.Ceiling((double)people / capacity);
            Console.WriteLine(liftCourses);
        }
    }
}
