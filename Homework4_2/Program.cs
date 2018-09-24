using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int heads = 0;
            int tails = 0;

            for (int i = 0; i < 8;)
            {
                Console.WriteLine("Please input an h for heads or a t for tails and press enter. {0}/8", i+1);
                string coin = Console.ReadLine();

                if (coin.Equals("h"))
                {
                    heads++;
                    i++;
                    total++;
                }
                else if (coin.Equals("t"))
                {
                    tails++;
                    i++;
                    total++;
                }
                else
                {
                    Console.WriteLine("Your input did not match the expected format of h or t. Please try again.");
                }
            }
            double percent_h = heads / (double)total;
            double percent_t = tails / (double)total;

            Console.WriteLine("Number of heads: {0}", heads);
            Console.WriteLine("Number of tails: {0}", tails);
            Console.WriteLine("Percent heads: {0}", percent_h.ToString("P"));
            Console.WriteLine("Percent tails: {0}", percent_t.ToString("P"));
            Console.ReadLine();
        }
    }
}
