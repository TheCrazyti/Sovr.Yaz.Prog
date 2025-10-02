using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Transports
{
    internal class Transport_Location
    {
       public string Location { get;  }

       private Transport_Location(string Adress) => Location = Adress;
       
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
