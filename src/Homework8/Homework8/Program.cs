using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many minutes do you want to take exercise");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many minutes did you exercise");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your step count for today");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your body weight in kilograms");
            double f = Convert.ToDouble(Console.ReadLine());

            if (c < a)
            {
                Console.WriteLine("Keep going!");
            }
            else if (c == a)
            {
                Console.WriteLine("Push yourself a bit more!");
            }
            else if (c > a)
            {
                Console.WriteLine("Great!");
            }

            Sample_First_Lambda_Simple(a, c);
            Sample_Aggregate_Lambda_Simple(b, f);
            Sample_Cast_Lambda(a, c, b, f);

        }

        public static void Sample_First_Lambda_Simple(double a, double c)
        {
            double[] s = { a, c };
            var result = s.First();
            Console.WriteLine("Your originally stated training time:");
            Console.WriteLine(result);
        }
        static void Sample_Cast_Lambda(double a, double c, double b, double f)
        {
            List<double> s = new List<double> { a, c, b, f };

            var result = s.Cast<double>();

            Console.WriteLine("Your result is recorded");
            Console.WriteLine(result);
        }
        private static void Sample_Aggregate_Lambda_Simple(double b, double f)
        {
            double[] calories = { b, f };

            var result = calories.Aggregate((f, b) => f * b * 35*1.35/100000);

            Console.WriteLine("Calories burned");
            Console.WriteLine(result);
        }
    }
}