/// Homework No.2 Exercise No.1
/// File Name: Homework2_1.cs
/// @author: Grant Walton
/// Date: Sept. 14, 2018
/// Problem Statement: This program should take in the user's first and last name and return them
/// in pig latin form.
/// Overall Plan:
/// 1. I will print out a prompt for the user to input their first and last name.
/// 2. I will store these as string variables changed completely to lowercase using .ToLower()
/// 3. I will build the pig latin name by using substring, toUpper() and string concatenations on the orginal name.
/// 4. I will build the final output by concatenating the first and last name together.
/// 5. I will print this out to the console.

/// Classes needed and Purpose: Only main class is needed
/// main class - Homework2_1
/// Import necessary C# or user-defined packages
/// Create main class and objects needed to implement task

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_1
{
    class Homework2_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your first name then press enter.");
            string first = Console.ReadLine().ToLower();

            Console.WriteLine("Please input your last name then press enter.");
            string last = Console.ReadLine().ToLower();

            string pig_first = first.Substring(1, 1).ToUpper() + first.Substring(2) + first.Substring(0, 1) + "ay";
            string pig_last = last.Substring(1, 1).ToUpper() + last.Substring(2) + last.Substring(0, 1) + "ay";

            string pig_name = pig_first + " " + pig_last;
            Console.WriteLine(pig_name);
            Console.ReadLine();
        }
    }
}
