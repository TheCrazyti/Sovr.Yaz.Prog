using Domain.TransportRent.CompanyInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.TransportRent.RenterInfo
{
    internal class Renter
    {
        public RenterName Name { get; private set; }
        public RenterPhoneNumber PhoneNumber { get; private set; }
        public Renter(RenterName name, RenterPhoneNumber phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
    }
}
