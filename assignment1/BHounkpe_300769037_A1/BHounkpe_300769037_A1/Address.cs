using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHounkpe_300769037_A1
{
    public struct Address
    {
        public int StreetNumber;
        public string StreetName;
        public string ZipCode;
        public string State;
        public string Country;

        public Address(int sNumber, string sName = "Main Street", string zipCode = "A1B 2C3",
            string sState = "state", string country = "country")
        {
            StreetNumber=sNumber;
            StreetName = sName;
            ZipCode = zipCode;
            State = sState;
            Country = country;
        }
    }
}
