using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7
{
    public class User
    {
        public User()
        {
        }

        public User(
            string fullName,
            double weight,
            int height,
            int age
            )
        {

            FullName = fullName;
            Weight = weight;
            Height = height;
            Age = age;
            ;
        }

        public string FullName { get; set; }

        public double Weight { get; set; }

        public int Height { get; set; }

        public int Age { get; set; }


        public List<Run> Runs { get; set; } = new List<Run>();

        public List<Exercise> Exercises { get; set; } = new List<Exercise>();
    }
}
