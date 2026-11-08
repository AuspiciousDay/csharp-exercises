namespace CH22Q04
{
    internal class ArrayReader : IReplayReader
    {
        private int[] values;
        public int Position { get; private set; }

        public ArrayReader(int[] values)
        {
            this.values = values;
        }
        public void Reset()
        {
            Position = 0;
        }

        public bool TryRead(out int value)
        {
            if (values.Length > Position)
            {
                value = values[Position];
                Position++;
                return true;
            }
            value = 0;
            return false;
        }
    }
}
