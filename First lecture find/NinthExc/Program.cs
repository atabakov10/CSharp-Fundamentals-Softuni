﻿using System;

namespace NinthExc
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < num; i++)
            {
                int currentOdNumber = 1 + (i * 2);

                sum += currentOdNumber;
                Console.WriteLine(currentOdNumber);
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
