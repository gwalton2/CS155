using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Fahrenheit temperature you wish to convert and press enter.");

            int f_temp = Int32.Parse(Console.ReadLine());
            double c_temp = Math.Round(5*(f_temp - 32) / (double)9, 1);

            Console.WriteLine("{0} degrees Fahrenheit = {1} degrees Celsius", f_temp, c_temp);
            Console.ReadLine();
        }
    }
}
