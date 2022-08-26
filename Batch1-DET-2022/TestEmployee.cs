using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class TestEmployee
    {
        public static void Main()
        {
            Employee e = new Employee(12,689542,8547471900,545,"Eldin","Kerala");
            Console.WriteLine($"Net Salary {e.GetNetSalary()}");
            Console.WriteLine($"Get Grade {e.GetGrade()}");
        }
    }
}
