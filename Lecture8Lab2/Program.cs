using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            CashPayment cash1 = new CashPayment(10.35);
            CashPayment cash2 = new CashPayment(0);

            cash2.SetAmount(5.5);

            Console.WriteLine("Cash1: {0}", cash1.PaymentDetails());
            Console.WriteLine("Cash2: {0}", cash2.PaymentDetails());
            Console.WriteLine();

            CreditCardPayment credit1 = new CreditCardPayment(75.1, "Grant Walton", 775634265422);
            CreditCardPayment credit2 = new CreditCardPayment(45, "Ollie", 0);

            credit2.SetNumber(22222222222222);
            credit2.SetName("Ollie Walton");

            Console.WriteLine("Credit1: {0}", credit1.PaymentDetails());
            Console.WriteLine("Credit2: {0}", credit2.PaymentDetails());

            Console.ReadLine();
        }
    }
}
