using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W5C1E1
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance;
            double time;
            double speed = 0;

            try
            {
                Console.WriteLine("Input a distance?");
                distance = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Input time?");
                time = Convert.ToDouble(Console.ReadLine());

                speed = distance / time;
            }
            catch (FormatException ex)
            {

                Console.WriteLine("Format Exception: {0}",ex.Message );
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }

            Console.WriteLine("Your speed is {0}", speed);


        }
    }
}
