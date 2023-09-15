/** Sarah Schneider
 * 
 * Program to guess a randomly generated number between 0-100 within 8 tries. Only integers are accepted values, will have user input
 * new values if values are outside of this range or are not integers. Option to play again after each random number guessed.
 * 
 */


using System;

namespace PE6_NumGuesser {
    internal class Program {
        static void Main(string[] args) {
            Random rand = new Random();

            
            while (true) {
                // Generates random number and declares variables
                int randNum = rand.Next(0, 101);
                int guess;
                int i;


                for (i = 0; i < 8; i++) {
                    Console.WriteLine("Guess an integer (guess " + (i + 1) + "): ");

                    while (true) {
                        // Attempt to read in input from the user as an integer
                        try {
                            // If it is able to be read as an integer but it is out of range, an exception is thrown
                            guess = int.Parse(Console.ReadLine());
                            if (guess > 100 || guess < 0) {
                                throw new Exception();
                            }
                            else {
                                break;
                            }
                        }

                        // Catches input not able to be read as an integer thrown by try block failing
                        catch (FormatException) {
                            Console.WriteLine("Not an integer, try again: ");
                        }
                        // Catches out of range input exceptions thrown by if statement
                        catch {
                            Console.WriteLine("Integer must be between 1 and 100, try again: ");
                        }
                    }

                    //Checks valid input against random number. Breaks out of for loop if equal to random number
                    if (guess > randNum) {
                        Console.WriteLine("Too high.");
                    }
                    else if (guess < randNum) {
                        Console.WriteLine("Too low.");
                    }
                    else if (guess == randNum) {
                        break;
                    }
                }
                // If i made it all the way to 8 (for loop escape point) it prints the losing message. Otherwise displays winning message
                if (i == 8) {
                    Console.WriteLine("You ran out of turns. The number was " + randNum + ".");
                }
                else {
                    Console.WriteLine("Correct! You won in " + (i + 1) + " turns.");
                }

                //Allows user to play again
                Console.WriteLine("Do you want to play agian? (Y/N)");
                while (true) {
                    try {
                        // Ends program if N is entered
                        string again = Console.ReadLine();
                        if (again.ToUpper() == "N") {
                            Environment.Exit(0);
                        }
                        // Any value that's not Y (any value that's N has already been caught by first if block) it throws exception to get new input
                        else if (again.ToUpper() != "Y") {
                            throw new Exception();
                        }
                        // Only remaining option is Y- breaks out of new input while loop and continues on looping through whole program while loop
                        else {
                            break;
                        }
                    }
                    // Catches all errors, those thrown by if block and try block
                    catch {
                        Console.WriteLine("Must enter Y or N.");
                    }
                }
            }
        }
    }
}
