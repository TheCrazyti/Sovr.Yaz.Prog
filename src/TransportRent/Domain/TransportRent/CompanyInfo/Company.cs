using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.TransportRent.CompanyInfo
{
    internal class Company
    {
        public CompanyName Name { get; private set; }
        public CompanyLocation Location { get; private set; }

        public Company(CompanyName name, CompanyLocation location)
        {
            Name = name;
            Location = location;
        }
    }
}
