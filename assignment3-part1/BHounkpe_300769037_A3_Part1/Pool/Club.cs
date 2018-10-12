using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolLib
{
    public class Club
    {
        private int clubRegistrationNumber;
        public int NoOfRegistrantInClub;
        public static int NumberOfClub = 0;
        private string name;
        public Registrant[] RegistrantList;
        private Address clubAddress;
        private static Address defaultAddress = new Address();
        private long phoneNumber;

        public Club() : this(null, defaultAddress, 0)
        {

        }
        public Club(string name) : this(name, defaultAddress, 0)
        {

        }
        public Club(string name, Address adress, long telNumber)
        {
            Address = adress;
            clubRegistrationNumber = ++Registrant.NoOfRegistrant;
            NumberOfClub++;
            Name = name;
            phoneNumber = telNumber;
            RegistrantList = new Registrant[20];
            NoOfRegistrantInClub = 0;
        }
        public int ClubRegistrationNumber
        {
            get
            {
                return clubRegistrationNumber;
            }
            set
            {
                clubRegistrationNumber = value;
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
        public String GetInfo()
        {
            return String.Format(
                "Name: {0} \n" +
                "Adress: {2} {3} {4} {5} \n" +
                "Phone: {6}\n" +
                "Reg Number: {1}\n" +
                "Swimmers:\n" +
                "         {7}"
                , Name, ClubRegistrationNumber, Address.StreetNameAndNumber, Address.City,
                Address.State, Address.ZipCode, PhoneNumber, DisplayRegistrantList());
        }
        public string DisplayRegistrantList()
        {
            if (NoOfRegistrantInClub > 0)
            {
                string result = "";
                Registrant aRegistrant;
                for (int i = 0; i < NoOfRegistrantInClub; i++)
                {
                    aRegistrant = RegistrantList[i];
                    result = result + aRegistrant.Name + "\n         ";
                }
                return result;
            }
            else
            {
                return "";
            }
        }
        public void AddSwimmer(Registrant registrant)
        {
            registrant.Club = this;
        }
        public override string ToString()
        {
            return GetInfo();
        }
    }
}
