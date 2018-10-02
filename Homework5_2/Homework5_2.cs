/// Homework No.5 Exercise No.2
/// File Name: Homework5_2.cs
/// @author: Grant Walton
/// Date: Oct. 1, 2018
/// Problem Statement: This program should randomly generate an integer array and then create
/// a new array that is a copy of the original.
/// Overall Plan:
/// 1. I will create a random number generator that I will use to make an array between length 0 and 20.
/// 2. I will then loop for the generated length adding random integers between 0 and 100 to the array.
/// 3. I will then create a new integer array of the same length.
/// 4. I will loop for the length of the array accessing the original array and placing the same
/// number into the new array.
/// 5. I will print both arrays out to the console.

/// Classes needed and Purpose: Only main class is needed
/// main class - Homework5_2
/// Import necessary C# or user-defined packages
/// Create main class and objects needed to implement task
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_2
{
    class Homework5_2
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            int[] og_arr = new int[generator.Next(0, 21)];
            for (int i = 0; i < og_arr.Length; i++)
            {
                og_arr[i] = generator.Next(0, 101);
            }

            int[] copy_arr = new int[og_arr.Length];
            for (int i = 0; i < og_arr.Length; i++)
            {
                copy_arr[i] = og_arr[i];
            }

            for (int i = 0; i < og_arr.Length; i++)
            {
                Console.WriteLine("Original:{0}   Copy:{1}", og_arr[i], copy_arr[i]);
            }
            Console.WriteLine("LENGTH:{0}", og_arr.Length);
            Console.ReadLine();
        }
    }
}
