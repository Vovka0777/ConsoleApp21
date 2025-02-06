using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Calculate
    {
        public double line1;
        public double line2;
        public Calculate() { }
        public Calculate(double line1) { this.line1 = line1; }
        public Calculate(double line1, double line2) : this(line1) { this.line2 = line2; }

        public void Info()
        {
        Console.WriteLine($"Корень из произведения {line1} * {line2} = {Math.Sqrt(line1*line2):f2}");
        }
        
        public override string ToString()
        {
            return $"Корень из произведения {line1} * {line2} = {Math.Sqrt(line1*line2):f2}";
        }
    }
}
