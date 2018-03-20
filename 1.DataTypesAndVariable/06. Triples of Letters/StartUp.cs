using System;

namespace _06.Triples_of_Letters
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            for (char first = 'a'; first < 'a' + num; first++)
            {
                for (char second = 'a'; second < 'a' + num; second++)
                {
                    for (char third = 'a'; third < 'a' + num; third++)
                    {
                        Console.WriteLine("{0}{1}{2}", first, second, third);
                    }
                }
            }
        }
    }
}
