using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11Lab2
{
    class Test
    {
        public static int Sum(params int[] numbers) //variable # params method 1
        {
            int total = 0;
            foreach (int num in numbers)
            {
                total += num;
            }
            return total;
        }

        public static double Average(params int[] numbers) //variable # params method 2
        {
            int total = 0;
            foreach (int num in numbers)
            {
                total += num;
            }
            return total / (double)numbers.Length;
        }

        public static string Name(string last, string middle, string first) //named params method 1
        {
            return first + " " + middle + " " + last;
        }

        public static int Range(int max, int min) //named params method 2
        {
            return max - min;
        }

        public static int Exponent(int num, int exp = 2) //optional params method 1
        {
            return (int)Math.Pow(num, exp);
        }

        public static int RollDice(int sides = 6) //optional params method 2
        {
            Random generator = new Random();
            return generator.Next(0, sides + 1);
        }
    }
}
