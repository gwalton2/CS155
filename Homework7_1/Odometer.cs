using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_1
{
    class Odometer
    {
        private int milage;
        private int fuel_usage;

        public Odometer()
        {
            milage = 0;
            fuel_usage = 0;
        }

        public Odometer(int milage, int fuel_usage)
        {
            this.milage = milage;
            this.fuel_usage = fuel_usage;
        }

        public void Reset()
        {
            milage = 0;
            fuel_usage = 0;
        }

        public void Add(int miles, int fuel)
        {
            milage += miles;
            fuel_usage += fuel;
        }

        public double MilesPerGallon()
        {
            if (fuel_usage == 0)
            {
                return 0;
            }
            else
            {
                return milage / (double)fuel_usage;
            }
        }

        public override string ToString()
        {
            return milage.ToString() + "miles " + fuel_usage.ToString() + "gallons: " + MilesPerGallon().ToString() + "mpg";
        }
    }
}
