using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture12Lab1
{
    class Program
    {
        delegate int MathDelegate(int a, int b);

        static void Main(string[] args)
        {
            MathDelegate mydelegate;

            mydelegate = Multiply;
            Console.WriteLine(mydelegate(5, 6));

            mydelegate = Subtract;
            Console.WriteLine(mydelegate(10, 2));

            Console.ReadLine();
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
