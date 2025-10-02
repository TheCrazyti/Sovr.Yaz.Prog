using Domain.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Transports
{
    internal class Transport
    {
        public Last_Transport_Location LastLocation { get; private set; }
        public Transport_Location Location { get; private set; }
        public ID_Transport ID { get; private set; }

        public Transport(Last_Transport_Location lastLocation, Transport_Location location, ID_Transport id)
        {
            LastLocation = lastLocation;
            Location = location;
            ID = id;
        }
    }
}
