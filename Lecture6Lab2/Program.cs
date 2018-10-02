using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the numerator and press enter. Then enter the denominator and press enter");
            Fraction myfrac1 = new Fraction();
            myfrac1.SetNumerator(Int32.Parse(Console.ReadLine()));
            myfrac1.SetDenominator(Int32.Parse(Console.ReadLine()));
            Console.WriteLine(myfrac1.ToString());
            Console.WriteLine(myfrac1.GetDecimal().ToString());
            Console.WriteLine(myfrac1.SimplifyString());

            Console.WriteLine("Please another the numerator and press enter. Then enter another denominator and press enter");
            Fraction myfrac2 = new Fraction();
            myfrac2.SetNumerator(Int32.Parse(Console.ReadLine()));
            myfrac2.SetDenominator(Int32.Parse(Console.ReadLine()));
            Console.WriteLine(myfrac2.ToString());
            Console.WriteLine(myfrac2.GetDecimal().ToString());
            Console.WriteLine(myfrac2.SimplifyString());

            if (myfrac1.Equals(myfrac2))
            {
                Console.WriteLine("these fractions are ARE equal");
            }
            else
            {
                Console.WriteLine("these fractions NOT equal");
            }

            Console.ReadLine();
        }
    }
}
