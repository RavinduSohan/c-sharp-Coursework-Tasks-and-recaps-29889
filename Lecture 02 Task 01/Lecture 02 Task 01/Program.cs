using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_02_Task_01
{
    
        public class Vehicle
        {
        
            public string Brand { get; set; }
            public int NumberOfWheels { get; set; }

          
            public Vehicle(string brand, int numberOfWheels)
            {
                Brand = brand;
                NumberOfWheels = numberOfWheels;
            }

            
            public void Sound()
            {
                switch (Brand.ToLower())
                {
                    case "car":
                        Console.WriteLine("Vroom Vroom!");
                        break;
                    case "motorcycle":
                        Console.WriteLine("Vroom!");
                        break;
                    case "bicycle":
                        Console.WriteLine("Ring Ring!");
                        break;
                    default:
                        Console.WriteLine("Beep Beep!");
                        break;
                }
            }
        }
    public class Program
    {
        public static void Main(string[] args)
        {
           
            Vehicle myCar = new Vehicle("Car", 4);

            Console.WriteLine($"Vehicle Brand: {myCar.Brand}");
            Console.WriteLine($"Number of Wheels: {myCar.NumberOfWheels}");
            Console.Write("Vehicle Sound: ");
            myCar.Sound();
        }
    }
}

