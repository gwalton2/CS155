using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variable # params method 1:");
            Console.WriteLine(Test.Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
            Console.WriteLine(Test.Sum(54, 63));
            Console.WriteLine();

            Console.WriteLine("Variable # params method 2:");
            Console.WriteLine(Test.Average(5, 5, 5, 5));
            Console.WriteLine(Test.Average(1, 2, 3));
            Console.WriteLine();

            Console.WriteLine("Named params method 1:");
            Console.WriteLine(Test.Name(first: "grant", middle: "christopher", last: "walton"));
            Console.WriteLine(Test.Name(last: "walton", middle: "christopher", first: "grant"));
            Console.WriteLine();

            Console.WriteLine("Named params method 2:");
            Console.WriteLine(Test.Range(min: 5, max: 25));
            Console.WriteLine(Test.Range(max: 25, min: 5));
            Console.WriteLine();

            Console.WriteLine("Optional params method 1:");
            Console.WriteLine(Test.Exponent(5));
            Console.WriteLine(Test.Exponent(5, 3));
            Console.WriteLine();

            Console.WriteLine("Optional params method 2:");
            Console.WriteLine(Test.RollDice());
            Console.WriteLine(Test.RollDice(20));
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
