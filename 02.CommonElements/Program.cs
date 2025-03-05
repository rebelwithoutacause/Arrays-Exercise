using System;

class Program
{
    static void Main()
    {
        
        string[] array1 = Console.ReadLine().Split();
        string[] array2 = Console.ReadLine().Split();

        
        foreach (string num1 in array1)
        {
            foreach (string num2 in array2)
            {
                if (num1 == num2)
                {
                    Console.Write(num1 + " ");
                }
            }
        }
    }
}
