using System;
using System.Collections.Generic;
using System.Text;

namespace CH20Q01
{
    internal class AppendNote
    {
        TaggedRecord taggedRecord = new TaggedRecord();
        public AppendNote(string note)
        {
            taggedRecord.Text += $" {note}";
        }
    }
}
