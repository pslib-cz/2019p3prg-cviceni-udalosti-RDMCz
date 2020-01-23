using System;
using System.Collections.Generic;
using System.Text;

namespace WaterDetector
{
    public delegate void EventHandler(object sender, EventArgs e);

    public class EventArgs
    {
        public int Value { get; set; }
        public int Max { get; set; }

        public EventArgs(int value, int max)
        {
            Value = value;
            Max = max;
        }
    }
}
