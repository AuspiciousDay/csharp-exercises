namespace CH17Q02
{
    internal class AverageRecorder
    {
        private int sum = 0;
        private int count = 0;

        public int Add(int value)
        {
            sum+= value;
            count++;
            return sum;
        }
        public int GetCount()
        {
            return count;
        }
        public double GetAverage()
        {
            return (double)sum / count;
        }
    }
}
