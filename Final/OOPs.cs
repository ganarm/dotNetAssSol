using System;

interface IGreet
{
    void SayHello();
}

class Person
{
    public string Name;
    public static string Country;

    static Person()
    {
        Country = "India";
        Console.WriteLine("Static constructor of Person called (Country set to India)");
    }

    public Person(string name)
    {
        Name = name;
        Console.WriteLine("Public constructor of Person called");
    }

    private Person()
    {
        Name = "Default";
        Console.WriteLine("Private constructor of Person called");
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Country: {Country}");
    }

    public static Person CreateDefaultPerson()
    {
        Console.WriteLine("Calling private constructor internally...");
        return new Person();
    }
}

class Employee : Person, IGreet
{
    public int EmployeeID;

    static Employee()
    {
        Console.WriteLine("Static constructor of Employee called");
    }

    public Employee(string name, int empId) : base(name)
    {
        EmployeeID = empId;
        Console.WriteLine("Public constructor of Employee called");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Employee Name: {Name}, ID: {EmployeeID}, Country: {Country}");
    }

    public void SayHello()
    {
        Console.WriteLine("Hello! I'm an employee.");
    }
}

class Program
{
    static void Main()
    {
        
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter employee ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("--- Demonstrating Public Constructor ---");
        Employee emp = new Employee(name, id);
        emp.DisplayInfo();
        emp.SayHello();

        Console.WriteLine("\n--- Demonstrating Private Constructor (used internally) ---");
        Person defaultPerson = Person.CreateDefaultPerson();
        defaultPerson.DisplayInfo();

        Console.WriteLine("\nNote: Static constructors are automatically called only once before the first use.");
    }
}
