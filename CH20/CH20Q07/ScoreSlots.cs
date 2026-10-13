namespace CH20Q07
{
    internal class ScoreSlots
    {
        private int[] scoreslots = new int[3];
        public int Count => scoreslots.Length;
        public int this[int index]
        {
            get
            {
                if (index < 0 && index > 2)
                {
                    return -2;
                }
                return scoreslots[index];
            }                
            set
            {
                if(value == -1)
                {
                    scoreslots[index] = 0;
                }
                else if(value >= 0 && value <=100)
                {
                    scoreslots[index] = value;
                }
            }
        }
        public ScoreSlots()
        {
            for(int i = 0; i < scoreslots.Length; i++)
            {
                scoreslots[i] = -1;
            }
        }
    }
}
