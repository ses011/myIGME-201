using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

// Author : Sarah Schneider

namespace PE7_MadLibs {
    internal class Program {
        static void Main(string[] args) {
            string fName = @"c:\templates\MadLibsTemplate.txt";
            ArrayList alTemps = new ArrayList();
            int len = 0;

            // Reads in each line of the file and saves each as a seperate string to the alTemps ArrayList, and increases counter of how many total templates there are
            using (StreamReader sr = File.OpenText(fName)) {
                string line;

                while ((line = sr.ReadLine()) != null) {
                    alTemps.Add(line);
                    len++;
                }
            }

            // Prompts user for their name
            string name;
            Console.WriteLine("Enter your name.");
            name = (Console.ReadLine());

            while (true) {

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
                    catch (FormatException) {
                        Console.WriteLine("Input must be an integer, enter new choice.");
                    }
                    catch {
                        Console.WriteLine($"Input must be between 1 and {len}, enter new choice");
                    }
                }

                string resultString = "";
                string tempChoice = (string)alTemps[libChoice - 1];
                
                // Splits the chosen phrase into an array of strings where there was a space
                // Goes through the array and prompts the user with any of the words in {}
                // Otherwise adds the current word to the result string
                string[] aTemplate = tempChoice.Split(' ');
                Console.WriteLine("For each prompt displayed, type a word that fits the prompt.");
                foreach (string word in aTemplate) {
                    if (word[0].Equals('{')) {
                        string prompt = word.Substring(1, word.Length - 2);
                        prompt = prompt.Replace("_", " ");
                        Console.WriteLine(prompt);
                        resultString += $"{Console.ReadLine()} ";
                    }
                    else if (word[0].Equals('\\')) {
                        resultString += $"{"\x0A"} ";
                    }
                    else {
                        resultString += $"{word.Trim()} ";
                    }
                }

                //Displays final MadLib
                Console.WriteLine(resultString);

                // Asks user if they want to play again, only accepts yes or no (case insensitive)
                // Ends program if no, breaks out of small while loop and continues from beginning of main while loop, and reprompts user if invalid input
                Console.WriteLine("Do you want to play again? (yes or no)");
                
                while (true) { 
                    try {
                        string again = Console.ReadLine();
                        if (again.ToLower().Equals("yes")) {
                            break;
                        }
                        else if (again.ToLower().Equals("no")) {
                            Environment.Exit(0);
                        }
                        else {
                            throw new Exception();
                        }
                    }
                    catch {
                        Console.WriteLine("Input must be 'yes' or 'no'.");
                    }
                }
            }
        }
    }
}
