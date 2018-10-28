using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class Duelist
    {
        private bool _alive = true;

        private Random generator = new Random();

        private double accuracy;
        private string name;

        public Duelist(string name, double accuracy)
        {
            this.name = name;
            this.accuracy = accuracy;
        }

        public string GetName()
        {
            return name;
        }

        public double GetAccuracy()
        {
            return Math.Round(accuracy, 2);
        }

        public bool Alive
        {
            get
            {
                return _alive;
            }

            set
            {
                _alive = value;
            }
        }

        public void ShootAtTarget(Duelist target)
        {
            double rand = generator.NextDouble();
            if (rand < accuracy)
            {
                target.Alive = false;
            }
        }

        public override bool Equals(object obj)
        {
            Duelist other = (Duelist)obj;

            if (GetAccuracy() == other.GetAccuracy() && GetName().Equals(other.GetName()))
            {
                return true;
            }
            return false;
        }
    }
}
