using System;

namespace SquashTheBugs
{
    // Class Program
    // Author: Sarah Schneider
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            // int i = 0
            // not necessary here, can do in for loop
            
            // declare string to hold all numbers
            string allNumbers = "";

            // loop through the numbers 1 through 10
            // changed from < to <= (1-10 exclusive to 1-10 inclusive)
            for (int i = 1; i <= 10; ++i)
            {
                // string allNumbers = null;
                // makes allNumbers reference out of scope in line 58, moved declaration up to line 23

                // output explanation of calculation
                // Console.Write(i + "/" + i - 1 + " = "); 
                // i needs to be string, but is still an integer
                Console.Write(i.ToString() + "/" + (i-1).ToString() + " = ");

                // output the calculation based on the numbers
                // needs try/catch to not divide by zero
                try
                {
                    Console.WriteLine(i / (i - 1));
                }
                catch
                {
                    Console.WriteLine("Cannot divide by zero");
                }
                

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                // already done in for loop, not needed here
                // i = i + 1;
            }

            // output all numbers which have been processed
            Console.WriteLine("These numbers have been processed: " + allNumbers);
        }
    }
}
