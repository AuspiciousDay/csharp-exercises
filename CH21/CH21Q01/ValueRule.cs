using System;

namespace CH21Q01
{
    internal class ValueRule
    {
        public int value;
        public virtual void Adjust(int value)
        {
            this.value = value;
            Console.WriteLine($"ValueRule: {value}");
        }
    }
}
