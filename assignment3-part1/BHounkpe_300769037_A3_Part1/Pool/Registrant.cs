using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolLib
{
    public class Registrant
    {
        private int registrationNumber;
        public static int NoOfRegistrant;
        private string name;
        private DateTime dateOfBirth;
        private Address registrantAddress;
        private static Address defaultAddress = new Address();
        private long phoneNumber;
        private Club club;

        public Registrant(): this(null, new DateTime(0001,01,01),defaultAddress,0)
        {

        }
        public Registrant(string name) : this(name, new DateTime(0001, 01, 01), defaultAddress,0)
        {

        }
        public Registrant(string name,DateTime dOB, Address adress, long telNumber)
        {
            Address = adress;
            NoOfRegistrant++;
            RegistrationNumber = NoOfRegistrant;
            Name = name;
            phoneNumber = telNumber;
            DateOfBirth = dOB;
            club = new Club("Not assigned");
            club.ClubRegistrationNumber = 0;
            NoOfRegistrant--;
        }
        public int RegistrationNumber
        {
            get
            {
                return registrationNumber;
            }
            set
            {
                registrationNumber = value;
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
        public long PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                if (value.ToString().Length > 10)
                {
                    phoneNumber = long.Parse(value.ToString().Substring(0, 10));
                }
                else
                {
                    phoneNumber = value;
                }
            }
        }
        public Club Club
        {
            get
            {
                return club;
            }
            set
            {
                if (club.Name != "Not assigned")
                {
                    if (club.ClubRegistrationNumber != value.ClubRegistrationNumber)
                    {
                        throw new Exception(Name + " is registered with  " + Club.Name + "\n");
                    }
                    else
                    {
                        throw new Exception(Club.Name + " already have " + Name + "\n");
                    }
                }
                else
                {
                    club = value;
                    club.RegistrantList[club.NoOfRegistrantInClub] = this;
                    club.NoOfRegistrantInClub++;
                }
            }
        }
        public string GetInfo()
        {
            return string.Format(
                "Name: {0} \n" +
                "Adress: {2} {3} {4} {5} \n" +
                "Phone: {7}\n"+
                "DOB: {6}\n"+
                "Reg Number: {1}\n"+
                "Club: {8}\n"
                , Name, RegistrationNumber, Address.StreetNameAndNumber,Address.City,
                Address.State,Address.ZipCode, DateOfBirth, PhoneNumber, Club.Name);
        }
        public override string ToString()
        {
            return GetInfo();
        }
    }
}
