﻿using System;
using System.Linq;

class Program
{
    static void Main()
    {
         
        int[] numbers = Console.ReadLine()
                               .Split()
                               .Select(int.Parse)
                               .ToArray();

        
        int controlNumber = int.Parse(Console.ReadLine());

        
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] + numbers[j] == controlNumber)
                {
                    Console.WriteLine($"{numbers[i]} {numbers[j]}");
                }
            }
        }
    }
}