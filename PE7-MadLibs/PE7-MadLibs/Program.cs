using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PE7_MadLibs {
    internal class Program {
        static void Main(string[] args) {
            string temps = @"c:\templates\MadLibsTemplate.txt";
            string[] aTemplates;
            int len = 0;

            using (StreamReader sr = File.OpenText(temps)) {
                string line;
                string templates = "";
                
                while((line = sr.ReadLine()) != null) {
                    templates += line;
                    len++;
                }
                
            }
            string name;
            Console.WriteLine("Enter your name.");
            name = (Console.ReadLine());

            int libChoice;
            Console.WriteLine("Pick a MadLibs template (enter an int between 1 and " + len + ").");
            while (true) {
                try {
                    libChoice = int.Parse(Console.ReadLine());
                    if (libChoice > len || libChoice < 1) {
                        throw new Exception();
                    }
                    else {
                        break;
                    }
                }
                catch (FormatException){
                    Console.WriteLine("Input must be an integer, enter new choice.");
                }
                catch {
                    Console.WriteLine("Input must be between 1 and " + len + ", enter new choice");
                }
            }
            // string libTemp = aTemplates[libChoice];
            // Console.WriteLine(libTemp);
            Console.WriteLine(aTemplates);
        }
    }
}
