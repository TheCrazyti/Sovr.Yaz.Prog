using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Payments
{
    internal record ID_Payment
    {
        public Guid ID { get; }
        private ID_Payment(Guid value)
        {
            ID = value;
        }
        public static ID_Payment Create()
        {
            Guid ID = Guid.NewGuid();

            return new ID_Payment(ID);
        }
        public static ID_Payment Create(Guid value)
        {
            if (Guid.Empty == value)
            {
                throw new ArgumentException("Неверный ID оплаты");
            }
            return new ID_Payment(value);
        }
    }
}
