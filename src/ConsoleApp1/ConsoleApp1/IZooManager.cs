using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface IZooManager
    {
        List<AnimalBase<int>> Animals { get; set; }

        void Show();
    }
}
