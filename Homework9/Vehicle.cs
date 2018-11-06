using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    class Vehicle
    {
        public enum Manufacturer { Ford, Chevrolet, Toyota, Lexus };

        private Manufacturer manufacturer;
        private int cylinder;
        private Person owner;

        public Vehicle() { }

        public Vehicle(Manufacturer manufacturer, int cylinder, Person owner)
        {
            this.manufacturer = manufacturer;
            this.cylinder = cylinder;
            this.owner = owner;
        }

        public int Cylinder
        {
            get { return cylinder; }
            set { cylinder = value; }
        }

        public void SetManufacturer(Manufacturer manufacturer)
        {
            this.manufacturer = manufacturer;
        }

        public void SetOwner(Person owner)
        {
            this.owner = owner;
        }

        public Manufacturer GetManufacturer()
        {
            return manufacturer;
        }

        public Person GetOwner()
        {
            return owner;
        }

        public override string ToString()
        {
            string str_manu;

            switch ((int)manufacturer)
            {
                case 0:
                    str_manu = "Ford";
                    break;
                case 1:
                    str_manu = "Chevrolet";
                    break;
                case 2:
                    str_manu = "Toyota";
                    break;
                case 3:
                    str_manu = "Lexus";
                    break;
                default:
                    str_manu = "";
                    break;
            }
                return owner.ToString() + " owns a " + str_manu + " with " + cylinder + " cylinders";
            }

        public override bool Equals(object obj)
        {
            Vehicle other = (Vehicle)obj;

            return (int)manufacturer == (int)other.GetManufacturer() && 
                cylinder == other.Cylinder && 
                owner.GetName().Equals(other.GetOwner().GetName());
        }
    }
}
