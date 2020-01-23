using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace WaterDetector
{
    class EventSubscriber
    {
        public void OnValueChanged(object sender, EventArgs e)
        {
            WriteLine(sender.ToString() + " - " + e.Value + " / " + e.Max);
        }
    }
}
