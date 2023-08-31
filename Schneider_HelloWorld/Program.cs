using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schneider_HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Sarah Schneider");

            //initialize values for two int variables
            int a = 26;
            int b = 19;

            //display addition value of int variables
            Console.WriteLine("a + b = " + (a + b).ToString());

            //counts from 0 to a exclusive, printing each value
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
 