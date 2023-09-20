using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8__QuoteStrings {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter a String: ");
            string input = Console.ReadLine();

            string[] aInput = input.Split(' ');
            string output = "";
            foreach (string s in aInput) {
                output += $"\"{s}\" ";
            }
            Console.WriteLine(output);
        }
    }
}
