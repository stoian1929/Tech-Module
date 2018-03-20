using System;

namespace _04.Numbers_in_Reversed_Order
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string digitString = Console.ReadLine();
            Console.WriteLine(StringReverser(digitString));
        }

        static string StringReverser(string inputString)
        {
            char[] charactersInString = inputString.ToCharArray();
            string reversedString = "";
            for (int i = charactersInString.Length - 1; i >= 0; i--)
            {
                reversedString += charactersInString[i];
            }
            return reversedString;
        }
    }
}
