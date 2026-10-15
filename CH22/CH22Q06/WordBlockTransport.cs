namespace CH22Q06
{
    internal class WordBlockTransport : ITransport
    {
        private string text;
        public int Attempts { get; set; }
        public WordBlockTransport(string text)
        {
            this.text = text;
        }
        public bool Send(string message)
        {
            Attempts++;

            if (message.Contains(text))
            {
                return false;
            }

            return true;
        }
    }
}
