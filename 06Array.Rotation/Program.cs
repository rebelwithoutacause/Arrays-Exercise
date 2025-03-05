using System;
using System.Linq;

class Program
{
    static void Main()
    {
        
        int[] numbers = Console.ReadLine()
                               .Split()
                               .Select(int.Parse)
                               .ToArray();

        
        int rotations = int.Parse(Console.ReadLine());

         
        rotations = rotations % numbers.Length;

         
        for (int i = 0; i < rotations; i++)
        {
            
            int firstNumber = numbers[0];
            for (int j = 1; j < numbers.Length; j++)
            {
                numbers[j - 1] = numbers[j];
            }
            numbers[numbers.Length - 1] = firstNumber;
        }

         
        Console.WriteLine(string.Join(" ", numbers));
    }
}