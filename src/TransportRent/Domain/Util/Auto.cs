using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Util
{
    internal record Auto : TransportType
    {
        public Auto() : base(0,"Автомобиль")
        {

        }
    }
}
