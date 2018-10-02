/// Homework No.5 Exercise No.3
/// File Name: Homework5_3.cs
/// @author: Grant Walton
/// Date: Oct. 1, 2018
/// Problem Statement: This program should randomly generate an integer array, print it out, and then
/// reverse the same array and print it out again. Only one integer array variable should be created.
/// Overall Plan:
/// 1. I will create a method that loops for a generated length adding random integers between 0 and 100 to the array.
/// 2. I will create a method that reverses an array passed in but does not return it. It modifies the orginal array.
/// 3. The reverse method will loop through half the array, switching the first and last indices
/// and working its way toward the middle. It will accomplish this by storing array elements in temporary variables.
/// 4. I will create a method to print out an array that uses a for each loop to print out each element.
/// 5. I will use these methods to randomly generate an array, print it out, reverse it, and print it out again.

/// Classes needed and Purpose: Only main class is needed
/// main class - Homework5_3
/// Import necessary C# or user-defined packages
/// Create main class and objects needed to implement task

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_3
{
    class Homework5_3
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            int[] arr = generateArray(generator.Next(0, 21), generator);
            Console.WriteLine("Original:");
            printArray(arr);
            Console.WriteLine();

            reverseArray(arr);
            Console.WriteLine("Reversed:");
            printArray(arr);
            Console.ReadLine();
        }

        static int[] generateArray(int length, Random generator)
        {
            int[] arr = new int[length];

            for (int i = 0; i < length; i++){
                arr[i] = generator.Next(0, 101);
            }
            return arr;
        }

        static void reverseArray(int[] arr)
        {
            for(int i = 0; i < arr.Length / 2; i++)
            {
                int rev_i = (arr.Length - 1) - i;
                int temp = arr[i];

                arr[i] = arr[rev_i];
                arr[rev_i] = temp;
            }
        }

        static void printArray(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
