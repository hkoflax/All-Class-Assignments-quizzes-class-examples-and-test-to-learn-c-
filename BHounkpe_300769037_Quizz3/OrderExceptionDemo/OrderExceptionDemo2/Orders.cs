using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderExceptionDemo2
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
            get
            {
                return itemNumber;
            }
            set
            {
                itemNumber = value;
                if (itemNumber < 100 || itemNumber>999)
                {
                    itemNumber = 0;
                }
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
                if (quantity < 1 || quantity>12)
                {
                    quantity = 0;
                }
            }
        }
        public int DayOrdered
        {
            get
            {
                return dayOrdered;
            }
            set
            {
                dayOrdered = value;
                if (dayOrdered < 1 || dayOrdered>31)
                {
                    dayOrdered = 0;
                }
            }
        }
    }
}
