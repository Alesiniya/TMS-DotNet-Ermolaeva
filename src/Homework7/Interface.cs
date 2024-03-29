﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7
{
    public interface IFunctionalityService
    {
        event Action<string, DateTime> Notification;

        DateTime Execute(string message);

        void ShowAll(User user);

        void ShowRuns(User user);

        void ShowExercises(User user);

        public IEnumerable<int> BioTrackerPpg()
        {
            var list = new List<int>();
            var rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                list.Add(rnd.Next(40, 100));
            }

            return list;
        }
        public interface IStatisticService
        {
            Statistic Get(User user, IEnumerable<int> data);
        }
    }
}
