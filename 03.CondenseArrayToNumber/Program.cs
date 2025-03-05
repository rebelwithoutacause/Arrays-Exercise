using System;

class Program
{
    static void Main()
    {
         
       
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');

         
        int[] numbers = Array.ConvertAll(inputArray, int.Parse);

        
        while (numbers.Length > 1)
        {
            int[] condensed = new int[numbers.Length - 1];

             
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                condensed[i] = numbers[i] + numbers[i + 1];
            }

             
            numbers = condensed;
        }

        
        Console.WriteLine(numbers[0]);
    }
}
