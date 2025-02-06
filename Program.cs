using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time time1 = new Time();
            time1.Info();
            Console.WriteLine();
            time1.hours = 3;
            time1.minutes = time1.hours * 60;
            time1.seconds = time1.hours * 3600;
            time1.Info();
            Console.WriteLine();
            Time time2 = new Time(3, time1.minutes, time1.seconds);
            time2.Info();
            Console.WriteLine();
            Console.Write("Количество часов = ");
            int hours = int.Parse(Console.ReadLine());
            int minutes = hours * 60;
            int seconds = hours * 3600;
            Time time3 = new Time(hours, minutes, seconds);
            time3.Info();
        }
    }
}
