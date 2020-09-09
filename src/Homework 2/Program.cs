using System;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your date: ");
            string userInput= Console.ReadLine ();
            bool result = DateTime.TryParse(userInput, out DateTime date);
            if (result)
            {
                Console.WriteLine (date.DayOfWeek);
            }
            else
            {
                Console.WriteLine("incorrect input");
            }
            Console.ReadLine();
        }
    }
}

