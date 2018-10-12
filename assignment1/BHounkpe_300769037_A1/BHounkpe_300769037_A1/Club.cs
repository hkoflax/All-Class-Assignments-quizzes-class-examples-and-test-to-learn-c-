using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHounkpe_300769037_A1
{
    class Club
    {
        private int clubNumber;
        private static int noOfClub =1;
        private string name;
        private Address clubAddress;
        private Address defaultAddress = new Address(123);
        private long telephoneNumber;
        public Club(): this("Club"+noOfClub,1234567890)
        {

        }
        public Club(string name) : this(name,1234567890)
        {

        }
        public Club(string name,long telNumber)
        {
            this.Address = defaultAddress;
            clubNumber = noOfClub;
            Name = name;
            TelephoneNumber = telNumber;
            noOfClub++;
        }
        public int ClubNumber
        {
            get
            {
                return clubNumber;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Address Address
        {
            get
            {
                return clubAddress;
            }
            set
            {
                clubAddress = value;
            }
        }
        public long TelephoneNumber
        {
            get
            {
                return telephoneNumber;
            }
            set
            {
                telephoneNumber = long.Parse(value.ToString().Substring(0,10));
            }
        }
        public String GetInfo()
        {
            return String.Format(
                "The Name of the Club is {0}\n"+
                "The Club number is {1}\n"+
                "The Club address is {2} {3} {4} {5} {6}\n"+
                "The phone Number of the Club is {7:(###) ###-####}\n"
                , Name,ClubNumber, Address.StreetNumber, Address.StreetName, Address.ZipCode,
                Address.State, Address.Country, TelephoneNumber);
        }
    }
}
