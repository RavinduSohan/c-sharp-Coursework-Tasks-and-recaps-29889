using System;

public class Program
{
    public static void Main(string[] args)
    {
        
        int baseNumber = 3;
        int exponent = 4;

      
        if (exponent < 0)
        {
            Console.WriteLine("Exponent must be a non-negative integer.");
            return; 
        }

        
        int result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= baseNumber;
        }
        Console.WriteLine($"{baseNumber}^{exponent} = {result}");
    }
}



