/// Homework No.11 Exercise No.1
/// File Name: Homework_11.cs
/// @author: Grant Walton
/// Date: Nov. 26, 2018
/// Problem Statement: This program should test Student and StudentStats class by reading and writing to files.
/// Overall Plan:
/// 1. I will create the Students class which contains a first name, last name, and score. It will also implement
/// the Icomparable interface.
/// 2. I will also implement the StudentStats class which just contains a list of Students. It will also have method
/// to calculate the median and average of that list.
/// 3. In the main class I will read from the students.txt file and for each line I will use that info to make a new
/// Student and add it to a StudentStats instance. 
/// 4. I will then sort the list and use the Average and Median methods to write that info to a file called
/// studentstatx.txt.
/// 5. I will do this with files containing an odd and an even number of students to test the Median method.

/// Classes needed and Purpose: The StudentStats, Student, and main classes are needed to meet all the requirements.
/// main class - Homework_11
/// Import necessary C# or user-defined packages
/// Create main class and objects needed to implement task

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework_11
{
    class Homework_11
    {

        static void Main(string[] args)
        {
            StudentStats stats = new StudentStats();
            StudentStats stats1 = new StudentStats();

            using (StreamReader sr = new StreamReader("students.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] info = line.Split(' ');
                    stats.Add(new Student(info[0], info[1], Int32.Parse(info[2])));
                }
            }
            stats.Sort();
            using (StreamWriter file = new StreamWriter("studentstats.txt", false))
            {
                file.WriteLine("Average: {0}", stats.Average());
                file.WriteLine("Median: {0}", stats.Median());
            }

            using (StreamReader sr = new StreamReader("students1.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] info = line.Split(' ');
                    stats1.Add(new Student(info[0], info[1], Int32.Parse(info[2])));
                }
            }
            stats1.Sort();
            using (StreamWriter file = new StreamWriter("studentstats1.txt", false))
            {
                file.WriteLine("Average: {0}", stats1.Average());
                file.WriteLine("Median: {0}", stats1.Median());
            }
        }
    }
}
