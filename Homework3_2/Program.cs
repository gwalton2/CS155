using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int quarter = 0;
            int dime = 0;
            int nickle = 0;

            Console.WriteLine("Enter price of item (from 25 cents to a dollar, in 5-cent increments):");

            double price = Double.Parse(Console.ReadLine());
            int change = 100 - (int)(price * 100);

            if (price > 1 || price < .25 || (price * 100) % 5 != 0)
            {
                Console.WriteLine("The price can only be from 25 cents to a dollar in 5-cent increments.");
                Console.WriteLine("Please try again.");
            }

            else
            {
                quarter = change / 25;
                dime = (change % 25) / 10;
                nickle = ((change % 25) % 10) / 5;
                
                Console.WriteLine("You bought an item for " + price.ToString("C") + " and paid a dollar. Your change is:");
                Console.WriteLine("quarter: {0}", quarter);
                Console.WriteLine("dime: {0}", dime);
                Console.WriteLine("nickle: {0}", nickle);
            }
            Console.ReadLine();
        }
    }
}
