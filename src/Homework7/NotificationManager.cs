using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7
{
    public static class NotificationManager
    {
        public static void Show(string message, DateTime dateTime)
        {
            Console.WriteLine($"{message} {dateTime}");
        }
    }
}
