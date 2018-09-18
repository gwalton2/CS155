//Authors:  Grant Walton & Julie Bonsack

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int fine = 0;

            Console.WriteLine("Please enter a speed limit and press enter.");
            int limit = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your speed and press enter.");
            int speed = Int32.Parse(Console.ReadLine());

            if (speed > limit)
            {
                fine += 60;

                if (speed > (limit + 25))
                {
                    fine += 250;
                }

                fine += (speed - limit) * 7;

                Console.WriteLine("You were speeding. Your fine is " + fine.ToString("C"));
            }

            else
            {
                Console.WriteLine("You were not speeding!");
            }

            Console.ReadLine();
        }
    }
}
