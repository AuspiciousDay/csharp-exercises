namespace CH22Q06
{
    internal class QuotaTransport : ITransport
    {
        private int quota;
        public int Attempts { get; set; }
        public QuotaTransport(int quota)
        {
            this.quota = quota;
        }
        public bool Send(string message)
        {
            Attempts++;
            if (quota >= Attempts)
            {
                return true;
            }
            return false;
        }
    }
}
