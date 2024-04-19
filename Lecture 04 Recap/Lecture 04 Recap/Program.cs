using System;

public class EncapData
{
    private double _radius;
    private const double _pi = Math.PI;

    public EncapData(double radius)
    {
        _radius = radius;
    }

    
    public double Area
    {
        get
        {
            return _pi * _radius * _radius;
        }
    }

    
    public double Circumference
    {
        get
        {
            return 2 * _pi * _radius;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            
            Console.Write("Enter the radius of the circle: ");
            if (double.TryParse(Console.ReadLine(), out double radius) && radius > 0)
            {
                
                EncapData data = new EncapData(radius);

               
                double area = data.Area;
                double circumference = data.Circumference;

                
                Console.WriteLine($"Area of the circle: {area:F2}");
                Console.WriteLine($"Circumference of the circle: {circumference:F2}");
            }
            else
            {
                Console.WriteLine("Invalid radius. Please enter a valid positive number.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

