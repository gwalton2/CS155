/// Homework No.4 Exercise No.2
/// File Name: Homework4_2.cs
/// @author: Grant Walton
/// Date: Sept. 24, 2018
/// Problem Statement: This program should take in 8 coin flips and print out statistics on them.
/// Overall Plan:
/// 1. The overall structure of the program will be a while loop that runs until the total flips hit 8.
/// 2. Each loop will ask the user to input an h or a t for heads or tails.
/// 3. The program will then increment heads or tails variable accordingly.
/// 4. If the input is incorrectly formatted then the total will not be incremented and the program will loop an extra time.
/// 5. After the loop is exited. The program will print out the total number of heads and tails and the precents associated with each.

/// Classes needed and Purpose: Only main class is needed
/// main class - Homework4_2
/// Import necessary C# or user-defined packages
/// Create main class and objects needed to implement task

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_2
{
    class Homework4_2
    {
        static void Main(string[] args)
        {
            int total = 0;
            int heads = 0;
            int tails = 0;

            while (total < 8)
            {
                Console.WriteLine("Please input an h for heads or a t for tails and press enter. {0}/8", total+1);
                string coin = Console.ReadLine();

                if (coin.Equals("h"))
                {
                    heads++;
                    total++;
                }
                else if (coin.Equals("t"))
                {
                    tails++;
                    total++;
                }
                else
                {
                    Console.WriteLine("Your input did not match the expected format of h or t. Please try again.");
                }
            }
            double percent_h = heads / (double)total;
            double percent_t = tails / (double)total;

            Console.WriteLine("Number of heads: {0}", heads);
            Console.WriteLine("Number of tails: {0}", tails);
            Console.WriteLine("Percent heads: {0}", percent_h.ToString("P"));
            Console.WriteLine("Percent tails: {0}", percent_t.ToString("P"));
            Console.ReadLine();
        }
    }
}
