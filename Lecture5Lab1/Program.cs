using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess;
            int num_guess = 0;
            Random generator = new Random();
            int rand = generator.Next(0, 101);

            do
            {
                Console.WriteLine("Enter your guess as an integer between 0 and 100");
                guess = Int32.Parse(Console.ReadLine());

                if (guess < rand)
                {
                    Console.WriteLine("{0} is LOWER than my number", guess);
                }

                else if (guess > rand)
                {
                    Console.WriteLine("{0} is HIGHER than my number", guess);
                }

                num_guess++;

            } while (guess != rand);

            Console.WriteLine("{0} is CORRECT! It only took you {1} guesses.", guess, num_guess);
            Console.ReadLine();
        }
    }
}
