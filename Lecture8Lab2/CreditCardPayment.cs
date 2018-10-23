using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8Lab2
{
    class CreditCardPayment : Payment
    {
        private string name;
        private long number;

        public CreditCardPayment(double amount, string name, long number) : base(amount)
        {
            SetName(name);
            SetNumber(number);
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetNumber(long number)
        {
            this.number = number;
        }

        public string GetName()
        {
            return name;
        }

        public long GetNumber()
        {
            return number;
        }

        public override string PaymentDetails()
        {
            return base.PaymentDetails() + " for " + name + " " + number.ToString();
        }
    }
}
