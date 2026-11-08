using System;

namespace CH21Q01
{
    internal class NearestRule : ValueRule
    {
        public int near;
        public int n;
        public NearestRule(int n)
        {
            this.n = n;
        }
        public override void Adjust(int value)
        {
            near = value / n * n + n;
            Console.WriteLine($"NearestRule: {near}");
        }
    }
}
