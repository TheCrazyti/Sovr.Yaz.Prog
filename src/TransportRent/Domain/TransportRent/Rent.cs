using Domain.Payments;
using Domain.TransportRent.CompanyInfo;
using Domain.TransportRent.RenterInfo;
using Domain.Transports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.TransportRent
{
    internal class Rent
    {
        public RenterName renterName { get; private set; }
        public RenterPhoneNumber PhoneNumber { get; private set; }
        public RentData RentData { get; private set; }
        public CompanyName CompanyName { get; private set; }
        public CompanyLocation Location { get; private set; }
        public ID_Transport ID { get; private set; }
        public Last_Transport_Location LastLocation { get; private set; }
        public ID_Payment ID_Payment { get; private set; }

        public Rent(RenterName Name, RenterPhoneNumber phoneNumber, RentData rentData, CompanyName companyName, CompanyLocation location, ID_Transport Id, Last_Transport_Location lastLocation, ID_Payment Id_Payment)
        {
            renterName = Name;
            PhoneNumber = phoneNumber;
            RentData = rentData;
            CompanyName = companyName;
            Location = location;
            ID = Id;
            LastLocation = lastLocation;
            ID_Payment = Id_Payment;
        }
    }
}
