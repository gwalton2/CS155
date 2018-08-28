using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print a message to the screen
            Console.WriteLine("Hello out there.");
            Console.WriteLine("I will perform several operations on three numbers for you.");
            Console.WriteLine("Enter one number and press enter, then enter second number and press enter, then the third number and press enter:");

            // declare six variables
            int n1, n2, n3, sum, prod;
            double div;

            n1 = Int32.Parse(Console.ReadLine());
            n2 = Int32.Parse(Console.ReadLine());
            n3 = Int32.Parse(Console.ReadLine());

            // calculate the sum and product of these three numbers
            sum = n1 + n2 + n3;
            prod = n1 * n2 * n3;
            div = sum / (double)prod;


            // print a message along with the values derived from the three numbers
            Console.WriteLine("\n The sum of those three numbers is");
            Console.WriteLine(sum);

            Console.WriteLine("\n The product of those three numbers is");
            Console.WriteLine(prod);

            Console.WriteLine("\n The sum divided by the product is");
            Console.WriteLine(div);

            //Just to pause the screen.
            Console.ReadLine();
        }
    }
}
