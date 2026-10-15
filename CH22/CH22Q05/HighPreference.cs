namespace CH22Q05
{
    internal class HighPreference : IPreference
    {
        public bool Better(int candidate, int current)
        {
            return candidate > current;
        }
    }
}
