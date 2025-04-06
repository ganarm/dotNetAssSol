using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Final
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class LinqToArray
    {
        public void Execute()
        {
            Console.Write("Enter number of elements in array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            var result = from n in numbers where n > 10 select n;

            Console.WriteLine("LINQ to Array (numbers > 10):");
            foreach (var n in result)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
        }
    }

    class LinqToXml
    {
        public void Execute()
        {
            Console.Write("Enter number of XML students: ");
            int n = Convert.ToInt32(Console.ReadLine());

            XElement data = new XElement("Students");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter ID of student {i + 1}: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Enter Name of student {i + 1}: ");
                string name = Console.ReadLine();

                data.Add(new XElement("Student",
                    new XElement("ID", id),
                    new XElement("Name", name)));
            }

            Console.Write("Enter ID to search in XML: ");
            int searchId = Convert.ToInt32(Console.ReadLine());

            var result = from s in data.Elements("Student")
                         where (int)s.Element("ID") == searchId
                         select s.Element("Name").Value;

            Console.WriteLine("LINQ to XML (searched student name):");
            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
        }
    }

    class LinqToCollection
    {
        public void Execute()
        {
            List<Student> students = new List<Student>();

            Console.Write("Enter number of students in collection: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter ID of student {i + 1}: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Enter Name of student {i + 1}: ");
                string name = Console.ReadLine();

                students.Add(new Student { ID = id, Name = name });
            }

            Console.Write("Enter minimum ID to filter: ");
            int minId = Convert.ToInt32(Console.ReadLine());

            var result = from s in students where s.ID > minId select s;

            Console.WriteLine("LINQ to Collection (filtered students):");
            foreach (var s in result)
            {
                Console.WriteLine($"ID: {s.ID}, Name: {s.Name}");
            }
            Console.WriteLine();
        }
    }

    class LinqToSqlSimulated
    {
        public void Execute()
        {
            List<Student> dbStudents = new List<Student>();

            Console.Write("Enter number of students in simulated database: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter ID of student {i + 1}: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Enter Name of student {i + 1}: ");
                string name = Console.ReadLine();

                dbStudents.Add(new Student { ID = id, Name = name });
            }

            Console.Write("Enter ID to search in simulated DB: ");
            int searchId = Convert.ToInt32(Console.ReadLine());

            var result = from s in dbStudents where s.ID == searchId select s;

            Console.WriteLine("LINQ to SQL (Simulated):");
            foreach (var s in result)
            {
                Console.WriteLine($"ID: {s.ID}, Name: {s.Name}");
            }
            Console.WriteLine();
        }
    }

    class Linq
    {
        static void Main()
        {
            new LinqToArray().Execute();
            new LinqToXml().Execute();
            new LinqToCollection().Execute();
            new LinqToSqlSimulated().Execute();
        }
    }
}
