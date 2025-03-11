using System;
using System.IO;

namespace Assignment1
{
    internal class Program
    {
        void check_datatype()
        {
            Console.Write("Enter Any input : ");
            string input = Console.ReadLine();

            try
            {
                int intValue = Convert.ToInt32(input);
                Console.WriteLine($"Integer value: {intValue}");
            }
            catch
            {
                Console.WriteLine("you can convert this input as Integer.");
            }

            try
            {
                bool boolValue = Convert.ToBoolean(input);
                Console.WriteLine($"Boolean value: {boolValue}");
            }
            catch
            {
                Console.WriteLine("you can convert this input as boolean.");
            }

            try
            {
                double doubleValue = Convert.ToDouble(input);
                Console.WriteLine($"Double value: {doubleValue}");
            }
            catch
            {
                Console.WriteLine("you can convert this input as double.");
            }

            try
            {
                decimal decimalValue = Convert.ToDecimal(input);
                Console.WriteLine($"Decimal value: {decimalValue}");
            }
            catch
            {
                Console.WriteLine("you can convert this input as decimal.");
            }

            try
            {
                DateTime dateTimeValue = Convert.ToDateTime(input);
                Console.WriteLine($"DateTime value: {dateTimeValue}");
            }
            catch
            {
                Console.WriteLine("you can convert this input as DateTime.");
            }
        }

        void string_operation()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string upperCase = input.ToUpper();
            string lowerCase = input.ToLower();
            string trimmed = input.Trim();
            string replaced = input.Replace('l', '*');

            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'l')
                {
                    count++;
                }
            }

            string formattedOutput = string.Join("*", input.ToCharArray());

            Console.WriteLine($"Uppercase: {upperCase}");
            Console.WriteLine($"Lowercase: {lowerCase}");
            Console.WriteLine($"Trimmed: '{trimmed}'");
            Console.WriteLine($"Replaced 'l' with '*': {replaced}");
            Console.WriteLine($"Number of 'l' in the string: {count}");
            Console.WriteLine($"Formatted output: {formattedOutput}");
        }

        void file_operation()
        {
            string filePath = "output.txt";

            if (File.Exists(filePath))
            {
                Console.WriteLine("Old Data :");
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }

            Console.Write("Enter New Data ");
            string input = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(input);
            }


            Console.WriteLine("Updated File : ");
            string[] updatedLines = File.ReadAllLines(filePath);
            foreach (string line in updatedLines)
            {
                Console.WriteLine(line);
            }
        }

        //static void Main(string[] args)
        //{
        //    ClassA a = new ClassA();
        //    a.Name = "Ajinkhky";

        //    Console.WriteLine(a.Name);

        //    Program program = new Program();
        //    bool exit = false;

        //    while (!exit)
        //    {
        //        Console.WriteLine("\nMenu:");
        //        Console.WriteLine("1. Convert Datatype");
        //        Console.WriteLine("2. String Opearation");
        //        Console.WriteLine("3. Append to File");
        //        Console.WriteLine("4. Exit");
        //        Console.Write("Choose an option (1-4): ");

        //        string choice = Console.ReadLine();

        //        switch (choice)
        //        {
        //            case "1":
        //                program.check_datatype();
        //                break;
        //            case "2":
        //                program.string_operation();
        //                break;
        //            case "3":
        //                program.file_operation();
        //                break;
        //            case "4":
        //                exit = true;
        //                Console.WriteLine("stop.");
        //                break;
        //            default:
        //                Console.WriteLine("Invalid Input.");
        //                break;
        //        }
        //    }
        //}
    }
}