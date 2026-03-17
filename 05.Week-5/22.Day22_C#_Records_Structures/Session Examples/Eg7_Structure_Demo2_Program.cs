using System;

// Working with Structures with properties
struct Student
{
    private int id;
    private string name;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.Id = 101;
        s.Name = "John";

        Console.WriteLine($"ID: {s.Id}, Name: {s.Name}");
        Console.ReadLine();
    }
}