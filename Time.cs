using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21_1
{
    internal class Time
    {
        public int hours;
        public int minutes;
        public int seconds;
        public Time() { }
        public Time(int hours) { this.hours = hours; }
        public Time (int hours, int minutes) : this(hours) { this.minutes = minutes; }
        public Time (int hours, int minutes, int seconds) : this(hours,minutes) { this.seconds = seconds; }

        public void Info()
        {
            Console.WriteLine($"В {hours} часах - {minutes} минут и {seconds} секунд");
        }

        public override string ToString()
        {
            return $"В {hours} часах - {minutes} минут и {seconds} секунд";
        }
    }
}
