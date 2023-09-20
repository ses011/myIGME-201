using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8__yes_no {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            string[] aInput = input.Split(' ');
            string output = "";

            foreach (string line in aInput) {
                if (line.ToLower().Contains("yes")) {
                    output += (line.Replace("yes", "no") + " ");
                }
                else if (line.ToLower().Contains("no")) {
                    output += (line.Replace("no", "yes") + " ");
                }
                else {
                    output += (line + " ");
                }
            }
            Console.WriteLine(output);
        }
    }
}
