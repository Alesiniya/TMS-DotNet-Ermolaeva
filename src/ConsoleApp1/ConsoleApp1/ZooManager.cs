using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class ZooManager : IZooManager, ICanInteract
    {
        public List<AnimalBase<int>> Animals { get; set; } = new List<AnimalBase<int>>();

        public void Show()
        {
            foreach (var animal in Animals)
            {
                Console.WriteLine(animal.Name);
                Console.WriteLine(animal.Age);
            }
        }

        public void YouCanInteractWithIt()
        {

            Show();
        }
    }
}

