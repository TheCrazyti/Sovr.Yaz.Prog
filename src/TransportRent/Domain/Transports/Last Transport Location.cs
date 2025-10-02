using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Transports
{
    internal class Last_Transport_Location
    {
        public string LastLocation { get; }

        public Last_Transport_Location(string Adress) => LastLocation = Adress;

        public static Transport_Location Create(string Adress)
        {
            if (string.IsNullOrWhiteSpace(Adress))
            {
                throw new ArgumentException("Не указан адрес транспорта");
            }
            return new Transport_Location(Adress);
        }
    }
}
