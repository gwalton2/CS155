using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5Lab2
{
    class Program
    {
        public enum Coin {Heads, Tails};
        public const int FLIP_NUM = 10000;

        static void Main(string[] args)
        {
            Coin[] flip_arr = new Coin[FLIP_NUM];
            Random generator = new Random();

            for (int i = 0; i < FLIP_NUM; i++)
            {
                Coin rand_flip = flipCoin(generator);
                flip_arr[i] = rand_flip;
            }
            printFlips(flip_arr);
        }

        static Coin flipCoin(Random generator)
        {
            int flip = generator.Next(2);

            if (flip == 1)
            {
                return Coin.Heads;
            }
            else
            {
                return Coin.Tails;
            }
        }

        static void printFlips(Coin[] coin_flips)
        {
            int heads = 0;
            int tails = 0;

            foreach (Coin flip in coin_flips)
            {
                if (flip == Coin.Heads)
                {
                    Console.WriteLine("H");
                    heads++;
                }
                else
                {
                    Console.WriteLine("T");
                    tails++;
                }
            }
            Console.WriteLine("For {0} flips:", FLIP_NUM);
            Console.WriteLine("Heads: {0:p}", heads / (double)FLIP_NUM);
            Console.WriteLine("Tails: {0:p}", tails / (double)FLIP_NUM);
            Console.ReadLine();
        } 
    }
}
