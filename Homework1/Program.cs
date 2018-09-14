/// Homework No.1 Exercise No.1
/// File Name: Homework1.cs
/// @author: Grant Walton
/// Date: Sept. 14, 2018
/// Problem Statement: This program should take two numbers as user input and return their sum
/// Overall Plan:
/// 1. I will print out a prompt for the user to input their two numbers
/// 2. I will take those inputs and parse them into integers.
/// 3. I will add those numbers into a new integer value
/// 4. I will print out the result to the console

/// Classes needed and Purpose: Only main class is needed
/// main class - Homework1
/// Import necessary C# or user-defined packages
/// Create main class and objects needed to implement task

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Homework1
    {
        static void Main(string[] args)
        {
            //Print a message to the screen
            Console.WriteLine("Hello out there.");
            Console.WriteLine("I will add two numbers for you.");
            Console.WriteLine("Enter one number and press enter, then enter second number and press enter:");

            // declare two integer variables
            int n1, n2, sum;
            string userInput;
            userInput = Console.ReadLine();
            n1 = Int32.Parse(userInput);
            n2 = Int32.Parse(Console.ReadLine());

            // calculate the sum of these two numbers
            sum = n1 + n2;

            // print a message along with the sum of the two numbers
            Console.WriteLine("The sum of those two numbers is");
            Console.WriteLine(sum);

            //Just to pause the screen.
            Console.ReadLine();
        }
    }
}
