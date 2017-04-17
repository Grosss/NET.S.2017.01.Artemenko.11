using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.ConsoleUI
{
    class AlarmClock
    {
        private void Alarm(object sender, TimerEventArgs e)
        {
            Console.WriteLine($"Wake up buddy! {e.pastTime} past. Beep Beep Beep...");
        }

        public void Subscribe(Timer timer)
        {
            if (ReferenceEquals(timer, null))
                throw new ArgumentNullException();

            timer.TimeIsOver += Alarm;
        }

        public void Unsubscribe(Timer timer)
        {
            if (ReferenceEquals(timer, null))
                throw new ArgumentNullException();

            timer.TimeIsOver -= Alarm;
        }
    }
}
