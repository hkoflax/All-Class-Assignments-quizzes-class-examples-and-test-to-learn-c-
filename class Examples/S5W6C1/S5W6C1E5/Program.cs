using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace S5W6C1E5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int END = 999;
            const string FILENAME = "Data.ser";
            Employee emp = new Employee();
            FileStream outFile = new FileStream(FILENAME,FileMode.Create, FileAccess.Write);
            BinaryFormatter bFormatter = new BinaryFormatter();
            Write("Enter employee number or " + END +
               " to quit >> ");
            emp.EmpNum = Convert.ToInt32(ReadLine());
            while (emp.EmpNum != END)
            {
                Write("Enter last name >> ");
                emp.Name = ReadLine();
                Write("Enter salary >> ");
                emp.Salary = Convert.ToDouble(ReadLine());
                bFormatter.Serialize(outFile, emp);
                Write("Enter employee number or " + END +
                   " to quit >> ");
                emp.EmpNum = Convert.ToInt32(ReadLine());
            }
            outFile.Close();
            FileStream inFile = new FileStream(FILENAME,FileMode.Open, FileAccess.Read);
            WriteLine("\n{0,-5}{1,-12}{2,8}\n",
               "Num", "Name", "Salary");
            while (inFile.Position < inFile.Length)
            {
                emp = (Employee)bFormatter.Deserialize(inFile);
                WriteLine("{0,-5}{1,-12}{2,8}",
                   emp.EmpNum, emp.Name, emp.Salary.ToString("C"));
            }
        }
    }

    //[Serializable]
        class Employee
    {
        public int EmpNum { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
}
