using System;
using System.Collections.Generic;
using System.Text;

namespace CH21Q02
{
    internal class ProgressTask : TaskInfo
    {
        public int Task {  get; set; }
        public int Amount {  get; set; }
        public bool Advance(int amount)
        {
            if(Amount + amount <= Task)
            {
                Amount += amount;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + $" {Amount}/{Task} {(Task == Amount ? "완료": "진행")}";
        }

        public ProgressTask(string name, int task) : base(name)
        {
            this.Task = task;
        }
    }
}
