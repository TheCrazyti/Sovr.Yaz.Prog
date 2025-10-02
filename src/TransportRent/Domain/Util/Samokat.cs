using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Util
{
    internal record Samokat : TransportType
    {
        public Samokat() : base(1,"Самокат")
        {
        }
    }
}
