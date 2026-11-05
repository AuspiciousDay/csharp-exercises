namespace CH26Q01
{
    internal class Measure
    {
        public int interval(int[] ints)
        {
            int max = ints[0];
            int min = ints[0];
            for (int i = 1; i < ints.Length; i++)
            {
                if (ints[i] > max)
                {
                    max = ints[i];
                }
                else if (ints[i] < min)
                {
                    min = ints[i];
                }
            }
            return max - min;
        }

        public int Count(int[] ints)
        {
            int count = 0;
            for (int i = 0; i < ints.Length - 1; i++)
            {
                if (ints[i] != ints[i + 1])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
