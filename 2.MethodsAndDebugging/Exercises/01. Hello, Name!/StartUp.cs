using System;

namespace _01.Hello__Name_
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Greeting(input);
        }

        public static string Greeting(string name)
        {
           var  greeting = $"Hello, {name}!";
            Console.WriteLine(greeting);
            return greeting;
        }
    }
}
