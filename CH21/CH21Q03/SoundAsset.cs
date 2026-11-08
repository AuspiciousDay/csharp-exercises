namespace CH21Q03
{
    internal class SoundAsset : Asset
    {
        public int delta;
        public int Volume { get; }
        public SoundAsset(int volume)
        {            
            Volume += volume;
        }
        public bool Adjust(int delta)
        {
            if (Volume + delta >= 0 && Volume + delta <= 10)
            {
                this.delta = delta;
                return true;
            }
            return false;
        }
    }
}
