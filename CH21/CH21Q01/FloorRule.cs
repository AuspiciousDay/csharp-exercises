using System;

namespace CH21Q01
{
    internal class FloorRule : ValueRule
    {
        public int n;
        public int floor;
        public FloorRule(int n)
        {
            this.n = n;
        }
        public override void Adjust(int value)
        {
            floor = value / n * n;
            Console.WriteLine($"FloorRule: {floor}");
        }
    }
}
