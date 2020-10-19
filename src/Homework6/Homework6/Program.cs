using System;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            Atm atm = new Atm();
            atm.BalanceHandler += GetInfo;
            atm.Put(100.00);
            atm.Get(15.00);
            Console.ReadKey();
        }

        public static void GetInfo(double amount, string operation)
        {
            Console.WriteLine($"Operation {operation}. Current balance: {amount}");
        }
    }
}