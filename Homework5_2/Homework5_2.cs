using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_2
{
    class Homework5_2
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            int[] og_arr = new int[generator.Next(0, 21)];
            for (int i = 0; i < og_arr.Length; i++)
            {
                og_arr[i] = generator.Next(0, 101);
            }

            int[] copy_arr = new int[og_arr.Length];
            for (int i = 0; i < og_arr.Length; i++)
            {
                copy_arr[i] = og_arr[i];
            }

            for (int i = 0; i < og_arr.Length; i++)
            {
                Console.WriteLine("Original:{0}   Copy:{1}", og_arr[i], copy_arr[i]);
            }
            Console.WriteLine("LENGTH:{0}", og_arr.Length);
            Console.ReadLine();
        }
    }
}
