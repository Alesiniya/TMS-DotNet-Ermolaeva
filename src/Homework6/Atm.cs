using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    public class Atm
    {
        public event Action<double, string> BalanceHandler;
        private double _sum = 0.00;

        public void Put(double sum)
        {
            _sum += sum;
            BalanceHandler?.Invoke(_sum, "put");
        }

        public void Get(double sum)
        {
            _sum -= sum;
            BalanceHandler?.Invoke(_sum, "get");
        }
        public void ShowInfo()
        {
            var eventName = "show";
            BalanceHandler?.Invoke(_sum, eventName);
        }
    }
}
