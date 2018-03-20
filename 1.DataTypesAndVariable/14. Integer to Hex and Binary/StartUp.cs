using System;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber = int.Parse(Console.ReadLine());
            string hexaNum = Convert.ToString(decimalNumber, 16).ToUpper();
            string binaryNum = Convert.ToString(decimalNumber,2).ToUpper();
            Console.WriteLine($"{hexaNum}\n{binaryNum}");
        }
    }
}
