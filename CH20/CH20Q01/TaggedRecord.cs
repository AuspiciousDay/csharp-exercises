namespace CH20Q01
{
    internal class TaggedRecord : TextRecord
    {
        public string Tag {  get; set; }

        public string Formatted
        {
            get
            {
                return $"[{Tag}] {Text}";
            }
        }

    }
}
