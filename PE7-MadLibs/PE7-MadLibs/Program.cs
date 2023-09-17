using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PE7_MadLibs {
    internal class Program {
        static void Main(string[] args) {
            string fName = @"c:\templates\MadLibsTemplate.txt";
            ArrayList alTemps = new ArrayList();
            int len = 0;

            // Reads in each line of the file and saves each as a seperate string to the alTemps ArrayList, and increases counter of how many total templates there are
            using (StreamReader sr = File.OpenText(fName)) {
                string line;
                
                while((line = sr.ReadLine()) != null) {
                    alTemps.Add(line);
                    len++;
                }
            }

            // Prompts user for their name
            string name;
            Console.WriteLine("Enter your name.");
            name = (Console.ReadLine());

            // Prompts user for which MadLibs template they want to use
            // Makes sure input is an integer within the range of 1-len
            int libChoice;
            Console.WriteLine($"Pick a MadLibs template (enter an int between 1 and {len}).");
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
                    Console.WriteLine($"Input must be between 1 and {len}, enter new choice");
                }
            }

            string resultString = "";
            string tempChoice = (string)alTemps[len - 1];
            string[] aTemplate = tempChoice.Split(' ');

            foreach (string word in aTemplate) {
                if (word.Substring(0, 1).Equals("{")) {
                    string prompt = word.Substring(1, word.Length - 2);
                    Console.WriteLine(prompt);
                }
                else {
                    Console.WriteLine(word);
                    resultString += word;
                }
            }
            Console.WriteLine(resultString);
        }
    }
}
