using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8Lab1
{
    struct Fraction
    {
        private int _numerator;
        private int _denominator;

        public int Numerator
        {
            get
            {
                return _numerator;
            }
            set
            {
                _numerator = value;
            }
        }

        public int Denominator
        {
            get
            {
                return _denominator;
            }
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Can't set denominator to zero");
                }
                else
                {
                    _denominator = value;
                }
            }
        }

        public double GetDecimal()
        {
            return Math.Round(_numerator / (double)_denominator, 2);
        }

        public string SimplifyString()
        {
            int min;
            int gcd = 0;
            if (_numerator == 0)
            {
                min = 1;
            }
            else
            {
                min = Math.Min(Math.Abs(_numerator), Math.Abs(_denominator));
            }

            for (int i = min; i >= 1; i--)
            {
                if (_numerator % i == 0 && _denominator % i == 0)
                {
                    gcd = i;
                    break;
                }
            }
            return (_numerator / gcd).ToString() + "/" + (_denominator / gcd).ToString();
        }

        public override string ToString()
        {
            return _numerator.ToString() + "/" + _denominator.ToString();
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
