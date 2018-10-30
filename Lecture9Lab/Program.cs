using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Email email1 = new Email();
            Email email2 = new Email("me", "you", "testing", "hey there");

            email1.SetSender("you");
            email1.SetRecipient("me");
            email1.SetTitle("testing reverse");
            email1.SetText("This is another test. Hi");

            File file1 = new File();
            File file2 = new File("User/me/passwords", "these are all my passwords:");

            file1.SetPath("Downloads");
            file1.SetText("testing my downloads");

            Console.WriteLine(email1.ToString());
            Console.WriteLine();

            Console.WriteLine(email2.ToString());
            Console.WriteLine();

            Console.WriteLine(file1.ToString());
            Console.WriteLine();

            Console.WriteLine(file2.ToString());
            Console.WriteLine();

            Console.WriteLine("Email1 contains 'reverse'");
            ContainsKeyword(email1, "reverse");
            Console.WriteLine();

            Console.WriteLine("Email2 contains 'reverse'");
            ContainsKeyword(email2, "reverse");
            Console.WriteLine();

            Console.WriteLine("File1 contains 'passwords'");
            ContainsKeyword(file1, "passwords");
            Console.WriteLine();

            Console.WriteLine("File2 contains 'passwords'");
            ContainsKeyword(file2, "passwords");
            Console.ReadLine();
        }

        public static void ContainsKeyword(Document docObject, string keyword)
        {
            if (docObject.ToString().IndexOf(keyword, 0) >= 0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
