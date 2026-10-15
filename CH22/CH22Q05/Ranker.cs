namespace CH22Q05
{
    internal class Ranker
    {
        private IPreference preference;

        public Ranker(IPreference preference)
        {
            this.preference = preference;
        }

        public int Select(int[] values)
        {
            if (values.Length == 0)
            {
                return -1;
            }

            int bestIndex = 0;

            for (int i = 1; i < values.Length; i++)
            {
                if (preference.Better(values[i], values[bestIndex]))
                {
                    bestIndex = i;
                }
            }
            return bestIndex;
        }
    }
}
