using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Test1_4 {
    // Author: Sarah Schneider
    // Program that asks the user to pick between three questions, asks the user those questions, checks answer, and if no answer is given
    // after 5 seconds it gives the answer. Allows for repetitions.
    internal class Program {
        
        static Timer timer;
        static bool timeOut = false;

        static string answer;
        static void Main(string[] args) {
            int choice;

            string question;
            
            string userInput;

            // timer setup
            timer = new Timer(5000);
            timer.Elapsed += new ElapsedEventHandler(timesUp);


            while (true) {
                // Asks user for question choice, validates input to only accept integers between 1 and 3
                Console.Write($"\nChoose your question (1-3): ");
                while (true) {
                    try {
                        choice = int.Parse(Console.ReadLine());
                        if (choice < 1 || choice > 3) {
                            throw new Exception();
                        }
                        break;
                    }
                    catch {
                        Console.Write("Choose your question (1-3): ");
                    }
                }

                // Switch statement to set question and answer string values
                switch (choice) {
                    case 1:
                        question = "What is your favorite color?";
                        answer = "black";
                        break;
                    case 2:
                        question = "What is the answer to life, the universe and everything?";
                        answer = "42";
                        break;
                    case 3:
                        question = "What is the airspeed velocity of unladen swallow?";
                        answer = "What do you mean? African or European swallow?";
                        break;
                    default:
                        question = "Smth's wrong";
                        answer = "smth' still wrong";
                        break;
                }

                do {
                    // Display question and start timer
                    Console.WriteLine($"You have 5 seconds to answer the following question: \n{question}");
                    timer.Start();


                    // Gets user input and checks if it's the same as the answer
                    // After 5 seconds quits the question and doens't let user enter an answer
                    userInput = Console.ReadLine();
                    timer.Stop();
                    timeOut = true;

                } while (!timeOut);

                // Checks the user answer against the saved answer
                if (userInput.Equals(answer)) {
                    Console.WriteLine("Well done!");
                }
                else {
                    Console.WriteLine($"Wrong!  The answer is {answer}");
                }

                // Ask user if they want to play again, continues if input starts with y, quits if starts with n, and requests new input for all other cases
                Console.Write("Play again? ");
                while (true) {
                    try {
                        string again = Console.ReadLine();
                        if (again.ToLower().Trim().StartsWith("y")) {
                            break;
                        }
                        else if (again.ToLower().StartsWith("n")) {
                            Environment.Exit(0);
                        }
                        else {
                            throw new Exception();
                        }
                    }
                    catch {
                        Console.Write("Play again? ");
                    }
                }
            }
        }

        // Timer exceeds 5 seconds event handler funtion
        // Pauses timer, displays relevant information, and sets boolean timeout to true
        static void timesUp(object sender, ElapsedEventArgs e) {
            timer.Stop();

            Console.WriteLine("Time's up!");

            Console.WriteLine($"The answer is: {answer}");
            Console.WriteLine("Please press enter.");

            timeOut = true;
        }
    }
}
