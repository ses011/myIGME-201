using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_3 {
    internal class Program {
        //Delegate declaration
        delegate double RoundDelegateBase(double x, int y);

        static void Main(string[] args) {
            //variable declaration and initialization
            double x = 4.235893;
            int y = 2;
            RoundDelegateBase roundDelegate;
            roundDelegate = new RoundDelegateBase(Math.Round);

            //Call delegate and display result
            double result = roundDelegate(x, y);
            Console.WriteLine(result);
        }
    }
}
