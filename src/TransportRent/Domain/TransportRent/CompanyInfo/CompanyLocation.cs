using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.TransportRent.CompanyInfo
{
    internal class CompanyLocation
    {
        public string Location { get; }

        public CompanyLocation(string location) => Location = location;
    }
}
