using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolLib
{
    public struct Address
    {
        public string StreetNameAndNumber;
        public string ZipCode;
        public string State;
        public string City;

        public Address(string streetNameAndNumber,string streetcity,string streetState, string streetZipcode)
        {
            StreetNameAndNumber = streetNameAndNumber;
            ZipCode = streetZipcode;
            State = streetState;
            City = streetcity;
        }
    }
}
