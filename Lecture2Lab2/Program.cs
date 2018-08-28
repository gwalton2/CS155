using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the number of coupons you have and press enter.");

            ///define all our variables
            int coupons, candybars, gumballs;

            coupons = Int32.Parse(Console.ReadLine());
            candybars = coupons / 10;
            gumballs = (coupons % 10) / 3;

            Console.WriteLine("You can get {0} candbar(s) and {1} gumball(s).", candybars, gumballs);
            Console.ReadLine();

        }
    }
}
