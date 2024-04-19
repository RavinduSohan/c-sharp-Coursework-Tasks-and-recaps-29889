using System;


public abstract class Shape
{

    public string Color { get; private set; }
    public int X { get; private set; }
    public int Y { get; private set; }
    protected string Password { get; private set; }

    
    public Shape(string color, int x, int y, string password)
    {
        Color = color;
        X = x;
        Y = y;
        Password = password;
    }

    
    public abstract double CalculateArea();

    
    public void Draw(string enteredPassword)
    {
        if (CheckPassword(enteredPassword))
        {
            Console.WriteLine($"Drawing shape at ({X}, {Y}) with color {Color}");
        }
        else
        {
            Console.WriteLine("Incorrect password. Access denied.");
        }
    }

    
    protected void ChangePassword(string newPassword, string currentPassword)
    {
        if (CheckPassword(currentPassword))
        {
            Password = newPassword;
            Console.WriteLine("Password changed successfully.");
        }
        else
        {
            Console.WriteLine("Incorrect current password. Password change failed.");
        }
    }

   
    private bool CheckPassword(string enteredPassword)
    {
        return enteredPassword == Password;
    }
}


public class Circle : Shape
{
    public double Radius { get; private set; }

   
    public Circle(string color, int x, int y, string password, double radius)
        : base(color, x, y, password)
    {
        Radius = radius;
    }

    
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    
    public void DrawCircle(string enteredPassword)
    {
        if (CheckPassword(enteredPassword))
        {
            Console.WriteLine("This is a circle.");
        }
        else
        {
            Console.WriteLine("Incorrect password. Access denied.");
        }
    }

    private bool CheckPassword(string enteredPassword)
    {
        throw new NotImplementedException();
    }

    internal void ChangePassword(string v1, string v2)
    {
        throw new NotImplementedException();
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        
        Circle myCircle = new Circle("Red", 100, 100, "mypassword", 5.0);

        
        myCircle.Draw("mypassword");
        myCircle.Draw("wrongpassword"); 

        myCircle.DrawCircle("mypassword"); 
        myCircle.DrawCircle("wrongpassword"); 

        
        myCircle.ChangePassword("newpassword", "wrongpassword"); 
        myCircle.ChangePassword("newpassword", "mypassword"); 
        myCircle.Draw("newpassword"); 
    }
}

