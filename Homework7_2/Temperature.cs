using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_2
{
    class Temperature
    {
        private double temperature;
        private char scale;

        public Temperature()
        {
            temperature = 0;
            scale = 'C';
        }

        public Temperature(double temperature)
        {
            SetTemperature(temperature);
        }

        public Temperature(char scale)
        {
            SetScale(scale);
        }

        public Temperature(double temperature, char scale)
        {
            SetTemperature(temperature);
            SetScale(scale);
        }

        public void SetScale(char scale)
        {
            if (scale.Equals('F'))
            {
                this.scale = scale;
            }
            else
            {
                this.scale = 'C';
            }
        }

        public void SetTemperature(double temperature)
        {
            this.temperature = temperature;
        }

        public void SetBoth(double temperature, char scale)
        {
            SetScale(scale);
            SetTemperature(temperature);
        }

        public double GetTemperatureF()
        {
            if (scale.Equals('F'))
            {
                return Math.Round(temperature, 1);
            }
            else
            {
                double faren = (temperature * 1.8) + 32;
                return Math.Round(faren, 1);
            }
        }

        public double GetTemperatureC()
        {
            if (scale.Equals('C'))
            {
                return Math.Round(temperature, 1);
            }
            else
            {
                double cels = (temperature - 32) / 1.8;
                return Math.Round(cels, 1);
            }
        }

        public override string ToString()
        {
            return temperature.ToString() + scale;
        }

        public override bool Equals(object obj)
        {
            Temperature otherTemp = (Temperature)obj;

            double mytemp = Math.Round(temperature, 1);
            double othertemp;

            if (scale.Equals('F'))
            {
                othertemp = otherTemp.GetTemperatureF();
            }
            else
            {
                othertemp = otherTemp.GetTemperatureC();
            }

            return mytemp == othertemp;
        }
    }
}
