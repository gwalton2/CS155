/// Homework No.7 Exercise No.1
/// File Name: Homework7_1.cs
/// @author: Grant Walton
/// Date: Oct. 22, 2018
/// Problem Statement: This program should use a class to keep track of miles per gallon.
/// Overall Plan:
/// 1. I will create the Odometer class with two instance variables, milage and fuel used.
/// 2. I will implement constructors, an add, reset, and tostring method.
/// 3. I will implement a driver class to test my code.

/// Classes needed and Purpose: Only main class is needed
/// main class - Homework7_1
/// Import necessary C# or user-defined packages
/// Create main class and objects needed to implement task

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_1
{
    class Homework7_1
    {
        static void Main(string[] args)
        {
            Odometer od1 = new Odometer();

            Console.WriteLine("Please enter the miles and press enter and then the fuel used and press enter.");
            Odometer od2 = new Odometer(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));
            Console.WriteLine(od2.ToString());

            od1.Add(32, 10);
            Console.WriteLine("other odometer: {0}", od1.ToString());
            od1.Reset();

            Console.WriteLine("Please enter the miles you would like to add and press enter. Then do the same for fuel used.");
            od2.Add(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));
            Console.WriteLine(od2.ToString());

            Console.WriteLine("other odometer after resetting: {0}", od1.ToString());

            Console.ReadLine();
        }
    }
}
