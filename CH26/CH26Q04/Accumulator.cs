namespace CH26Q04
{
    internal class Accumulator
    {
        public int Value { get; set; } = 1;
        public int Calls { get; set; } = 0;

        public void Add(int value)
        {
            Value += value;
            Calls++;
        }
        public void Multiply(int value)
        {
            Value *= value;
            Calls++;
        }
    }
}
