using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5W2C2E3_Carpet
{
    class Program
    {
        static void Main(string[] args)
        {

            Carpet aCarpet = new Carpet();

            aCarpet.Length = 5;
            aCarpet.Width = 2;
            //aCarpet.Area = 5;

            aCarpet.TellAboutSelf();
        }
    }
}
