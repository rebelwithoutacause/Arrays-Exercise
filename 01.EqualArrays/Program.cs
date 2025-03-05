using System;

class Program
{
    static void Main()
    {
        
        string[] array1 = Console.ReadLine().Split(' ');
        string[] array2 = Console.ReadLine().Split(' ');

        
        if (array1.Length == array2.Length)
        {
            bool areIdentical = true;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    areIdentical = false;
                    break;
                }
            }

            if (areIdentical)
            {
                Console.WriteLine("Arrays are identical.");
            }
            else
            {
                Console.WriteLine("Arrays are not identical.");
            }
        }
        else
        {
            Console.WriteLine("Arrays are not identical.");
        }
    }
}
