using System;

namespace CH17Q01
{
    internal class RangeSetting
    {
        private int lower = 0;
        private int upper = 30;

        public bool TrySet(int lower, int upper)
        {
            if (lower <= -20 || lower >= 50 || upper <= -20 || upper >= 50 || lower > upper)
            {
                return false;
            }
            this.lower = lower;
            this.upper = upper;
            return true;
        }
        public void ShowRange(bool success)
        {
            Console.WriteLine($"{success}: {lower}~{upper}, 폭 {upper - lower}");
        }
        public void final()
        {
            Console.WriteLine($"최종: {lower}~{upper}");
        }
    }
}
