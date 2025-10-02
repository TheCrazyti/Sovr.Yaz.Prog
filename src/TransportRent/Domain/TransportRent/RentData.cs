using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.TransportRent
{
    internal class RentData
    {
        public DateTime rentData { get; }

        private RentData(DateTime dateTime)
        {
            rentData = dateTime;
        }

        public static RentData Create(DateTime dateTime)
        {
            if (dateTime==DateTime.MinValue)
            {
                throw new ArgumentNullException("Не указана дата аренды");
            }
            return new RentData(dateTime);
        }
    }
}
