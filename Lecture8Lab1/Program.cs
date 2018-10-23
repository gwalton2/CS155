using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction();
            Console.WriteLine("Input the numerator and press enter. Do the same for the denominator");
            f1.Numerator = Int32.Parse(Console.ReadLine());
            f1.Denominator = Int32.Parse(Console.ReadLine());
            Console.WriteLine(f1.ToString());
            Console.WriteLine(f1.SimplifyString());
            Console.WriteLine(f1.GetDecimal().ToString());
            Console.WriteLine();

            Console.WriteLine("Input the amount to increase the numerator by and press enter. Do the same for the denominator");
            UpdateFraction(f1, Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));
            Console.WriteLine("Withing Main: {0}", f1.ToString());

            Fraction f2 = new Fraction();
            Console.WriteLine("Input the numerator and press enter. Do the same for the denominator");
            f2.Numerator = Int32.Parse(Console.ReadLine());
            f2.Denominator = Int32.Parse(Console.ReadLine());
            Console.WriteLine(f2.ToString());
            Console.WriteLine(f2.SimplifyString());
            Console.WriteLine(f2.GetDecimal().ToString());
            Console.WriteLine();

            Console.WriteLine("Input the amount to increase the numerator by and press enter. Do the same for the denominator");
            UpdateFraction(f2, Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));
            Console.WriteLine("Withing Main: {0}", f2.ToString());

            if (f1.Equals(f2))
            {
                Console.WriteLine("Fractions are equal");
            }
            else
            {
                Console.WriteLine("Fractions are NOT equal");
            }

            Console.ReadLine();
        }

        static void UpdateFraction(Fraction frac, int numerator, int denominator)
        {
            frac.Denominator += denominator;
            frac.Numerator += numerator;

            Console.WriteLine("Within UpdateFraction:");
            Console.WriteLine(frac.ToString());
            Console.WriteLine(frac.SimplifyString());
            Console.WriteLine(frac.GetDecimal().ToString());
            Console.WriteLine();
        }
    }
}
