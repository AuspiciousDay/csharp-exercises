using System;
using System.Collections.Generic;
using System.Text;

namespace CH16Q06
{
    internal class Product
    {
        public int Code;
        public int Stock;

        public bool AddStock(int amount)
        {
            if(amount > 0)
            {
                return true;
            }
            return false;
        }
    }
}
