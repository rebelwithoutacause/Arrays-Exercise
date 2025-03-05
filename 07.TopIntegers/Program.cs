using System;
using System.Linq;

namespace _07.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isTopNumber = true;
                int currentNumber = numbers[i];

                 
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (currentNumber <= numbers[j])
                    {
                        isTopNumber = false;
                        break;
                    }
                }

                
                if (isTopNumber)
                {
                    Console.Write($"{currentNumber} ");
                }
            }
        }
    }
}