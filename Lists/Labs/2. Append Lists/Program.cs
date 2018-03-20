using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = "1 2 3 |4 5 6 | 7 8".Split('|').Reverse().ToList();
            var reverseString = new List<string>();
            for (int i = 0; i < inputString.Count; i++)
            {
                var nums = inputString[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries ).ToList();
                foreach (var num in nums)
                {
                    reverseString.Add(num);
                }
            }
            Console.WriteLine(string.Join(" ",reverseString));
        }
    }
}
