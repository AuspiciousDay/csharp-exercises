namespace CH21Q04
{
    internal class TextMeter
    {
        public int Measure(string text) => text.Length;
        public virtual string Summary(string text) => $"문자 {Measure(text)}";
    }
}
