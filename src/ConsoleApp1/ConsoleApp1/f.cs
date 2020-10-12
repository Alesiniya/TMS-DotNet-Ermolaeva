using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Monkey : AnimalBase<int>
    {
        public void Play()
        {
            Console.WriteLine($"{Name}, play!");
        }
        public void Say()
        {
            Console.WriteLine($"{Name}, AAAAAA!");
        }
    }
}