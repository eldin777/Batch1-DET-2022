using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Employee
    {
        int rollno, pincode, gross;
        long phonenumber;
        string name, address;

        public Employee(int rollno, int pincode, long phonenumber, int gross, string name, string address)
        {
            this.rollno = rollno;
            this.pincode = pincode;
            this.phonenumber = phonenumber;
            this.gross = gross;
            this.name = name;
            this.address = address;
        }

            public int GetNetSalary()
            {
                int pf = 12 * gross / 100;
                int netsal = gross - pf;
                return netsal;
            }

            public char GetGrade()
            {
                if (GetNetSalary() > 10000)
                {
                    return 'A';
                }
                else if (GetNetSalary() > 5000)
                {
                    return 'B';
                }
                else
                {
                    return 'C';
                }
            }
        }
    }

