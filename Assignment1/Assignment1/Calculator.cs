//Basic Operations: Addition, Subtraction, Multiplication, Division.
//Advanced Features:
//Percentage Calculation(marks obtained, total marks).
//Method Overloading for Sum() (different parameters).


interface ICalculator
{
    int Add(int a, int b);
    int Subtract(int a, int b);
    int Multiply(int a, int b);
    double Divide(int a, int b);
    double CalculatePercentage(double marks, double total);
}

class Calculator : ICalculator
{
    // Implementing basic operations
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public double Divide(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error! Division by zero.");
            return double.NaN;
        }
        return (double)a / b;
    }

    // Percentage calculation
    public double CalculatePercentage(double marks, double total)
    {
        if (total == 0)
        {
            Console.WriteLine("Total marks cannot be zero.");
            return 0;
        }
        return (marks / total) * 100;
    }

    // Method Overloading: Sum() with different parameters
    public int Sum(int a, int b)
    {
        return a + b;
    }

    public int Sum(int a, int b, int c)
    {
        return a + b + c;
    }

    public double Sum(double a, double b)
    {
        return a + b;
    }
}

class Program1
{
    static void Main()
    {
        Calculator calc = new Calculator();

        // Performing basic operations
        Console.WriteLine("Addition: " + calc.Add(10, 5));
        Console.WriteLine("Subtraction: " + calc.Subtract(10, 5));
        Console.WriteLine("Multiplication: " + calc.Multiply(10, 5));
        Console.WriteLine("Division: " + calc.Divide(10, 5));

        // Percentage Calculation
        Console.WriteLine("Percentage: " + calc.CalculatePercentage(80, 100) + "%");

        // Method Overloading
        Console.WriteLine("Sum (int, int): " + calc.Sum(10, 5));
        Console.WriteLine("Sum (int, int, int): " + calc.Sum(10, 5, 3));
        Console.WriteLine("Sum (double, double): " + calc.Sum(10.5, 5.5));
    }
}
