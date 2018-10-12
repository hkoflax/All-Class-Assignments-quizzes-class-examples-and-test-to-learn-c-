using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Orders order1 = new Orders(105,12,50);
                Console.WriteLine("Order proceed Succesully");
            }
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
