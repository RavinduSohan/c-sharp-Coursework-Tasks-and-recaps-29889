using System;

public class Program
{
    public static char CheckOddOrEven(int number)
    {
        if (number % 2 == 0)
        {
            return 'E'; 
        }
        else
        {
            return 'O'; 
        }
    }

    public static void Main(string[] args)
    {
        
        Console.Write("Enter a number: ");
        int userInput;

        if (int.TryParse(Console.ReadLine(), out userInput))
        {
           
            char result = CheckOddOrEven(userInput);

            if (result == 'E')
            {
                Console.WriteLine($"{userInput} is even (E).");
            }
            else
            {
                Console.WriteLine($"{userInput} is odd (O).");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}

