using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8Lab2
{
    class Payment
    {
        private double amount;

        public Payment(double amount)
        {
            SetAmount(amount);
        }

        public double GetAmount()
        {
            return Math.Round(amount, 2);
        }

        public void SetAmount(double amount)
        {
            this.amount = amount;
        }

        public virtual string PaymentDetails()
        {
            return "Payment is " + amount.ToString("C");
        }
    }
}
