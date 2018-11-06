using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook mybook = new PhoneBook();
            mybook.Add("Grant", 2607789);
            mybook.Add("Bob", 7858093);
            mybook.Add("Joe", 8993456);
            mybook.Add("Mom", 9998888);

            Console.WriteLine(mybook.ToString());
            Console.WriteLine();

            

            Console.WriteLine("Type 'Add' to add a phone number, 'Find' to find a current number, or 'Delete' to delete a current number");
            string input = Console.ReadLine();

            if (input.Equals("Add"))
            {
                Console.WriteLine("Type the name you want to add and press enter. Then enter their phone number and press enter");
                string name = Console.ReadLine();
                int number = Int32.Parse(Console.ReadLine());
                mybook.Add(name, number);
                Console.WriteLine(mybook.ToString());
            }
            else if (input.Equals("Find"))
            {
                Console.WriteLine("Type the name of whose number you would like to find and press enter");
                string name = Console.ReadLine();
                try
                {
                    Console.WriteLine(mybook.FindNumber(name));
                }
                catch (KeyNotFoundException)
                {
                    Console.WriteLine(name + " is not in phonebook");
                }

            }
            else if (input.Equals("Delete"))
            {
                Console.WriteLine("Type the name the person you'd like to delete and press enter");
                string name = Console.ReadLine();
                mybook.Delete(name);
                Console.WriteLine(mybook.ToString());
            }
            else
            {
                Console.WriteLine("invalid input");
            }

            Console.ReadLine();
        }
    }
}
