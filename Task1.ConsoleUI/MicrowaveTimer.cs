using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.ConsoleUI
{
    class MicrowaveTimer
    {
        private void Inform(object sender, TimerEventArgs e)
        {
            Console.WriteLine($"Time is over! {e.pastTime} past. Your food is warmed up");
        }

        public void Subscribe(Timer timer)
        {
            timer.TimeIsOver += Inform;
        }

        public void Unsubscribe(Timer timer)
        {
            timer.TimeIsOver -= Inform;
        }
    }
}
