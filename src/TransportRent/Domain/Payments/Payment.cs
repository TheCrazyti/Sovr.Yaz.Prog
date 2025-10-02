using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Payments
{
    
    internal class Payment
    {
        public Sum Sum { get; private set; }
        public Payment_Type Payment_Type { get; private set; }
        public ID_Payment ID_Payment { get; private set; }

        public Payment(Sum sum,Payment_Type payment_Type,ID_Payment iD_Payment)
        {
            Sum = sum;
            Payment_Type = payment_Type;
            ID_Payment = iD_Payment;
        }
    }
}
