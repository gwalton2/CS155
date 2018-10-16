using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction();
            f1.Numerator = 5;
            f1.Denominator = 10;
            Console.WriteLine(f1.ToString());
            Console.WriteLine(f1.SimplifyString());
            Console.WriteLine(f1.GetDecimal().ToString());
            Console.WriteLine();

            f1.Denominator += 10;
            f1.Numerator -= 10;
            Console.WriteLine(f1.ToString());
            Console.WriteLine(f1.SimplifyString());
            Console.WriteLine(f1.GetDecimal().ToString());
            Console.WriteLine();

            Fraction f2 = new Fraction();
            f2.Numerator = 10;
            f2.Denominator = 0;
            f2.Denominator = 10;
            Console.WriteLine(f2.ToString());
            Console.WriteLine(f2.SimplifyString());
            Console.WriteLine(f2.GetDecimal().ToString());
            Console.WriteLine();

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
    }
}
