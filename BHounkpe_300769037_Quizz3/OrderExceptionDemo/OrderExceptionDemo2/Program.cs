using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderExceptionDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int orderNumber = 0;
            int itemNumber, quantity, dayOrdered;
            Orders[] orders = new Orders[5];

            do
            {
                orderNumber++;
                Console.WriteLine("Please enter Order #{0}", orderNumber);
                Console.Write("Item Number: ");
                itemNumber = int.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                quantity = int.Parse(Console.ReadLine());
                Console.Write("Day Ordered: ");
                dayOrdered = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Orders proceed = new Orders(itemNumber, quantity, dayOrdered);
                orders[orderNumber - 1] = proceed;
            } while (orderNumber<5);
            Console.WriteLine("Item#   Qty   Day#");
            Console.WriteLine("------------------");
            foreach (Orders order in orders)
            {
                Console.WriteLine("{0,5} {1,4} {2,5}",order.ItemNumber,order.Quantity,order.DayOrdered);
            }
        }
    }
}
