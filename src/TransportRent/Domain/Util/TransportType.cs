using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Util
{
    abstract record TransportType : Enumeration <TransportType>
    {
        protected TransportType(int key, string name) : base(key, name)
        {
        }
    }
}
