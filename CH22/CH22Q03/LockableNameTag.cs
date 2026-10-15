namespace CH22Q03
{
    internal class LockableNameTag : ILockable, IEditable
    {
        public string Name { get; set; } = "영희";
        public bool IsLocked { get; private set; }
        public bool Lock()
        {
            if (IsLocked == false)
            {
                IsLocked = true;
                return true;
            }

            return false;
        }

        public bool Replace(string text)
        {
            text = text.Trim();
            if (text.Length > 0 && text.Length < 7 && Name != text && !IsLocked)
            {
                Name = text;
                return true;
            }
            return false;
        }
    }
}
