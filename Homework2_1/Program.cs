using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your first name then press enter.");
            string first = Console.ReadLine().ToLower();

            Console.WriteLine("Please input your last name then press enter.");
            string last = Console.ReadLine().ToLower();

            string pig_first = first.Substring(1, 1).ToUpper() + first.Substring(2) + first.Substring(0, 1) + "ay";
            string pig_last = last.Substring(1, 1).ToUpper() + last.Substring(2) + last.Substring(0, 1) + "ay";

            string pig_name = pig_first + " " + pig_last;
            Console.WriteLine(pig_name);
            Console.ReadLine();
        }
    }
}
