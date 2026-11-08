using System;
using System.Collections.Generic;
using System.Text;

namespace CH16Q08
{
    internal class Counter
    {
        public string Name;
        public int Capacity;
        public int Waiting;

        public bool CanAccpet(int amount)
        {
            return amount > 0 && Waiting + amount <= Capacity;
        }

        public void Accpet(int amount)
        {
            if (CanAccpet(amount))
            {
                Waiting += amount;
            }
        }
    }
}
