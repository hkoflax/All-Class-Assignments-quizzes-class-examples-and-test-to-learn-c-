using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W2C1E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee myAssistant;
            myAssistant = new Employee();

            //myAssistant.idnumber=5;
            myAssistant.SetIdNumber(105);
            Employee myBoss = new Employee();
            myBoss.SetIdNumber(1);
            myAssistant.welcome();
            myBoss.welcome();

            Console.WriteLine("my boss  employee # is {0}", myBoss.getIdNumber());
        }
    }
}
