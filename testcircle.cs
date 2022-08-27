using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class testcircle
    {
        public static void Main()
        {
            circle c = new circle(5);
            Console.WriteLine($"Area of the circle {c.GetArea()}");
        }
    }
}
