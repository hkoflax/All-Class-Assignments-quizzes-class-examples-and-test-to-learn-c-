using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace S5W6C1E3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int END = 999;
            const string DELIM = ",";
            const string FILENAME = "EmployeeData.txt";
            Employee emp = new Employee();
            FileStream outFile = new FileStream(FILENAME,FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
            Console.Write("Enter employee number or " + END +
               " to quit >> ");
            emp.EmpNum = Convert.ToInt32(Console.ReadLine());
            while (emp.EmpNum != END)
            {
                Console.Write("Enter last name >> ");
                emp.Name = ReadLine();
                Console.Write("Enter salary >> ");
                emp.Salary = Convert.ToDouble(Console.ReadLine());
                writer.WriteLine(emp.EmpNum + DELIM + emp.Name +
                   DELIM + emp.Salary);
                Console.Write("Enter next employee number or " +
                   END + " to quit >> ");
                emp.EmpNum = Convert.ToInt32(ReadLine());
            }
            writer.Close();
            outFile.Close();
        }
    }

    class Employee
    {

        public int EmpNum { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
}
