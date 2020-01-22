using System;
using System.Collections.Generic;
using System.Text;

namespace WaterDetector
{
    public delegate void EventHandler(object sender, EventArgs e);

    public class EventArgs
    {
        public int Value { get; set; }

        public EventArgs(int value)
        {
            Value = value;
        }
    }
}
