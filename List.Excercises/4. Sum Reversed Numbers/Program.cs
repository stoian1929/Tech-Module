using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> numbers = "123 234 12"
               .Split(' ')
               .Select(int.Parse)
               .ToList();

        
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                int reversed = 0;
                int temp = numbers[i];
                while (temp > 0)
                {
                    int digit = temp % 10;
                    reversed = (reversed * 10) + digit;
                    temp /= 10;
                }
                sum += reversed;
            }
            Console.WriteLine(sum);
        }
    }
}
