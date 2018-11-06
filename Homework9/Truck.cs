using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    class Truck : Vehicle
    {
        private double load;
        private int towing;

        public Truck() { }

        public Truck(Manufacturer manufacturer, int cylinder, Person owner, double load, int towing) : base(manufacturer, cylinder, owner)
        {
            this.load = load;
            this.towing = towing;
        }

        public double Load
        {
            get { return load; }
            set { load = value; }
        }

        public int Towing
        {
            get { return towing; }
            set { towing = value; }
        }

        public override bool Equals(object obj)
        {
            Truck other = (Truck)obj;
            return load == other.Load && towing == other.Towing && base.Equals(obj); 
        }

        public override string ToString()
        {
            string first = base.ToString();
            return first + "," + load + "ton load capacity,and " + towing + "lb towing capacity";
        }
    }
}
