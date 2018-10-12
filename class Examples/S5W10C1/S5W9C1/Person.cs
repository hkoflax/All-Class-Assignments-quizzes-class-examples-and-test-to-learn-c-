using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W10C1
{
    class Person
    {
        private string name;
        private string adress;
        private int age;
        public Person()
        {
            Console.WriteLine("I am in default Constructor");
        }
        public Person(string name, int age)
        {
            Console.WriteLine("I am in Person Constructor");
            Name = name;
            Age = age;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Adress
        {
            get
            {
                return adress;
            }

            set
            {
                adress = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public virtual String GetInfo()
        {
            return string.Format("Name: {0},Adress: {1},Age: {2}",Name,Adress,Age);
        }

        //public override string ToString()
        //{
        //    return GetInfo();
        //}
    }
}
