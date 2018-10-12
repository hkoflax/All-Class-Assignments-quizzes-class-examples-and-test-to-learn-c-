using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderExceptionDemo
{
    class Orders
    {
        private int itemNumber;
        private int quantity;
        private int dayOrdered;

        public Orders(): this (500,24,28)
        {
        }
        public Orders(int itemNumber, int quantity, int dayOrdered)
        {
            ItemNumber = itemNumber;
            Quantity = quantity;
            DayOrdered = dayOrdered;
        }
        public int ItemNumber
        {
            set
            {
                itemNumber = value;
                if (itemNumber < 100 || itemNumber>999)
                {
                    Exception error = new Exception("The item number is less than 100");
                    throw error;
                }
            }
        }
        public int Quantity
        {
            set
            {
                quantity = value;
                if (quantity < 1 || quantity>12)
                {
                    Exception error = new Exception("The Quantity of the item mus te between 1-12");
                    throw error;
                }
            }
        }
        public int DayOrdered
        {
            set
            {
                dayOrdered = value;
                if (dayOrdered < 1 || dayOrdered>31)
                {
                    Exception error = new Exception("The day must be between 1-31");
                    throw error;
                }
            }
        }
    }
}
