using System;

namespace CH22Q05
{
    internal class NearPreference : IPreference
    {
        private int target;
        public NearPreference(int target)
        {
            this.target = target;
        }
        public bool Better(int candidate, int current)
        {
            return Math.Abs(target - candidate) < Math.Abs(target - current);
        }
    }
}
