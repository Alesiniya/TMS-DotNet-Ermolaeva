using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5
{
    public class ZooManager : IZooManager, ICanInteract
    {
        public List<AnimalBase<int>> Animals { get; set; } = new List<AnimalBase<int>>();

        public void Show()
        {
            Console.WriteLine("Welcome to our zoo!");

        }



        public void YouCanInteractWithIt()
        {
            Show();
            Console.WriteLine("We glad to see you!");
        }
    }
}
