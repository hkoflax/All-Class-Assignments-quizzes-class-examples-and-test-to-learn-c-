using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHounkpe_300769037_A1
{
    class Registrant
    {
        private int registrationNumber;
        private static int noOfRegistrant = 1;
        private string name;
        private DateTime dateOfBirth;
        private Address registrantAddress;
        private static Address defaultAddress = new Address(123);
        private long telephoneNumber;

        public Registrant(): this("Registrant #"+noOfRegistrant,1234567890, DateTime.Today)
        {

        }
        public Registrant(string name) : this(name, 1234567890,DateTime.Today)
        {

        }
        public Registrant(string name, long telNumber, DateTime date)
        {
            registrantAddress = defaultAddress;
            registrationNumber = noOfRegistrant;
            Name = name;
            TelephoneNumber = telNumber;
            DateOfBirth = date;
            noOfRegistrant++;
        }
        public int RegistrationNumber
        {
            get
            {
                return registrationNumber;
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
        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                dateOfBirth = value;
            }
        }
        public Address Address
        {
            get
            {
                return registrantAddress;
            }
            set
            {
                registrantAddress = value;
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
                telephoneNumber = long.Parse(value.ToString().Substring(0, 10));
            }
        }
        public string GetInfo()
        {
            return string.Format(
                "The registrant name is {0} \n" +
                "The registration number is {1} \n" +
                "The registrant address is {2} {3} {4} {5} {6}\n" +
                "The registrant date of birth is {7} \n"+
                "The phone Number of the registrant is {8:(###) ###-####}\n"
                , Name, RegistrationNumber, Address.StreetNumber,Address.StreetName,Address.ZipCode,
                Address.State,Address.Country, DateOfBirth.ToString("MMMM dd, yyyy"), TelephoneNumber);
        }
    }
}
