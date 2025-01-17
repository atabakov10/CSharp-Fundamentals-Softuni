﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"(#|@)([a-zA-Z]{3,})(\1)(\1)([a-zA-Z]{3,})(\1)");

            string message = Console.ReadLine();
            List<string[]> results = new List<string[]>();

            MatchCollection matches = pattern.Matches(message);

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }
            foreach (Match match in matches)
            {
                string firstWord = match.Groups[2].Value;
                string secondWord = match.Groups[5].Value;

                string reversedSecondWord = string.Join("", secondWord.Reverse());

                if (firstWord == reversedSecondWord)
                {
                    results.Add(new string[] { firstWord, secondWord });
                }
            }

            if (results.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                string[] messages = results
                    .Select(word => $"{word[0]} <=> {word[1]}")
                    .ToArray();


                Console.WriteLine($"The mirror words are:");
                Console.WriteLine( string.Join(", ", messages));
                
            }

        }
    }
}
