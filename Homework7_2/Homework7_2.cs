/// Homework No.7 Exercise No.2
/// File Name: Homework7_2.cs
/// @author: Grant Walton
/// Date: Oct. 22, 2018
/// Problem Statement: This program should use a class to convert and manipulate temperatures.
/// Overall Plan:
/// 1. I will create the Temperature class with two instance variables, temperature and scale(C or F).
/// 2. I will implement constructors, getters, setters, converters, tostring, and an equals method.
/// 3. I will implement a driver class to test my code.

/// Classes needed and Purpose: Only main class is needed
/// main class - Homework7_2
/// Import necessary C# or user-defined packages
/// Create main class and objects needed to implement task

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_2
{
    class Homework7_2
    {
        static void Main(string[] args)
        {
            Temperature temp1 = new Temperature();
            Temperature temp2;
            Temperature temp3;
            Temperature temp4 = new Temperature(0, 'F');

            Console.WriteLine("Enter the scale, either F or C, you would like temp2 to be in and press enter");
            char[] scale2 = Console.ReadLine().ToCharArray();
            temp2 = new Temperature(scale2[0]);

            Console.WriteLine("Enter the temperature you would like temp3 to be and press enter");
            temp3 = new Temperature(Double.Parse(Console.ReadLine()));

            Console.WriteLine("Enter the scale for temp1 and press enter. Do the same for its temperature");
            char[] scale1 = Console.ReadLine().ToCharArray();
            temp1.SetBoth(Double.Parse(Console.ReadLine()), scale1[0]);

            Console.WriteLine("Enter the temperature you would like temp4 to be at and press enter");
            temp4.SetTemperature(Double.Parse(Console.ReadLine()));

            Console.WriteLine("Enter the scale you would like temp3 to be in and press enter");
            char[] scale3 = Console.ReadLine().ToCharArray();
            temp3.SetScale(scale3[0]);

            Console.WriteLine("temp1: {0} \n{1}C \n{2}F", temp1.ToString(), temp1.GetTemperatureC().ToString(), temp1.GetTemperatureF().ToString());
            Console.WriteLine("temp3: {0} \n{1}C \n{2}F", temp3.ToString(), temp3.GetTemperatureC().ToString(), temp3.GetTemperatureF().ToString());

            Console.WriteLine("temp1 is equal to temp2:");
            if (temp1.Equals(temp2))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.WriteLine("temp3 is equal to temp4:");
            if (temp3.Equals(temp4))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.ReadLine();
        }
    }
}
