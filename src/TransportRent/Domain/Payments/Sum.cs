using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Payments
{
    internal record Sum
    {
        public int Value { get; }

        private Sum(int value)
        {
            Value = value;
        }
        public static Sum Create(int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Сумма не может быть отрицательной");
            }
            return new Sum(value);
        }
    }
}
