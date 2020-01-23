using System;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace WaterDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            WaterTank wt1 = new WaterTank(100, "WT1");
            WaterTank wt2 = new WaterTank(10, "WT2");
            WaterTank wt3 = new WaterTank(500, "WT3");
            WaterTank wt4 = new WaterTank(50, "WT4");
            WaterTank wt5 = new WaterTank(25, "WT5");
            EventSubscriber sub = new EventSubscriber();
            wt1.ValueHasChanged += sub.OnValueChanged;
            wt2.ValueHasChanged += sub.OnValueChanged;
            wt3.ValueHasChanged += sub.OnValueChanged;
            wt4.ValueHasChanged += sub.OnValueChanged;
            wt5.ValueHasChanged += sub.OnValueChanged;

            while (true)
            {
                wt1.Add(r.Next(5));
                wt2.Add(r.Next(5));
                wt3.Add(r.Next(5));
                wt4.Add(r.Next(5));
                wt5.Add(r.Next(5));
                ReadLine();
                //Thread.Sleep(1000);
            }
        }
    }
}
