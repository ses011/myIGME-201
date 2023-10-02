using System;
// Commenting and fixing errors from given code
// Author: Sarah Schneider

namespace UT1_BugSquash {
    class Program {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args) {
            string sNumber;
            int nX;
            int nY;     //Compile time- missing ;
            int nAnswer;

            Console.WriteLine("This program calculates x ^ y.");    //Compile time- missing ""

            do {
                Console.Write("Enter a whole number for x: ");
                sNumber = Console.ReadLine();       //logic error- ReadLine() needs a variable to save to if the value is actually wanting to be saved
            } while (!int.TryParse(sNumber, out nX));

            do {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nY));    //logic error- out needs to be nY, not nX, also needs to start with ! to negate boolean value of TryParse

            // compute the exponent of the number using a recursive function
            nAnswer = Power(nX, nY);

            Console.WriteLine($"{nX}^{nY} = {nAnswer}");  //logic error- needs $ before "" to use the propper formatting for variables in {}
        }

        static int Power(int nBase, int nExponent) {        //logic error- best practice to have static functions
            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0) {
                // return the base case and do not recurse
                return 1;   //logic error- needs to return 1 not 0
            }
            else {
                //returns nBase multiplied by recursive call
                return nBase * Power(nBase, nExponent - 1);     //logic error- needs to be minus 1 not plus 1
            }
        }
    }
}
