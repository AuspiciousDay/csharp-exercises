namespace CH22Q04
{
    internal interface IReplayReader : IIntReader, IResettable
    {
        int Position { get; }
    }
}
