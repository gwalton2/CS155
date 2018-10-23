using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8Lab2
{
    class CashPayment : Payment
    {
        public CashPayment(double amount) : base(amount) { }

        public override string PaymentDetails()
        {
            return base.PaymentDetails() + " in cash";
        }
    }
}
