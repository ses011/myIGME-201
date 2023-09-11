using System;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>


    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            // Gets input, converts it to double, and validates it for all 4 values (two start, two end) needed for the loops
            Console.WriteLine("Enter the start and stop double values for imagCoord in two seperate lines (start value larger than end value): ");
            double imagStart = Convert.ToDouble(Console.ReadLine());
            double imagEnd = Convert.ToDouble(Console.ReadLine());

            while (imagStart < imagEnd)
            {
                Console.WriteLine("First number must be larger than the second: ");
                imagStart = Convert.ToDouble(Console.ReadLine());
                imagEnd = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Enter the start and stop double values for realCoord in two seperate lines (start value smaller than end value): ");
            double realStart = Convert.ToDouble(Console.ReadLine());
            double realEnd = Convert.ToDouble(Console.ReadLine());

            while (realStart > realEnd)
            {
                Console.WriteLine("Second number must be larger than the first: ");
                realStart = Convert.ToDouble(Console.ReadLine());
                realEnd = Convert.ToDouble(Console.ReadLine());
            }

            // Calculates the increment value needed for each axis
            double imagChange = (Math.Abs(imagStart) + Math.Abs(imagEnd)) / 48;
            double realChange = (Math.Abs(realStart) + Math.Abs(realEnd)) / 80;

            double realTemp, imagTemp, realTemp2, arg;
            int iterations;
            for (double imagCoord = imagStart; imagCoord >= imagEnd; imagCoord -= imagChange)
            {
                for (double realCoord = realStart; realCoord <= realEnd; realCoord += realChange)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}
