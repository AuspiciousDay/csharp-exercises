using System;

namespace CH22Q06
{
    internal class Outbox
    {
        private string[] messages;
        private bool[] completed;
        private ITransport transport;
        public Outbox(ITransport transport, string[] messages)
        {
            this.transport = transport;
            this.messages = messages;
            completed = new bool[messages.Length];
        }
        public void ChangeTransport(ITransport transport)
        {
            this.transport = transport;
        }
        public int Flush()
        {
            int success = 0;

            for (int i = 0; i < messages.Length; i++)
            {
                if (completed[i] == false)
                {
                    if (transport.Send(messages[i]))
                    {
                        completed[i] = true;
                        success++;
                    }
                }
            }
            return success;
        }
        public void PrintRemaining()
        {
            for (int i = 0; i < completed.Length; i++)
            {
                if (completed[i] == false)
                {
                    Console.WriteLine($"[{messages[i]}]");
                }
            }
        }
    }
}