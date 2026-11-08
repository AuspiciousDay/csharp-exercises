using System.Text;

namespace CH20Q02
{
    internal class RecordStore
    {
        private readonly int[] values;
        public int Count { get; private set; }
        public int Capacity => values.Length;
        public RecordStore(int capacity)
        {
            values = new int[capacity];
        }

        public string Describe()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            for (int i = 0; i < Count; i++)
            {
                sb.Append(values[i]);
                if (i < Count - 1)
                {
                    sb.Append(",");
                }
            }
            sb.Append("]");
            return sb.ToString();
        }

        protected bool TryAppend(int value)
        {
            if (Count == Capacity)
            {
                return false;
            }
            values[Count++] = value;
            return true;
        }
    }
}
