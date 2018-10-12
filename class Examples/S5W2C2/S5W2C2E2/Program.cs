using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W2C2E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee myAssistant;
            myAssistant = new Employee();

            myAssistant.IdNumber = 105;
            //myAssistant.SetIdNumber(5);

            Employee myBoss = new Employee();

            myBoss.IdNumber=1;

            myAssistant.Welcome();
            myBoss.Welcome();

            Console.WriteLine("My boss' employee # is {0}", myBoss.IdNumber);
        }
    }
}
