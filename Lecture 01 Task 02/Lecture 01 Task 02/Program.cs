using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_01_Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            
            Console.Write("Enter your age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                
                if (age >= 18)
                {
                    Console.WriteLine($"Hello, {name}! You are eligible to vote.");
                }
                else
                {
                    Console.WriteLine($"Hello, {name}! You are not eligible to vote yet.");
                }
            }
            else
            {
                Console.WriteLine("Invalid age input. Please enter a valid integer.");
            }
        }
    }
}
