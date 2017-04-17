using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task1
{
    public class TimerEventArgs : EventArgs
    {
        public readonly int pastTime;

        public TimerEventArgs(int time)
        {
            pastTime = time;
        }
    }

    public class Timer
    {
        public event EventHandler<TimerEventArgs> TimeIsOver = delegate { };
        protected virtual void OnTimeIsOver(TimerEventArgs e)
        {
            TimeIsOver.Invoke(this, e);
        }

        public void setTime(int timeInMilliseconds)
        {
            if (timeInMilliseconds < 0)
                throw new ArgumentException("Irregular input");

            Thread.Sleep(timeInMilliseconds);
            OnTimeIsOver(new TimerEventArgs(timeInMilliseconds));
        }
    }
}
