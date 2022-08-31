using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class CSFeatures
    {
        public static void Main()
        {
            /*Action<string> action = (string name) => { Console.WriteLine($"Hai{name}"); };
             Action<string, string> action1 = (string s1, string s2) => { Console.WriteLine($"Hai {s1}," + $"you said {s2}"); };
             action.Invoke("Mary");
             action1.Invoke("Mary", "am in Blr");
             Action<int, string, string> printEmp = (int id, string name, string email) => { Console.WriteLine($"id={id}, name={name}, email={email}"); };
             printEmp(5050, "Mary", "mary.s");*/
            Action<string, string> helo = (string name, string loc) => { Console.WriteLine("Hello" + name + "from" + loc); };
            helo("Mary", "GV1");
            Func<int,int,long>multiply = (X,y) =>
            {
                return X * y;
                };
            long result = multiply(100, 100);
            Console.WriteLine(result);
            
        }
        static void Hi(string name)
        {
            Console.WriteLine("Hai " + name);
        }
    }
}
