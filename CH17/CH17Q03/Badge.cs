namespace CH17Q03
{
    internal class Badge
    {
        private int number = 0;
        private static int next = 1;

        public bool TryIssue()
        {
            if (number == 0)
            {
                number++;
                next++;
                return true;
            }
            return false;
        }
        public int GetNumber()
        {
            return number;
        }
        public int GetIssuedCount()
        {
            return next - 1;
        }
    }
}
