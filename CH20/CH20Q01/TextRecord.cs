namespace CH20Q01
{
    internal class TextRecord
    {
        private static string text;
        protected static string tag;
        public string Text
        {
            get { return text; }
            set
            {
                if (value.Trim().Length >= 1 && value.Trim().Length <= 12)
                {
                    text = value;
                }
            } 
        }
    }
}
