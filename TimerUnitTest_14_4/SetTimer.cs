using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace TimerUnitTest_14_4
{
    class SetTimer
    {
        private DateTime startTime;
        private Timer timer;
        private TimeSpan span;

        public SetTimer(string time)
        {
            span = TimeSpan.Parse(time);
            timer = new Timer(span.TotalMilliseconds);
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = false;
            timer.Enabled = true;
            startTime = DateTime.Now;
        }

        public void TimerCount()
        {
            while (DateTime.Now - startTime < span)
            {
                Console.WriteLine("{0:dd\\.hh\\:mm\\:ss}", DateTime.Now.Subtract(startTime));
                System.Threading.Thread.Sleep(1000);
            }
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Times up!");
        }
    }
}
