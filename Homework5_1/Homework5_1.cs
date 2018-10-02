/// Homework No.5 Exercise No.1
/// File Name: Homework5_1.cs
/// @author: Grant Walton
/// Date: Oct. 1, 2018
/// Problem Statement: This program should create a triangle out of asterisks. The height should
/// go up to a number between 1 and 50 entered by the user.
/// Overall Plan:
/// 1. I will prompt the user to input an integer between 1 and 50.
/// 2. I will create a for loop that loops twice the size minus 1.
/// 3. Within the loop, if the variable is less than or equal to the size it prints out that number of asterisks.
/// 4. If it is greater than the size, it prints out (size * 2) - the loop variable number of asterisks.
///
/// Classes needed and Purpose: Only main class is needed
/// main class - Homework5_1
/// Import necessary C# or user-defined packages
/// Create main class and objects needed to implement task

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the size of the desired triangle as an integer from 1 to 50");
            int size = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < (size  * 2); i++)
            {
                if (i <= size)
                {
                    string ast = new String('*', i);
                    Console.WriteLine(ast);
                }
                else
                {
                    string ast = new String('*', (size * 2) - i);
                    Console.WriteLine(ast);
                }
            }
            Console.ReadLine();
        }
    }
}
