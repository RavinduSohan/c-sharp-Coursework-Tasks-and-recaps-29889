using System;

public class Program
{
    public static void Main(string[] args)
    {
        const int ArraySize = 5; 

       
        int[] numbers = new int[ArraySize];

       
        Console.WriteLine("Enter 5 numerical values:");

        for (int i = 0; i < ArraySize; i++)
        {
            Console.Write($"Enter value {i + 1}: ");

           
            if (int.TryParse(Console.ReadLine(), out int userInput))
            {
                numbers[i] = userInput; 
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                i--; 
            }
        }

        
        Console.WriteLine("\nArray elements:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        
        Console.WriteLine($"\nSum of the array: {sum}");
    }
}
