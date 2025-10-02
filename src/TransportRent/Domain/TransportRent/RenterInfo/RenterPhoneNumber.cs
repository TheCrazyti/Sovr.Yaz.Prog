using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain.TransportRent.RenterInfo
{
    internal class RenterPhoneNumber
    {
        public string PhoneNumber { get;}

        private RenterPhoneNumber(string phoneNumber) => PhoneNumber = phoneNumber;
        public static RenterPhoneNumber Create(string value)
        {
            Match match = Regex.Match(value, @"([7|8](\s\d{3}){2}\s\d{2}[-]\d{2})");
            if (match.Success == false)
            {
                throw new Exception("Некорректный формат телефона");
            }
            return new RenterPhoneNumber(value);
        }
    }
}
