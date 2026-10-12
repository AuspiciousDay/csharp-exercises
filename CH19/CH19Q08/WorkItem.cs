namespace CH19Q08
{
    internal class WorkItem
    {
        public string Tittle { get; }
        public bool Completed { get; private set; }

        public WorkItem(string title)
        {
            Tittle = title;
        }

        public void Complete() => Completed = true;
    }
}
