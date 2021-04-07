using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7
{
    public abstract class Activity<T> where T : struct
    {
        public string Name { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public T Data { get; set; }
    }

    public class Exercise : Activity<double>
    {
        public int Count { get; set; }
    }

    public class Run : Activity<decimal>
    {
        public double Speed { get; set; }
    }

    public class Statistic
    {
        public double AveragePpg { get; set; }
        public double AverageSpeed { get; set; }
        public double AverageCount { get; set; }
    }
}
