using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Util
{
    internal record Velos : TransportType
    {
        public Velos() : base(2,"Велосипед")
        {
        }
    }
}
