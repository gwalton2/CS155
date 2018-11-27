using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture12Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(1, 2, 3);
            Vector v2 = new Vector(5, 4, -2);
            Console.WriteLine("Vector1: {0}, {1}, {2}", v1.X, v1.Y, v1.Z);
            Console.WriteLine("Vector2: {0}, {1}, {2}", v2.X, v2.Y, v2.Z);

            Vector v_add = v1 + v2;
            Console.WriteLine("Adding: {0}, {1}, {2}", v_add.X, v_add.Y, v_add.Z);

            Vector v_sub = v1 - v2;
            Console.WriteLine("Subtracting: {0}, {1}, {2}", v_sub.X, v_sub.Y, v_sub.Z);

            Vector v_mul = v1 * 2;
            Console.WriteLine("v1 times 2: {0}, {1}, {2}", v_mul.X, v_mul.Y, v_mul.Z);

            Vector v_div = v_mul / 2;
            Console.WriteLine("Divided by 2: {0}, {1}, {2}", v_div.X, v_div.Y, v_div.Z);

            Vector v_neg = -v2;
            Console.WriteLine("Negative v2: {0}, {1}, {2}", v_neg.X, v_neg.Y, v_neg.Z);

            Console.ReadLine();
        }
    }
}
