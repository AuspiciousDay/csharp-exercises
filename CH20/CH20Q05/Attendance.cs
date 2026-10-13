namespace Register
{
    internal class Attendance
    {
        public string name {  get; set; }
        public int Counter { get; set; }
        public bool TryRegister(string name)
        {
            if(this.name != name && Counter <= 3)
            {
                this.name = name.Trim();
                Counter++;
                return true;
            }
            return false;            
        }
    }
}
