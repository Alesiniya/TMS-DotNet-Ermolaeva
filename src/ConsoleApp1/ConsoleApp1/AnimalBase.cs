using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class AnimalBase<T>
    {
        public string Name { get; set; }

        public T Age { get; set; }
    }
}