namespace CH22Q01
{
    internal interface IIntView
    {
        int Count { get; }
        int this[int index] { get; }
    }
}
