using System;
using System.Collections.Generic;

namespace Homework_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var lion = new Lion
            {
                Name = "Alex",
                Age = 1,
            };

            var monkey = new Monkey
            {
                Name = "Morti",
                Age = 2,
            };
            Console.WriteLine(lion.Name);
            Console.WriteLine(lion.Age);
            Console.WriteLine("---");
            Console.WriteLine(monkey.Name);
            Console.WriteLine(monkey.Age);
            lion.Say();
            monkey.Play();
            Console.ReadKey();
        }
    }
}