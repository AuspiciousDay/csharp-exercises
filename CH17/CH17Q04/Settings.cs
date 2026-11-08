using System;

namespace CH17Q04
{
    internal class Settings
    {
        private readonly int[] values = new int[3];
        public int[] snapshot = new int[3];
        public bool TrySet(int index, int value)
        {
            if(index < 0 || index > 2)
            {
                return false;
            }
            values[index] = value;
            return true;
        }
        public int[] GetSnapshot()
        {
            for(int i = 0; i < values.Length; i++)
            {
                snapshot[i] = values[i];
            }
            return snapshot;
        }
        public void showOrg()
        {
            Console.WriteLine($"[{string.Join(" , ", values)}]");
        }
        public void showsnap()
        {
            Console.WriteLine($"[{string.Join(" , ", snapshot)}]");
        }
    }
}
