namespace CH26Q02
{
    internal class Calibrator
    {
        public int Offset { get; set; }
        public Calibrator(int offset)
        {
            Offset = offset;
        }

        public int Adjust(int value) => Offset + value;
    }
}
