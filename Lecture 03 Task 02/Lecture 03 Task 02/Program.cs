using System;


public abstract class Shape
{
    
    protected string Name { get; set; }

   
    public Shape(string name)
    {
        Name = name;
    }

   
    public abstract double CalculateArea();

    
    public void DisplayShapeInfo()
    {
        Console.WriteLine($"Shape: {Name}");
        Console.WriteLine($"Area: {CalculateArea():F2} square units");
    }
}


public class Circle : Shape
{
    
    private double Radius { get; set; }

   
    public Circle(string name, double radius) : base(name)
    {
        Radius = radius;
    }

   
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}


public class Rectangle : Shape
{
    
    private double Length { get; set; }
    private double Width { get; set; }

    
    public Rectangle(string name, double length, double width) : base(name)
    {
        Length = length;
        Width = width;
    }

   
    public override double CalculateArea()
    {
        return Length * Width;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        
        Circle circle = new Circle("Circle", 5.0);
        circle.DisplayShapeInfo();

        Console.WriteLine(); 

      
        Rectangle rectangle = new Rectangle("Rectangle", 4.0, 6.0);
        rectangle.DisplayShapeInfo();
    }
}
