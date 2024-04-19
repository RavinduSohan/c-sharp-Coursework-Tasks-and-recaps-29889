using System;


public abstract class Shape
{
  
    public string Color { get; set; }
    public (int x, int y) Position { get; set; }

   
    public Shape(string color, (int x, int y) position)
    {
        Color = color;
        Position = position;
    }

    
    public abstract double CalculateArea();

    public virtual void Draw()
    {
        Console.WriteLine($"Drawing a {Color} shape at position ({Position.x}, {Position.y})");
    }
}


public class Circle : Shape
{
    
    public double Radius { get; set; }

  
    public Circle(string color, (int x, int y) position, double radius) : base(color, position)
    {
        Radius = radius;
    }

    
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    
    public override void Draw()
    {
        Console.WriteLine($"Drawing a {Color} circle at position ({Position.x}, {Position.y}) with radius {Radius}");
    }
}


public class Rectangle : Shape
{
   
    public double Width { get; set; }
    public double Height { get; set; }

    
    public Rectangle(string color, (int x, int y) position, double width, double height) : base(color, position)
    {
        Width = width;
        Height = height;
    }

    
    public override double CalculateArea()
    {
        return Width * Height;
    }

    
    public override void Draw()
    {
        Console.WriteLine($"Drawing a {Color} rectangle at position ({Position.x}, {Position.y}) with width {Width} and height {Height}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        
        Circle circle = new Circle("Red", (100, 100), 5.0);
        circle.Draw();
        Console.WriteLine($"Area of the circle: {circle.CalculateArea():F2}");

        Console.WriteLine(); 

        
        Rectangle rectangle = new Rectangle("Blue", (200, 200), 8.0, 6.0);
        rectangle.Draw();
        Console.WriteLine($"Area of the rectangle: {rectangle.CalculateArea():F2}");
    }
}

