using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikil_Rai_Store_class
{
    class Customer
    {
        private string id;
        private static int last_Id;
        private double balance;
        private bool forPickup;
        private string name;
        private string Tel;

        public Customer(string name, string tel, double balance = 0, bool forPickup = true)
        {
            last_Id = 501;
                Current_number();

        }
        public string Id
        {
            get
            {
                return id;
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }

        public bool ForPickup
        {
            get
            {
                return forPickup;
            }

            set
            {
                forPickup = value;
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

        public string Tel1
        {
            get
            {
                return Tel;
            }

            set
            {
                Tel = value;
            }
        }
        private string Current_number()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
