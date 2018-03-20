using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.OddOccurrences
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var inputText = Console.ReadLine().ToLower().Split(' ').ToList();
            var dictionary = new Dictionary<string, int>();
            var result = new List<string>();
            foreach (var word in inputText)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word] += 1;

                }
                else
                {
                    dictionary.Add(word, 1);

                }
            }
            foreach (var item in dictionary)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result).Trim(' ', ','));
        }
    }
}
