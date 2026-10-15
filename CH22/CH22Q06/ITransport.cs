namespace CH22Q06
{
    internal interface ITransport
    {
        bool Send(string message);
        int Attempts { get; }
    }
}
