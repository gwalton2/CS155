using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza p1 = new Pizza();

            Console.WriteLine("Enter size(small, medium, or large) and press enter.");
            string size = Console.ReadLine();
            if (size.Equals("small"))
            {
                p1.SetSize(Pizza.PizzaSize.small);
            }
            else if (size.Equals("medium"))
            {
                p1.SetSize(Pizza.PizzaSize.medium);
            }
            else
            {
                p1.SetSize(Pizza.PizzaSize.large);
            }

            Console.WriteLine("Enter the number of cheese toppings as an integer and press enter");
            p1.SetCheese(Int32.Parse(Console.ReadLine()));

            Console.WriteLine("Enter the number of pepperoni toppings as an integer and press enter");
            p1.SetPepperoni(Int32.Parse(Console.ReadLine()));

            Console.WriteLine("Enter the number of ham toppings as an integer and press enter");
            p1.SetHam(Int32.Parse(Console.ReadLine()));

            Console.WriteLine("Pizza 1:\n" + p1.ToString());
            Console.WriteLine();

            Pizza p2 = new Pizza(Pizza.PizzaSize.medium, 5, 10, 2);

            Console.WriteLine(p2.GetHam().ToString());
            Console.WriteLine(p2.GetPepperoni().ToString());
            Console.WriteLine(p2.GetCheese().ToString());
            Console.WriteLine(p2.CalculateCost().ToString());
            Console.WriteLine();

            Console.WriteLine("Pizza 2:\n" + p2.ToString());
            Console.WriteLine();

            if (p1.Equals(p2))
            {
                Console.WriteLine("the pizzas are equal!");
            }
            else
            {
                Console.WriteLine("the pizzas are not equal");
            }

            Console.ReadLine();
        }
    }
}
