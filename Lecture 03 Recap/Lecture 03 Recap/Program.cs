using System;

public class Student
{
    
    public string Name { get; set; }
    public int GradeSubject1 { get; set; }
    public int GradeSubject2 { get; set; }
    public int GradeSubject3 { get; set; }

   
    public Student(string name, int gradeSubject1, int gradeSubject2, int gradeSubject3)
    {
        Name = name;
        GradeSubject1 = gradeSubject1;
        GradeSubject2 = gradeSubject2;
        GradeSubject3 = gradeSubject3;
    }

    
    public void DisplayDetails()
    {
        Console.WriteLine($"Student Name: {Name}");
        Console.WriteLine($"Grade for Subject 1: {GradeSubject1}");
        Console.WriteLine($"Grade for Subject 2: {GradeSubject2}");
        Console.WriteLine($"Grade for Subject 3: {GradeSubject3}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        
        Student max = new Student("Max", 54, 65, 75);
        Student amasha = new Student("Amasha", 72, 49, 55);

        
        Console.WriteLine("Details of Max:");
        max.DisplayDetails();
        Console.WriteLine();

        Console.WriteLine("Details of Amasha:");
        amasha.DisplayDetails();
    }
}
