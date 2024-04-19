using System;

public class Animal
{
    public void Speak()
    {
        Console.WriteLine("I am an Animal");
    }
}

public class Dog : Animal
{
    public void DisplayLegs()
    {
        Console.WriteLine("I have four legs");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        
        Dog myDog = new Dog();

        
        myDog.Speak();

        
        myDog.DisplayLegs();
    }
}

