using System;
using System.Collections.Generic;
using System.Text;

namespace CH23Q02
{
    internal readonly struct Duration
    {
        private readonly int miliseconds;
        private readonly int seconds;
        public Duration(int seconds, int miliseconds)
        {
            this.seconds = seconds;
            this.miliseconds = miliseconds;
        }
    }
}
