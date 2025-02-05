using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate calculate1 = new Calculate();
            calculate1.line1 = 4;
            calculate1.line2 = 9;
            Console.WriteLine(calculate1.ToString());
            Console.WriteLine();
            Calculate calculate2 = new Calculate(5,20);
            Console.WriteLine(calculate2.ToString());
            Console.WriteLine();
            Console.Write("Первое число = ");
            double line1 = double.Parse(Console.ReadLine());
            Console.Write("Второе число = ");
            double line2 = double.Parse(Console.ReadLine());
            Calculate calculate3 = new Calculate(line1, line2);
            Console.WriteLine(calculate3.ToString());
            Console.WriteLine();


        }
    }
}
