using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W2C2E1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee myAssistant;
            myAssistant = new Employee();

            //myAssistant.idNumber = 5;
            myAssistant.SetIdNumber(105);

            Employee myBoss = new Employee();

            myBoss.SetIdNumber(1);

            myAssistant.Welcome();
            myBoss.Welcome();

            Console.WriteLine("My boss' employee # is {0}", myBoss.GetIdNumber());
        }
    }
}
