﻿using System;
using System.Collections.Generic;

namespace _9.IndexOfLetters
{
    class StartUp
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToLower().ToCharArray();

            PositionFinder(word);
        }

        private static void PositionFinder(char[] word)
        {
            Dictionary<char, int> lettersAndPos = new Dictionary<char, int>();

            int pos = 0;
            for (char i = 'a'; i <= 'z'; i++)
            {
                if (!lettersAndPos.ContainsKey(i))
                {
                    lettersAndPos.Add(i, pos);
                }
                pos++;
            }

            foreach (char c in word)
            {
                if (lettersAndPos.ContainsKey(c))
                {
                    Console.WriteLine($"{c} -> {lettersAndPos[c]}");
                }
            }
        }
    }
}
