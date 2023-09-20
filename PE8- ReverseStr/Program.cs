using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8__ReverseStr {
    internal class Program {
        static void Main(string[] args) {
            // Prompts user and collects input
            Console.WriteLine("Enter a string to be reversed: ");
            string input = Console.ReadLine();

            //Empty string for output
            string reverse = "";
            foreach (char c in input) {
                // Adds c to the beginning
                reverse = c + reverse;
            }
            
            Console.WriteLine(reverse);
        }
    }
}
