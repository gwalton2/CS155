using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Lab2
{
    class Fraction
    {
        int numerator;
        int denominator;

        public void SetNumerator(int numerator)
        {
            this.numerator = numerator;
        }

        public void SetDenominator(int denominator)
        {
            if (denominator == 0)
            {
                Console.WriteLine("Can't set the denominator to zero");
            }
            else
            {
                this.denominator = denominator;
            }
        }

        public double GetDecimal()
        {
            return Math.Round(numerator / (double)denominator, 2);
        }

        public string SimplifyString()
        {
            int min;
            int gcd = 0;
            if (numerator == 0)
            {
                min = 1;
            }
            else
            {
                min = Math.Min(numerator, denominator);
            }

            for (int i = min; i >= 1; i--)
            {
                if (numerator % i == 0 && denominator % i == 0)
                {
                    gcd = i;
                    break;
                }
            }
            return (numerator / gcd).ToString() + "/" + (denominator / gcd).ToString();
        }

        public override string ToString()
        {
            return numerator.ToString() + "/" + denominator.ToString();
        }

        public override bool Equals(object obj)
        {
            Fraction otherFrac = (Fraction)obj;
            double var1 = otherFrac.GetDecimal();
            double var2 = this.GetDecimal();
            return var1 == var2;
        }
    }
}
