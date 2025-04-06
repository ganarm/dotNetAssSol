using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Final
{
    // Custom Exception
    public class MyCustomException : Exception
    {
        public int ErrorCode { get; }

        public MyCustomException(int code, string message) : base(message)
        {
            ErrorCode = code;
        }

        public override string ToString()
        {
            return $"[Error {ErrorCode}] {Message}";
        }
    }

    // Operation Class for 2-tier Exception Handling
    public class MyOperations
    {
        public int Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {
                throw new MyCustomException(101, "Division by zero is not allowed.");
            }
        }

        public int GetElement(int[] arr, int index)
        {
            try
            {
                return arr[index];
            }
            catch (IndexOutOfRangeException)
            {
                throw new MyCustomException(102, "Array index out of range.");
            }
        }
    }

    // Main Application to Test the Code
    class ExceptionHandlingDemo
    {
        static void Main(string[] args)
        {
            MyOperations op = new MyOperations();

            try
            {
                Console.Write("Enter numerator: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter denominator: ");
                int b = Convert.ToInt32(Console.ReadLine());

                int result = op.Divide(a, b);
                Console.WriteLine("Division result: " + result);
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine("Exception caught in Divide: " + ex.ToString());
            }

            try
            {
                Console.Write("Enter size of array: ");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[size];

                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Enter element {i}: ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("Enter index to retrieve: ");
                int index = Convert.ToInt32(Console.ReadLine());

                int value = op.GetElement(arr, index);
                Console.WriteLine("Element at index: " + value);
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine("Exception caught in GetElement: " + ex.ToString());
            }
        }
    }
}

