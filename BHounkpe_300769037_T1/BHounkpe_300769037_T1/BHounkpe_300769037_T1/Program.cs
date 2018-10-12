using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHounkpe_300769037_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------Package1--------------");
            Package package1 = new Package();
            package1.PackageType = Package.PackageTypes.Music;
            Console.WriteLine(package1.Getinfo());

            Console.WriteLine("------------Package2--------------");
            Package package2 = new Package(Package.PackageTypes.Book);
            package2.Height = 10;
            Console.WriteLine(package2.Getinfo());

            Console.WriteLine("------------Package3--------------");
            Package package3 = new Package(Package.PackageTypes.Toy,2,3,4);
            Console.WriteLine(package3.Getinfo());

            Console.WriteLine("------------Package4=Package1+package2--------------");
            Package package4 = package1+package2;
            Console.WriteLine(package4.Getinfo());

            Console.WriteLine("------------Shipment--------------");
            Shipment firstShipment = new Shipment();
            Console.WriteLine(firstShipment.Getinfo());

            Console.WriteLine("------------Shipment after add packages--------------");
            firstShipment.AddPackage(package1);
            firstShipment.AddPackage(package2);
            firstShipment.AddPackage(package3);
            firstShipment.AddPackage(package4);
            Console.WriteLine(firstShipment.Getinfo());
            firstShipment.Save("Shipment");
        }
    }
}
