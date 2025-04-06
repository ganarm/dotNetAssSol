using System;

namespace Final
{
    // Delegate and Event Publisher
    public class College
    {
        public delegate void FestEventHandler(int people);
        public event FestEventHandler CollegeFest;

        public void OrganizeFest(int people)
        {
            Console.WriteLine("\n--- College Fest Responses ---");
            CollegeFest?.Invoke(people);
        }
    }

    // Subscriber 1
    public class Caterer
    {
        public void HandleCatering(int people)
        {
            int cost = people * 200;
            Console.WriteLine($"Catering Cost (Rs.200 per plate): Rs.{cost}");
        }
    }

    // Subscriber 2
    public class Decorator
    {
        public void HandleDecoration(int people)
        {
            int cost = 10000 + (people * 10);
            Console.WriteLine($"Decoration Cost (Rs.10000 base + Rs.10 per person): Rs.{cost}");
        }
    }

    class Class3
    {
        static void Main(string[] args)
        {
            College college = new College();
            Caterer caterer = new Caterer();
            Decorator decorator = new Decorator();

            // Subscribing to the event
            college.CollegeFest += caterer.HandleCatering;
            college.CollegeFest += decorator.HandleDecoration;

            Console.Write("Enter number of people visiting fest: ");
            if (int.TryParse(Console.ReadLine(), out int people) && people > 0)
            {
                college.OrganizeFest(people);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid positive number.");
            }

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
