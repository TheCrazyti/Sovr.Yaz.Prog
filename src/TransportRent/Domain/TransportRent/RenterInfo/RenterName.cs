using Domain.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.TransportRent.RenterInfo
{
    internal class RenterName
    {
        public string Name {get;}

        private RenterName(string name) => Name = name;

        public static RenterName Create(string value)
        {
            if ((string.IsNullOrWhiteSpace==null))
            {
                throw new ArgumentException("Пустая строка");
            }

            if ((value.Length>=60))
            {
                throw new ArgumentException("Слишком длинное имя");
            }

            return new RenterName(value);
        }

    }
}
