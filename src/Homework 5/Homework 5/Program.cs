using System;
using System.Collections.Generic;
using System.Text;

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
                Food="meat"
            };

            var monkey = new Monkey
            {
                Name = "Morti",
                Age = 2,
                Food= "banana"
            };

            IZooManager zooManager = new ZooManager();

            zooManager.Animals.Add(lion);
            zooManager.Animals.Add(monkey);

            ICanInteract canInteract = new ZooManager();

            canInteract.YouCanInteractWithIt();

            Console.WriteLine(lion.Name);
            Console.WriteLine(lion.Age);
            Console.WriteLine(lion.Food);
            lion.Say();
            lion.Play();

            Console.WriteLine("---");

            Console.WriteLine(monkey.Name);
            Console.WriteLine(monkey.Age);
            Console.WriteLine(monkey.Food);
            monkey.Say();
            monkey.Play();

            Console.ReadKey();
        }
    }
}
