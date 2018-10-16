using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7Lab1
{
    class Pizza
    {
        public enum PizzaSize { small = 10, medium = 12, large = 14 };

        private PizzaSize size;
        private int cheese;
        private int pepperoni;
        private int ham;

        public Pizza()
        {
            size = PizzaSize.small;
            cheese = 0;
            pepperoni = 0;
            ham = 0;
        }

        public Pizza(PizzaSize size, int cheese, int pepperoni, int ham)
        {
            this.size = size;
            SetCheese(cheese);
            SetPepperoni(pepperoni);
            SetHam(ham);
        }

        public void SetSize(PizzaSize size)
        {
            this.size = size;
        }

        public void SetCheese(int cheese)
        {
            if (cheese >= 0)
            {
                this.cheese = cheese;
            }
            else
            {
                this.cheese = 0;
            }
        }

        public void SetPepperoni(int pepperoni)
        {
            if (pepperoni >= 0)
            {
                this.pepperoni = pepperoni;
            }
            else
            {
                this.pepperoni = 0;
            }
        }

        public void SetHam(int ham)
        {
            if (ham >= 0)
            {
                this.ham = ham;
            }
            else
            {
                this.ham = 0;
            }
        }

        public PizzaSize GetSize()
        {
            return size;
        }

        public int GetCheese()
        {
            return cheese;
        }

        public int GetPepperoni()
        {
            return pepperoni;
        }

        public int GetHam()
        {
            return ham;
        }

        public double CalculateCost()
        {
            double initial =  (double)size;
            double extra = (cheese + ham + pepperoni) * 2;

            return initial + extra;
        }

        public override string ToString()
        {
            string st_size = "Size: ";
            switch ((int)size)
            {
                case 10:
                    st_size += "small";
                    break;
                case 12:
                    st_size += "medium";
                    break;
                case 14:
                    st_size += "large";
                    break;
            }
            string st_cheese = "Cheese: " + cheese.ToString();
            string st_pepperoni = "Pepperoni: " + pepperoni.ToString();
            string st_ham = "Ham: " + ham.ToString();
            string st_cost = "Cost: " + CalculateCost().ToString("C");

            return st_size + "\n" + st_cheese + "\n" + st_pepperoni + "\n" + st_ham + "\n" + st_cost;
        }

        public override bool Equals(object obj)
        {
            Pizza oth_pizza = (Pizza)obj;
            
            if (CalculateCost() == oth_pizza.CalculateCost() && cheese == oth_pizza.GetCheese() &&
                pepperoni == oth_pizza.GetPepperoni() && ham == oth_pizza.GetHam())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
