using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the size of the desired triangle as an integer from 1 to 50");
            int size = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= (size  * 2); i++)
            {
                if (i <= size)
                {
                    string ast = new String('*', i);
                    Console.WriteLine(ast);
                }
                else
                {
                    string ast = new String('*', (size * 2) - i);
                    Console.WriteLine(ast);
                }
            }
            Console.ReadLine();
        }
    }
}
