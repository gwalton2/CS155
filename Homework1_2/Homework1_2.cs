/// Homework No.1 Exercise No.2
/// File Name: Homework1_2.cs
/// @author: Grant Walton
/// Date: Sept. 14, 2018
/// Problem Statement: This program should print out a series of characters as ascii art to the console.
/// Overall Plan:
/// 1. I will use determine the drawing I intend to make on paper.
/// 2. I will implement this drawing in ascii using WriteLine statements.

/// Classes needed and Purpose: Only main class is needed
/// main class - Homework1_2
/// Import necessary C# or user-defined packages
/// Create main class and objects needed to implement task

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_2
{
    class Homework1_2
    {
        static void Main(string[] args)
        {
            //Begin ascii art
            Console.WriteLine("|||||||||||||||||||||||                             #####            #####");
            Console.WriteLine("|||||||||||||||||||||||                            #####            #####");
            Console.WriteLine("|||||||           |||||                          #####            #####");
            Console.WriteLine("|||||||                                         #####            #####");
            Console.WriteLine("|||||||                            ############################################");
            Console.WriteLine("|||||||                            ############################################");
            Console.WriteLine("|||||||                                    #####            #####");
            Console.WriteLine("|||||||                                   #####            #####");
            Console.WriteLine("|||||||                        ###########################################");
            Console.WriteLine("|||||||                        ###########################################");
            Console.WriteLine("|||||||                              #####            #####");
            Console.WriteLine("|||||||           |||||             #####            #####");
            Console.WriteLine("|||||||||||||||||||||||           #####            #####");
            Console.WriteLine("|||||||||||||||||||||||          #####            #####");

            //Just to pause the screen.
            Console.ReadLine();
        }
    }
}
