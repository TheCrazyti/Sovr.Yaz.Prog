using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.TransportRent.RenterInfo
{
    internal class RenterPhoneNumber
    {
        public int PhoneNumber { get;}

        public RenterPhoneNumber(int phoneNumber) => PhoneNumber = phoneNumber;
    }
}
