using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_3
{
    class Homework5_3
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            int[] arr = generateArray(generator.Next(0, 21), generator);
            Console.WriteLine("Original:");
            printArray(arr);
            Console.WriteLine();

            reverseArray(arr);
            Console.WriteLine("Reversed:");
            printArray(arr);
            Console.ReadLine();
        }

        static int[] generateArray(int length, Random generator)
        {
            int[] arr = new int[length];

            for (int i = 0; i < length; i++){
                arr[i] = generator.Next(0, 101);
            }
            return arr;
        }

        static void reverseArray(int[] arr)
        {
            for(int i = 0; i < arr.Length / 2; i++)
            {
                int rev_i = (arr.Length - 1) - i;
                int temp = arr[i];

                arr[i] = arr[rev_i];
                arr[rev_i] = temp;
            }
        }

        static void printArray(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
