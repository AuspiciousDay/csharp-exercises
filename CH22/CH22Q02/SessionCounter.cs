namespace CH22Q02
{
    internal class SessionCounter : ISession, ILifetime
    {
        public int Sum { get; set; }
        public int TotalSum { get; set; }
        public bool Add(int n1)
        {
            if (n1 > 0)
            {
                Sum = n1;
                TotalSum += Sum;
                return true;
            }
            return false;
        }
        void ILifetime.Reset()
        {
            Sum = 0;
        }

        void ISession.Reset()
        {
            TotalSum = 0;
        }
    }
}
