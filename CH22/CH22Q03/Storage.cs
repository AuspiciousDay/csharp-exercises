namespace CH22Q03
{
    internal class Storage : ILockable
    {
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
    }
}
