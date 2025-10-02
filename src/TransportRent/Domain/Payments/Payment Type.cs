using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Payments
{
    internal class Payment_Type
    {
        private static readonly string[] CorrectTypes = ["Наличными","Картой"];
        private Payment_Type(string value)
        {
            Value = value;
        }
        public static Payment_Type Create(string value)
        {
            if ((value != CorrectTypes[0])|| (value != CorrectTypes[1]))
            {
                throw new ArgumentException("Не подходящий тип оплаты");
            }
            return new Payment_Type(value);
        }
        public string Value { get; }
    }
}
