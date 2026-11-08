namespace CH20Q06
{
    internal class Report : Document
    {
        public CaptionFormatter Formmater { get; set; }
        public Report(string title, CaptionFormatter formatter) : base(title)
        {
            Formmater = formatter;
        }
        public string Render()
        {
            return Formmater == null ? Title : Formmater.Format(Title);
        }
    }
}
