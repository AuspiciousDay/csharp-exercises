namespace CH22Q03
{
    internal class NameTag : IEditable
    {
        public string Name { get; set; } = "철수";
        public bool Replace(string text)
        {
            text = text.Trim();
            if (text.Length > 0 && text.Length < 7 && Name != text)
            {
                Name = text;
                return true;
            }
            return false;
        }

    }
}
