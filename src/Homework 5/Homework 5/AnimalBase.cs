using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5
{
    public abstract class AnimalBase<T>
    {
        public string Name { get; set; }
        public string Food { get; set; }

        public T Age { get; set; }
    }
}
