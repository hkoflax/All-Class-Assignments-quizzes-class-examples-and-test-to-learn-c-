using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W2C1E1
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
    class Employee
    {
        private int idnumber;

        public void welcome()
        {
            Console.WriteLine("hello to employee #{0}", idnumber);
            Console.WriteLine("Hello, how can i help you?\n");
        }
        public void SetIdNumber(int value)
        {
            if (value < 100)
            {
                idnumber = value;
            }
            else Console.WriteLine("id number sup to 100 set it to 0");

        }
        public int getIdNumber()
        {
            return idnumber;
        }
    }
}
