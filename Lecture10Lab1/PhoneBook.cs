using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10Lab1
{
    class PhoneBook
    {
        private Dictionary<string, int> book;

        public PhoneBook()
        {
            book = new Dictionary<string, int>();
        }

        public void Add(string name, int number)
        {
            book.Add(name, number);
        }

        public int FindNumber(string name)
        {
            return book[name];
        }

        public void Delete(string name)
        {
            book.Remove(name);
        }

        public override string ToString()
        {
            string str_book = "";
            foreach(KeyValuePair<string, int> entry in book)
            {
                str_book += entry.Key + ": " + entry.Value + "\n";
            }

            return str_book;
        }
    }
}
