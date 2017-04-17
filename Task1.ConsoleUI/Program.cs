using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Timer();
            var alarmClock = new AlarmClock();
            var microwave = new MicrowaveTimer();

            alarmClock.Subscribe(timer);
            microwave.Subscribe(timer);            
            timer.setTime(5000);
            Console.WriteLine();

            alarmClock.Unsubscribe(timer);
            timer.setTime(3000);

            Console.ReadLine();
        }
    }
}
