using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Transports
{
    internal record ID_Transport
    {
        public Guid ID { get; }

        private ID_Transport(Guid value)
        {
            ID = value;
        }
        public static ID_Transport Create()
        {
            Guid ID = Guid.NewGuid();

            return new ID_Transport(ID);
        }
        public static ID_Transport Create(Guid value)
        {
            if (Guid.Empty == value)
            {
                throw new ArgumentException("Неверный ID транспорта");
            }
            return new ID_Transport(value);
        }
    }
}
