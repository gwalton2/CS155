/// Homework No.3 Exercise No.2
/// File Name: Homework3_2.cs
/// @author: Grant Walton
/// Date: Sept. 17, 2018
/// Problem Statement: This program should prompt the user to input a price between 25cents to a dollar 
/// in 5cent increments. It should then calculate the change in quarters, dimes, and nickles based on a payment amount
/// of 1 dollar. 
/// Overall Plan:
/// 1. I will print out a prompt for the user to input their price which I will parse as a double.
/// 2. I will calculate the actual amount of change as a double and also create an integer change
/// variable by multiplying the raw change by 100 to make my later calculations easier.
/// 3. I will check the price to make sure it is within the constraints laid out in the prompt.
/// 4. If the price is within the constraints I will break up the change into quarters, dimes and nickels
/// by using integer and modular division.
/// 5. Then I will output the results to the user. 

/// Classes needed and Purpose: Only main class is needed
/// main class - Homework3_2
/// Import necessary C# or user-defined packages
/// Create main class and objects needed to implement task

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_2
{
    class Homework3_2
    {
        static void Main(string[] args)
        {
            int quarter = 0;
            int dime = 0;
            int nickle = 0;

            Console.WriteLine("Enter price of item (from 25 cents to a dollar, in 5-cent increments):");

            double price = Double.Parse(Console.ReadLine());
            double raw_change = 1 - price;
            int change = 100 - (int)(price * 100);

            if (price > 1 || price < .25 || change % 5 != 0)
            {
                Console.WriteLine("The price can only be from 25 cents to a dollar in 5-cent increments.");
                Console.WriteLine("Please try again.");
            }

            else
            {
                quarter = change / 25;
                dime = (change % 25) / 10;
                nickle = ((change % 25) % 10) / 5;
                
                Console.WriteLine("You bought an item for " + price.ToString("C") + " and paid a dollar. Your change is " + raw_change.ToString("C") + ":");
                Console.WriteLine("quarter: {0}", quarter);
                Console.WriteLine("dime: {0}", dime);
                Console.WriteLine("nickle: {0}", nickle);
            }
            Console.ReadLine();
        }
    }
}
