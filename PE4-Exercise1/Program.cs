using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4_Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            while (true) {
                if (num1 > 10 ^ num2 > 10)
                {
                    Console.WriteLine(num1 + " and " + num2);
                    break;
                }
                else
                {
                    Console.WriteLine("Enter two integers- one has to be greater than 10, and one less than: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    num2 = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
