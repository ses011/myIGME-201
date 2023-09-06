using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schneider_PE3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Takes in four numbers from the user and converts them to integers - assumes all input can be converted to an integer
            //Finds product of all numbers and displays value

            Console.WriteLine("Enter 4 integers to get the product: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());

            int prod = num1 * num2 * num3 * num4;

            Console.WriteLine("Product = " + prod);
        }
    }
}
