using System;

namespace _03.English_Name_of_Last_Digit
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            var lastNum = inputNum % 10;
            LastDigit(lastNum);
        }
        public static int LastDigit(int lastNum)
        {
           // string engl = "";
            switch (lastNum)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                default:
                    Console.WriteLine("zero");
                    break;
            }
            return lastNum;
        }
    }
}
