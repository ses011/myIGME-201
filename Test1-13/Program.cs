using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sarah Schneider
//Test1-11 except with struct now
namespace Test1_12 {
    internal class Program {
        struct Employee {
            public string sName;
            public double dSalary;
        }

        static void Main(string[] args) {
            Employee emp;
            emp.dSalary = 30000;

            Console.WriteLine("Enter your name");
            emp.sName = Console.ReadLine();

            if (GiveRaise(ref emp)) {
                Console.WriteLine($"Congrats on the raise to {emp.dSalary}");
            }
        }

        static bool GiveRaise(ref Employee emp) {
            if (emp.sName.ToLower().Equals("sarah")) {
                emp.dSalary += 19999.99;
                return true;
            }
            else {
                return false;
            }
        }
    }
}
