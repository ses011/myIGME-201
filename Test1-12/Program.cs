using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_12 {
    internal class Program {
        static void Main(string[] args) {
            string sName;
            double dSalary = 30000;

            Console.WriteLine("Enter your name");
            sName = Console.ReadLine();

            if(GiveRaise(sName, ref dSalary)) {
                Console.WriteLine($"Congrats on the raise to {dSalary}");
            }
        }

        static bool GiveRaise(string name, ref double salary) {
            if(name.ToLower().Equals("sarah")) {
                salary += 19999.99;
                return true;
            }
            else {
                return false;
            }
        }
    }
}
