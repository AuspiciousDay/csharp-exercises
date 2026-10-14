using System;
using System.Collections.Generic;
using System.Text;

namespace CH21Q02
{
    internal class TaskInfo
    {
        public string name {  get; set; }

        public TaskInfo(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return $"[{name}]";
        }
    }
}
