/// Homework No.2 Exercise No.2
/// File Name: Homework2_2.cs
/// @author: Grant Walton
/// Date: Sept. 14, 2018
/// Problem Statement: This program should take in a temperature in Fahrenheit and print out the 
/// temperature converted to Celcius.
/// Overall Plan:
/// 1. I will print out a prompt for the user to input the original Fahrenheit temperature.
/// 2. I will take that input and parse it into an integer.
/// 3. I will convert it to Celsius using C = 5(F-32)/9
/// 4. I will cast the 9 to a double to prevent integer division.
/// 5. I will use Math.Round to get it to 1 decimal place. 
/// 6. I will print out the final answer to the console.

/// Classes needed and Purpose: Only main class is needed
/// main class - Homework2_2
/// Import necessary C# or user-defined packages
/// Create main class and objects needed to implement task

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_2
{
    class Homework2_2
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
