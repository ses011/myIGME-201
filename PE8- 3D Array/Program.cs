using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PE8__3D_Array {
    internal class Program {
        static void Main(string[] args) {
            double[][,] result = new double[21][,];

            //first dimention counter
            int f = 0;

            //loops through all values of y for all values of x, does the math to get result of z
            //saves values to arrays
            for (double x = -1; x <= 1; x += 0.1) {
                double[,] tempArray = new double[2, 31];

                //3rd dimention counter
                int i = 0;
                for (double y = 1; y < 4.1; y += 0.1) {
                    
                    double z = (3 * Math.Pow(y, 2)) + (2 * x) - 1;
                    Console.WriteLine(y);
                    tempArray[0, i] = y;
                    tempArray[1, i] = z;
                    i++;
                }

                //adds 2d array to next spot in 3d array, increases to next index of 3d array
                result[f] = tempArray;
                f++;
            }

            Console.WriteLine((-0.1) + 0.1);

            
            double inc = 0.1;
            double xval = -1;
            //Loops through array, displaying all of the values of y and z for each value of x
            foreach (double[,] x in result) {
                Console.WriteLine(" ----- x = " + Math.Round(xval, 2) + " -------");
                for (int i = 0; i < x.Length/2; i++) {
                    Console.WriteLine($"when y = {x[0, i]}, z = {x[1, i]}");
                }

                xval += inc;
            }
        }
    }
}
