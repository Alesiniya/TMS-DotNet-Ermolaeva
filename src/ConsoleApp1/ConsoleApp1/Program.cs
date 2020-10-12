using System;

namespace ConsoleApp1
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

            IZooManager zooManager = new ZooManager();
                zooManager.Animals.Add(lion);
                zooManager.Animals.Add(monkey);
            lion.Say();
            monkey.Play();
            zooManager.Show();
                ICanInteract canInteract = new ZooManager();
                canInteract.YouCanInteractWithIt();
            Console.WriteLine(lion.Name);
            Console.WriteLine(lion.Age);
            Console.WriteLine("---");
            Console.WriteLine(monkey.Name);
            Console.WriteLine(monkey.Age);
            Console.ReadKey();
            }
        }
    }