namespace Dispatch
{
    internal class Warehouse
    {
        public int Counter { get; set; }

        public Warehouse(int amount)
        {
            Counter = amount;
        }
        public bool TryDispatch(int amount)
        {
            if(amount > Counter)
            {
                return false;
            }
            Counter -= amount;
            return true;
        }
    }
}
