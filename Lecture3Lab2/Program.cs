using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So your lamp doesn't work.\nIs your lamp plugged in? Please answer Yes or No and press enter.");
            string ans1 = Console.ReadLine().ToLower().Trim();

            if (ans1.Equals("no"))
            {
                Console.WriteLine("Plug in your lamp");
            }

            else
            {
                Console.WriteLine("Is your bulb burned out? Please answer Yes or No and press enter.");
                string ans2 = Console.ReadLine().ToLower().Trim();

                if (ans2.Equals("no"))
                {
                    Console.WriteLine("Repair your lamp");
                }

                else
                {
                    Console.WriteLine("Replace the bulb");
                }
            }
            Console.ReadLine();
        }
    }
}
