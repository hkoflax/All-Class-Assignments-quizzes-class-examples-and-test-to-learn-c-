using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W2C2E2
{
    class Employee
    {
        private int idNumber;

        public void Welcome()
        {
            Console.WriteLine("Hello to employee #{0}", idNumber);
            Console.WriteLine("Hello how can I help you?\n");
        }

        public int IdNumber
        {
            set
            {
                if (value < 100)
                {
                    idNumber = value;
                }
                else
                {
                    Console.WriteLine("Id Number must be less then 100! Setting it to 0");
                }
            }

            get
            {
                return idNumber;
            }
        }
    }
}
