using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        public static void Main(string[] args)
        {
            var array = "3 4 4 5 5 5 2 2".Split(' ').Select(int.Parse).ToList();
            int start = 0;
            int len = 1;

            int bestPosition = 0;
            int bestLen = 1;

            for (int i = 1; i < array.Count; i++)
            {
                if (array[i] == array[i - 1])
                {
                    len++;
                    if (len > bestLen)
                    {
                        bestLen = len;
                        bestPosition = start;
                    }
                }
                else
                {
                    if (len > bestLen)
                    {
                        bestPosition = start;
                        bestLen = len;
                    }
                    start = i;
                    len = 1;
                }
            }

            for (int i = bestPosition; i < bestPosition + bestLen; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
