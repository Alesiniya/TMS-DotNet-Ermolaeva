using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5
{
    public interface IZooManager
    {
        List<AnimalBase<int>> Animals { get; set; }

        void Show();
    }
}